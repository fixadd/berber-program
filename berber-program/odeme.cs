using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace berber_program
{
    class odeme
    {
        cgenel gnl = new cgenel();
        #region fields
        private int _odemeid;
        private int _adisyonid;
        private int _odemeturid;
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

        public int Odemeturid
        {
            get
            {
                return _odemeturid;
            }

            set
            {
                _odemeturid = value;
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
            SqlCommand cmd = new SqlCommand("insert into hesapodemeleri(adisyonid,odemeturid,aratoplam,kdvtutari,toplamtutar,indirim)values(@adisyonid,@odemeturid,@aratoplam,@kdvtutari,@toplamtutar,@indirim)", con);


            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("adisyonid", SqlDbType.Int).Value = bill.Adisyonid;
                cmd.Parameters.Add("odemeturid", SqlDbType.Int).Value = bill.Odemeturuid;
                cmd.Parameters.Add("aratoplam", SqlDbType.Money).Value = bill.Aratoplam;
                cmd.Parameters.Add("kdvtutari", SqlDbType.Money).Value = bill.Kdvtutari;
                cmd.Parameters.Add("toplamtutar", SqlDbType.Money).Value = bill.Toplamtutar;
                cmd.Parameters.Add("indirim", SqlDbType.Money).Value = bill.Indirim;

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
    }
}
