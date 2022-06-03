using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace berber_program
{
    class cadisyon
    {
        cgenel gnl = new cgenel();

        #region fields
        private int _id;
        private decimal _tutar;
        private DateTime _tarih;
        private int _calisanid;
        private int _durum;


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

        public decimal Tutar
        {
            get
            {
                return _tutar;
            }

            set
            {
                _tutar = value;
            }
        }

        public DateTime Tarih
        {
            get
            {
                return _tarih;
            }

            set
            {
                _tarih = value;
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

        public int Durum
        {
            get
            {
                return _durum;
            }

            set
            {
                _durum = value;
            }
        }
        #endregion

        public int getByAddition(int calisanid)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select top 1 id From adisyon where calisanid=@calisanid Order by id desc", con);

            cmd.Parameters.Add("@calisanid", SqlDbType.Int).Value = calisanid;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                calisanid = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                con.Close();
            }
            return calisanid;
        }
        public bool setbyadditionnew(cadisyon bilgiler)
        {
            bool sonuc = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("insert into adisyon(tarih,calisanid,durum) values (@tarih,@calisanid,@durum)", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@tarih", SqlDbType.DateTime).Value = bilgiler.Tarih;
                cmd.Parameters.Add("@calisanid", SqlDbType.Int).Value = bilgiler.Calisanid;
                cmd.Parameters.Add("@durum", SqlDbType.Bit).Value = 0;
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

        public void adisyonclose(int adisyonid, int durum)
        {

            SqlConnection con = new SqlConnection(gnl.conString);

            SqlCommand cmd = new SqlCommand("update adisyon set durum=@durum where id=@adisyonid", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("adisyonid", SqlDbType.Int).Value = adisyonid;
                cmd.Parameters.Add("durum", SqlDbType.Int).Value = durum;

                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                con.Dispose();
                con.Close();
            }

        }
    }
}
