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

        public RfidCheck()
        {

        }

        public void CheckInFisrtTime(string rfidcode, string account)
        {
            int AcID = 0; ;
            try
            {
                try
                {
                    Datacom.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Datacom.connect;
                    cmd.CommandText = "Select AccountID From Account Where Email = @Data";
                    cmd.Parameters.Add(new SqlParameter("Data", account)); //(@string waarde, parameter waarde)
                    cmd.ExecuteNonQuery();                  //execute het query
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        AcID = Convert.ToInt32(reader["AccountID"]);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                finally
                {
                    Datacom.CloseConnection();
                }
                Datacom.OpenConnection();
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = Datacom.connect;
                cmd1.CommandText = "INSERT INTO Polsband(BandID,AccountAccountID, Aanwezig) VALUES ('" + rfidcode + "', '" + AcID + "', '1');";
                cmd1.ExecuteNonQuery();
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
                cmd.CommandText = "UPDATE Polsband SET Aanwezig = '"+aanwezig+"' WHERE BandID = '" + rfidcode + "'; ";

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
