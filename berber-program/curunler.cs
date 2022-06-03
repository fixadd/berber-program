using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Globalization;


namespace berber_program
{
    class curunler
    {
        cgenel gnl = new cgenel();

        #region fields
        private int _urunid;
        private int _kategoriid;
        private string _urunad;
        private decimal _fiyat;
        private string _aciklama;
        #endregion
        #region property
        public int Urunid
        {
            get
            {
                return _urunid;
            }

            set
            {
                _urunid = value;
            }
        }

        public int Kategoriid
        {
            get
            {
                return _kategoriid;
            }

            set
            {
                _kategoriid = value;
            }
        }

        public string Urunad
        {
            get
            {
                return _urunad;
            }

            set
            {
                _urunad = value;
            }
        }

        public decimal Fiyat
        {
            get
            {
                return _fiyat;
            }

            set
            {
                _fiyat = value;
            }
        }

        public string Aciklama
        {
            get
            {
                return _aciklama;
            }

            set
            {
                _aciklama = value;
            }
        } 
        #endregion

        //urun adına göre listeleme
      public void urunlerilistelebyurunadi(ListView lv ,string urunadi)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select * from urunler inner join urunad like '%'+@urunad+'%'", con);

            SqlDataReader dr = null;
            cmd.Parameters.Add("@urunad", SqlDbType.VarChar).Value = urunadi;
            try
            {
                if (con.State == ConnectionState.Closed) 
                    con.Open(); 

                dr = cmd.ExecuteReader();
                int sayac = 0;
                while(dr.Read())
                {
                    lv.Items.Add(dr["id"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["kategoriid"].ToString());                    
                    lv.Items[sayac].SubItems.Add(dr["urunad"].ToString());
                    lv.Items[sayac].SubItems.Add(Math.Round(double.Parse(dr["fiyat"].ToString()), 2).ToString());
                    
                   
                    sayac++;
                }
            }
            catch(SqlException ex)
            {
                string hata = ex.Message;
                    
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
        }
        //urunekle
        public int urunekle(curunler u)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("insert into urunler(urunad,kategoriid,aciklama,fiyat) values (@urunad,@katid,@aciklama,@fiyat)",con);

            try
            {
                if (con.State==ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@urunad", SqlDbType.VarChar).Value = u._urunad;
                cmd.Parameters.Add("@katid", SqlDbType.Int).Value = u._kategoriid;
                cmd.Parameters.Add("@aciklama", SqlDbType.VarChar).Value = u._aciklama;
                cmd.Parameters.Add("@fiyat", SqlDbType.Money).Value = u._fiyat;
                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return sonuc;
        }

        //urunler ve kategorileri listele
        public void urunlerilistele(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select urunler.*,kategoriadi  from urunler inner join kategoriler on kategoriler.id=urunler.kategoriid where urunler.durum=0 ", con);

            SqlDataReader dr = null;
           
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(dr["id"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["kategoriid"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["kategoriadi"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["urunad"].ToString());
                    lv.Items[sayac].SubItems.Add(Math.Round(double.Parse(dr["fiyat"].ToString()), 2).ToString());
                    // lv.Items[sayac].SubItems.Add(string.Format("{0:#.##}", dr["fiyat"].ToString()));
                    // string input = dr["fiyat"].ToString();
                    //lv.Items[sayac].SubItems.Add(decimal.Parse(input,NumberStyles.AllowCurrencySymbol|NumberStyles.Number).ToString());
                    lv.Items[sayac].SubItems.Add(dr["aciklama"].ToString());
                    
                    sayac++;
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;

            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
        }

        //urunleri güncelleme
        public int urunguncelle(curunler u)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("update urunler set urunad=@urunad,kategoriid=@katid,aciklama=@aciklama,fiyat=@fiyat where id=@urunid",con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@urunad", SqlDbType.VarChar).Value = u._urunad;
                cmd.Parameters.Add("@katid", SqlDbType.Int).Value = u._kategoriid;
                cmd.Parameters.Add("@aciklama", SqlDbType.VarChar).Value = u._aciklama;
                cmd.Parameters.Add("@fiyat", SqlDbType.Money).Value = u._fiyat;
                cmd.Parameters.Add("@urunid", SqlDbType.Int).Value = u._urunid;
                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return sonuc;
        }
        //urunlerisil
        public int urunsil(curunler u)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("update urunler set durum=1 where id=@urunid", con);                     
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@urunid", SqlDbType.Int).Value = u._urunid;
                sonuc = Convert.ToInt32(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            return sonuc;
        }

        public void urunlerilistelebyurunid(ListView lv, int urunid)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select urunler.*,kategoriadi  from urunler inner join kategoriler on kategoriler.id=urunler.kategoriid where urunler.durum=0  and urunler.kategoriid=@urunid ", con);

            SqlDataReader dr = null;
            cmd.Parameters.Add("@urunid", SqlDbType.Int).Value = urunid;
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(dr["id"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["kategoriid"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["kategoriadi"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["urunad"].ToString());
                    lv.Items[sayac].SubItems.Add(Math.Round(double.Parse(dr["fiyat"].ToString()), 2).ToString());
                    sayac++;
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;

            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
        }

        //butun urun 2tarih arası
        public void urunlerilisteleistatistikleregore(ListView lv,DateTimePicker baslangic,DateTimePicker bitis )
        {
            
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand(" select top 10 dbo.urunler.urunad , sum(dbo.satislar.adet) as adet from dbo.kategoriler inner join dbo.urunler on dbo.kategoriler.id=dbo.urunler.kategoriid inner join dbo.satislar on dbo.urunler.id=dbo.satislar.urunid inner join dbo.adisyon on dbo.satislar.adisyonid=dbo.adisyon.id where (convert(datetime,tarih,104) between convert (datetime,@baslangic,104) and convert (datetime,@bitis,104)) group bydbo.urunler.urunad order by adet desc", con);

            SqlDataReader dr = null;
            cmd.Parameters.Add("@baslangic", SqlDbType.VarChar).Value = baslangic.Value.ToShortDateString();
            cmd.Parameters.Add("@bitis", SqlDbType.VarChar).Value = bitis.Value.ToShortDateString(); ;
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(dr["urunad"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["adet"].ToString());                
                    sayac++;
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;

            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
        }
        //belli kategoriye ait ürünleri listeleme
        public void urunlerilisteleistatistikleregoreurunid(ListView lv, DateTimePicker baslangic, DateTimePicker bitis,int urunkatid)
        {

            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand(" select top 10 dbo.urunler.urunad , sum(dbo.satislar.adet) as adet from dbo.kategoriler inner join dbo.urunler on dbo.kategoriler.id=dbo.urunler.kategoriid inner join dbo.satislar on dbo.urunler.id=dbo.satislar.urunid inner join dbo.adisyon on dbo.satislar.adisyonid=dbo.adisyon.id where (convert(datetime,tarih,104) between convert (datetime,@baslangic,104) and convert (datetime,@bitis,104)) and (dbo.urunler.kategoriid=@katid) group by dbo.urunler.urunad order by adet desc", con);

            SqlDataReader dr = null;
            cmd.Parameters.Add("@baslangic", SqlDbType.VarChar).Value = baslangic.Value.ToShortDateString();
            cmd.Parameters.Add("@bitis", SqlDbType.VarChar).Value = bitis.Value.ToShortDateString();
            cmd.Parameters.Add("@katid", SqlDbType.Int).Value = urunkatid;
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(dr["urunad"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["adet"].ToString());
                    sayac++;
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;

            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
        }

    }
}
