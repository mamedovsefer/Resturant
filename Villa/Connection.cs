using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villa
{
    class Connection
    {
        public static string GetConnectionString()
        {
            string constring = "Data Source=DESKTOP-GHH298M\\SQLEXPRESS; Initial Catalog=Villa; Integrated Security=true";
            return constring;
        }
        public static int _isciId;
        public static int _gorevId;

        public static string _ButtonValue;
        public static string _ButtonName;
    }
}
