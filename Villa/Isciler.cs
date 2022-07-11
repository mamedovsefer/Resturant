using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Villa
{
    class Isciler
    {
        
        #region Fields
        private int _IsciId;
        private int _IsciGorevId;
        private string _IsciAd;
        private string _IsciSoyad;
        private string _IsciSifre;
        private string _IsciKullaniciAdi;
        private bool _IsciDurumu;
        #endregion

        #region Properties
        public int IsciId { get => _IsciId; set => _IsciId = value; }
        public int IsciGorevId { get => _IsciGorevId; set => _IsciGorevId = value; }
        public string IsciAd { get => _IsciAd; set => _IsciAd = value; }
        public string IsciSoyad { get => _IsciSoyad; set => _IsciSoyad = value; }
        public string IsciSifre { get => _IsciSifre; set => _IsciSifre = value; }
        public string IsciKullaniciAdi { get => _IsciKullaniciAdi; set => _IsciKullaniciAdi = value; }
        public bool IsciDurumu { get => _IsciDurumu; set => _IsciDurumu = value; } 
        #endregion


        public bool personelEntryControl(string password,int UserId)
        {
            bool result = false;

            SqlConnection con = new SqlConnection(Connection.GetConnectionString());
            SqlCommand cmd = new SqlCommand("Select * from ISCILER where ID=@Id and SIFRE=@password", con);
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = UserId;
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password;

            try
            {
                if (con.State==ConnectionState.Closed)
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

        public void isciGetInfo(ComboBox cb)
        {
            cb.Items.Clear();
            SqlConnection con = new SqlConnection(Connection.GetConnectionString());
            SqlCommand cmd = new SqlCommand("Select * from ISCILER", con);
          
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Isciler i = new Isciler();
                i._IsciId = Convert.ToInt32(dr["ID"]);
                i._IsciGorevId = Convert.ToInt32(dr["GOREVID"]);
                i._IsciAd = Convert.ToString(dr["AD"]);
                i._IsciSoyad = Convert.ToString(dr["SOYAD"]);
                i._IsciSifre = Convert.ToString(dr["SIFRE"]);
                i._IsciKullaniciAdi = Convert.ToString(dr["KULLANICIADI"]);
                i._IsciDurumu = Convert.ToBoolean(dr["DURUM"]);
                cb.Items.Add(i);
            }
            dr.Close();
            con.Close();
            
        }
        public override string ToString()
        {
            return IsciAd+" "+IsciSoyad;
        }
    }
}
