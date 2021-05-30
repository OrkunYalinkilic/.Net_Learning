using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsServiceInceleme
{
    public class DAL
    {
        SqlConnection con;
        SqlCommand cmd;
        int returnValues;

        public DAL()
        {
            con = new SqlConnection();
        }
        public int OlayGunluguYeniKayit(string Olay, DateTime OlusturmaTarih)
        {
            try
            {
                cmd = new SqlCommand("insert into OlayGunlugu(Olay,OlusturmaTarihi) = values(@Olay,@OlusturmaTarih)", con);
                cmd.Parameters.Add("@Olay", SqlDbType.NVarChar).Value = Olay;
                cmd.Parameters.Add("@OlusturmaTarih", SqlDbType.DateTime).Value = OlusturmaTarih;
                con.Open();
                returnValues = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
 
                throw;
            }
            finally
            {
                con.Close();//Buraya her zaman gelinir.
            }
            return returnValues;
        }


    }
}
