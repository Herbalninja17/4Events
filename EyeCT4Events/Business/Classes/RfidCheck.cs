using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EyeCT4Events.Data;

namespace EyeCT4Events.Business.Classes
{
    class RfidCheck
    {
        public void CheckIn(string rfidcode, int account)
        {
            InOutSql(rfidcode, account, 1);
        }

        public void CheckOut(string rfidcode, int account)
        {
            InOutSql(rfidcode, account, 0);
        }

        public void InOutSql(string rfidcode, int account, int aanwezig)
        {
            try
            {
                Datacom.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Datacom.connect;
                cmd.CommandText = "INSERT INTO Polsband(BandID,AccountAccountID, Aanwezig) VALUES ('" + rfidcode + "', '" + account + "', '" + aanwezig + "');";

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Datacom.CloseConnection();
            }
        }
    }
}
