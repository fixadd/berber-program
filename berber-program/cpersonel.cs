using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace berber_program
{
    class cpersonel
    {
        cgenel gnl = new cgenel();
        #region Fields
        private int _personelid;
        private string _kullaniciadi;
        private string _parola;
        #endregion
        #region Properties

        public int Personelid
        {
            get
            {
                return _personelid;
            }

            set
            {
                _personelid = value;
            }
        }

        public string Kullaniciadi
        {
            get
            {
                return _kullaniciadi;
            }

            set
            {
                _kullaniciadi = value;
            }
        }

        public string Parola
        {
            get
            {
                return _parola;
            }

            set
            {
                _parola = value;
            }
        }
       
       


        #endregion
        public bool personelEntryControl(string password, int UserId)

        {
            bool result = false;
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from personel where id=@Id and parola=@password", con);
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = UserId;
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;


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

                throw;
            }
            return result;

        }
        public void personelGetbyInformation(ComboBox cb)
        {
            cb.Items.Clear();
            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from personel ", con);



            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cpersonel p = new cpersonel();
                p._personelid = Convert.ToInt32(dr["id"]);
                p._kullaniciadi = Convert.ToString(dr["kullaniciadi"]);
                p._parola = Convert.ToString(dr["parola"]);
                cb.Items.Add(p);

            }
            dr.Close();
            con.Close();




        }
        public override string ToString()
        {
            return Kullaniciadi;

        }
    }
    }
