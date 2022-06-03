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
    class csiparis
    {
        cgenel gnl = new cgenel();
        #region fields
        private int _id;
        private int _adisyonid;
        private int _urunid;
        private int _calisanid;
        private int _adet;


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

        public int Adisyonid
        {
            get
            {
                return _adisyonid;
            }

            set
            {
                _adisyonid = value;
            }
        }

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

        public int Calisanid
        {
            get
            {
                return _calisanid;
            }

            set
            {
                _calisanid = value;
            }
        }

        public int Adet
        {
            get
            {
                return _adet;
            }

            set
            {
                _adet = value;
            }
        }
        #endregion

        public void getbyorder(ListView lv, int adisyonid)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("select urunad,fiyat,satislar.id,satislar.urunid,satislar.adet from satislar inner join urunler on satislar.urunid=urunler.id where adisyonid=@adisyonid", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@adisyonid", SqlDbType.Int).Value = adisyonid;
            try
            {
                
                if (con.State == ConnectionState.Closed)
                {
                    
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                int sayac = 0;
                while (dr.Read())
                {
                    lv.Items.Add(dr["urunad"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["adet"].ToString());
                    lv.Items[sayac].SubItems.Add(dr["urunid"].ToString());
                    lv.Items[sayac].SubItems.Add(Convert.ToString(Convert.ToDecimal(dr["fiyat"]) * Convert.ToDecimal(dr["adet"])));
                    lv.Items[sayac].SubItems.Add(dr["id"].ToString());

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

        public bool setsaveorder(csiparis bilgiler)
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("insert into satislar(adisyonid,urunid,adet,calisanid) values(@adisyonid,@urunid,@adet,@calisanid)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("@adisyonid", SqlDbType.Int).Value = bilgiler._adisyonid;
                cmd.Parameters.Add("@urunid", SqlDbType.Int).Value = bilgiler._urunid;
                cmd.Parameters.Add("@adet", SqlDbType.Int).Value = bilgiler._adet;
                cmd.Parameters.Add("@calisanid", SqlDbType.Int).Value = bilgiler._calisanid;
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
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

        public void setdeleteorder(int satisid)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("delete from satislar where id=@satislarid", con);

            cmd.Parameters.Add("@satislarid", SqlDbType.Int).Value = satisid;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.ExecuteNonQuery();
            con.Dispose();
            con.Close();
        }



        }
    }

