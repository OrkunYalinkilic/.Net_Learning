using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DataAccessLayer
    {
        SqlConnection connect;
        SqlCommand command;
        SqlDataReader reader;

        public DataAccessLayer()
        {
            connect = new SqlConnection();
            connect.ConnectionString = "Data Source=.;Initial Catalog=AdoNet,User ID=sa; Password=1"; // gideceği sql sunucu
        }
        internal void BaglantiAyarla()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
            {
                connect.Open();
            }
            else
            {
                connect.Close();
            }
        }
        internal int VeriKaydet(Musteri m)
        {
            // databese içerisine kaydetme işlemleri
            return 1;
        }

    }
}
