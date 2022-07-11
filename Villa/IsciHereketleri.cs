using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Villa
{
    class IsciHereketleri
    {
        Connection cn = new Connection();
        #region Fields
        private int _ID;
        private int _PersonelId;
        private string _Islem;
        private DateTime _Tarix;
        private bool _Durum;

        #endregion

        #region Properties
        public int ID { get => _ID; set => _ID = value; }
        public int PersonelId { get => _PersonelId; set => _PersonelId = value; }
        public string Islem { get => _Islem; set => _Islem = value; }
        public DateTime Tarix { get => _Tarix; set => _Tarix = value; }
        public bool Durum { get => _Durum; set => _Durum = value; } 
        #endregion

        public bool IsciAutoSave(IsciHereketleri ih)
        {
            bool result = false;
            SqlConnection con = new SqlConnection(Connection.GetConnectionString());
            SqlCommand cmd = new SqlCommand("Insert Into ISCIHAREKETLERI(PERSONELID,ISLEM,TARIX)Values(@personelId,@islem,@tarix)", con);

            try
            {
                if (con.State==ConnectionState.Closed)
                {
                    con.Open();
                }
                cmd.Parameters.Add("@personelId", SqlDbType.Int).Value = ih._PersonelId;
                cmd.Parameters.Add("@islem", SqlDbType.VarChar).Value = ih._Islem;
                cmd.Parameters.Add("@tarix", SqlDbType.DateTime).Value = ih._Tarix;

                result =Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {

                string hata = ex.Message;
                throw;
            }
            return result;

        }
    }
}
