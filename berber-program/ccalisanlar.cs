using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace berber_program
{
    class ccalisanlar
    {
        #region fields
        private int _id;
        private int _durum;
        private int _onay;
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

        public int Onay
        {
            get
            {
                return _onay;
            }

            set
            {
                _onay = value;
            }
        }

        #endregion

        cgenel gnl = new cgenel();

  

        public string SessionSum(int state, string calisanid)
        {
            string dt = "";
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select tarih,calisanid From adisyon Right Join calisanlar on adisyon.calisanid=calisanlar.id Where calisanlar.durum=@durum and adisyon.durum=0 and calisanlar.id=@calisanid", con);
            SqlDataReader dr = null;
            cmd.Parameters.Add("@durum", SqlDbType.Int).Value = state;
            cmd.Parameters.Add("@calisanid", SqlDbType.Int).Value = Convert.ToInt32(calisanid);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dt = Convert.ToDateTime(dr["tarih"]).ToString();
                }

            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                dr.Close();
                con.Dispose();
                con.Close();
            }
            return dt;
        }

        public int TableGetbyNumber(string TableValue)
        {
            string aa = TableValue;
            int lenght = aa.Length;
          
            
                return Convert.ToInt32(aa.Substring(lenght - 1, 1));
            

            
        }

        public bool TableGetbyState(int ButtonName, int state)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select durum From  calisanlar  where id=@tableid and durum=@state", con);

            cmd.Parameters.Add("@tableid", SqlDbType.Int).Value = ButtonName;
            cmd.Parameters.Add("@state", SqlDbType.Int).Value = state;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                result = Convert.ToBoolean(cmd.ExecuteScalar());
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
            return result;
        }

        public void setchangetablestate(string butonname, int state)
        {
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("update calisanlar set durum=@durum where id=@calisanno", con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string aa = butonname;
            int uzunluk = aa.Length;
            cmd.Parameters.Add("@durum", SqlDbType.Int).Value = state;
            cmd.Parameters.Add("@calisanno", SqlDbType.Int).Value = aa.Substring(uzunluk - 1, 1);
            cmd.ExecuteNonQuery();
            con.Dispose();
            con.Close();

        }
    }
}
