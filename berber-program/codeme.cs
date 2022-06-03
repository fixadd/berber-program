using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace berber_program
{
    class codeme
    {
        cgenel gnl = new cgenel();
        #region fields
        private int _odemeid;
        private int _adisyonid;
        private int _odemeturuid;
        private decimal _aratoplam;
        private decimal _indirim;
        private decimal _kdvtutari;
        private decimal _toplamtutar;
        private DateTime _tarih;
        private int _calisanid;


        #endregion
        #region properties
        public int Odemeid
        {
            get
            {
                return _odemeid;
            }

            set
            {
                _odemeid = value;
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

        public int Odemeturuid
        {
            get
            {
                return _odemeturuid;
            }

            set
            {
                _odemeturuid = value;
            }
        }

        public decimal Aratoplam
        {
            get
            {
                return _aratoplam;
            }

            set
            {
                _aratoplam = value;
            }
        }

        public decimal Indirim
        {
            get
            {
                return _indirim;
            }

            set
            {
                _indirim = value;
            }
        }

        public decimal Kdvtutari
        {
            get
            {
                return _kdvtutari;
            }

            set
            {
                _kdvtutari = value;
            }
        }

        public decimal Toplamtutar
        {
            get
            {
                return _toplamtutar;
            }

            set
            {
                _toplamtutar = value;
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
        #endregion

        public bool billclose(codeme bill)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("insert into hesapodemeleri(adisyonid,odemeturuid,aratoplam,kdvtutari,toplamtutar,indirim)values(@adisyonid,@odemeturuid,@aratoplam,@kdvtutari,@toplamtutar,@indirim)", con);


            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("adisyonid", SqlDbType.Int).Value = bill._adisyonid;
                cmd.Parameters.Add("odemeturuid", SqlDbType.Int).Value = bill._odemeturuid;
                cmd.Parameters.Add("aratoplam", SqlDbType.Money).Value = bill._aratoplam;
                cmd.Parameters.Add("kdvtutari", SqlDbType.Money).Value = bill._kdvtutari;
                cmd.Parameters.Add("toplamtutar", SqlDbType.Money).Value = bill._toplamtutar;
                cmd.Parameters.Add("indirim", SqlDbType.Money).Value = bill._indirim;

                result = Convert.ToBoolean(cmd.ExecuteNonQuery());
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
            return result;
        }

        public decimal sumtotalforcliendid(int calisanid)

        {
            decimal total = 0;
            SqlConnection con = new SqlConnection(gnl.conString);

            SqlCommand cmd = new SqlCommand("select sum(toplamtutar) as total from hesapodemeleri where calisanid=@calisanid", con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.Add("calisanid", SqlDbType.Int).Value = calisanid;
                total = Convert.ToDecimal(cmd.ExecuteScalar());
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
            return total;
        }

    }
}
