using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace berber_program
{
    class curuncesitleri
    {
        cgenel gnl = new cgenel();
        #region field
        private int _id;
        private string _kategoriadi;
        private string _aciklama;


        #endregion

        #region properties
        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string Kategoriadi
        {
            get
            {
                return _kategoriadi;
            }

            set
            {
                _kategoriadi = value;
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

        public void getbyproducttypes(ListView cesitler, Button btn)
        {
            cesitler.Items.Clear();
            SqlConnection conn = new SqlConnection(gnl.conString);
            SqlCommand comm = new SqlCommand("select urunad,fiyat,urunler.id from kategoriler inner join urunler on kategoriler.id=urunler.kategoriid where urunler.kategoriid=@kategoriid", conn);

            string aa = btn.Name;
            int uzunluk = aa.Length;

            comm.Parameters.Add("@kategoriid", SqlDbType.Int).Value = aa.Substring(uzunluk - 1, 1);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlDataReader dr = comm.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                cesitler.Items.Add(dr["urunad"].ToString());
                //cesitler.Items[i].SubItems.Add(dr["fiyat"].ToString());
                cesitler.Items[i].SubItems.Add(Math.Round(double.Parse(dr["fiyat"].ToString()), 2).ToString());
                cesitler.Items[i].SubItems.Add(dr["id"].ToString());
                i++;
            }
            dr.Close();
            conn.Dispose();
            conn.Close();
        }
        //ürün çeşitlerini getir combobox
        public void uruncesitlerinigetircb(ComboBox cb)
        {
            cb.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select * from kategoriler where durum=0", con);

            SqlDataReader dr = null;

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    curuncesitleri uc = new curuncesitleri();
                    uc._id = Convert.ToInt32(dr["id"]);
                    uc._kategoriadi = dr["kategoriadi"].ToString();
                    uc._aciklama = dr["aciklama"].ToString();

                    cb.Items.Add(uc);
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
        //ürün çeşitlerini getir listview
        public void uruncesitlerinigetir(ListView lv)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select * from kategoriler where durum=0 ", con);

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
                    lv.Items[sayac].SubItems.Add(dr["kategoriadi"].ToString());
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
        //urunçeşitlerini getir listview arama
        public void uruncesitlerinigetir(ListView lv,string source)
        {
            lv.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select * from kategoriler where durum=0 and kategoriadi like '%'+ @source +'%' ", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@source", SqlDbType.VarChar).Value = source;
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();

                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(dr["id"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["kategoriadi"].ToString());
                    //lv.Items[sayac].SubItems.Add(dr["aciklama"].ToString());

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
        //urunçeşitlerini ekleme  
        public int urunkategoriekle(curuncesitleri u)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("insert into kategoriler(kategoriadi,aciklama) values (@kategoriadi,@aciklama)", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@kategoriadi", SqlDbType.VarChar).Value = u._kategoriadi;
                cmd.Parameters.Add("@aciklama", SqlDbType.VarChar).Value = u._aciklama;              
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
        //urun çeşitleri güncelle
        public int urunkategoriguncelle(curuncesitleri u)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("update kategoriler set kategoriadi=@kategoriadi,aciklama=@aciklama where id=@katid", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@kategoriadi", SqlDbType.VarChar).Value = u._kategoriadi;
                cmd.Parameters.Add("@aciklama", SqlDbType.VarChar).Value = u._aciklama;
                cmd.Parameters.Add("@katid", SqlDbType.Int).Value = u._id;
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

        //urun çeşitleri sil
        public int urunkategorisil(int  id)
        {
            int sonuc = 0;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("update kategoriler set durum=1 where id=@katid", con);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }                
                cmd.Parameters.Add("@katid", SqlDbType.Int).Value = id;
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

        public override string ToString()
        {
            return Kategoriadi;
        }

    }
}
