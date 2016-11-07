using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EyeCT4Events.Data.DataClasses
{
    class DataReservation
    {
        static public List<string> rlist = new List<string>();

        public DataReservation()
        {
            
        }    

        public static Reservation GetReservation()
        {
            try
            {
                Datacom.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Datacom.connect;
                cmd.CommandText = "Select F.Naam, F.StartDatum, F.EindDatum From ForEvent F, Reservering R, AccountReservering A Where F.EventID = R.EventID And R.ReserveringID = A.ReserveringReserveringID And A.AccountAccountID = '"+ Person.AcID +"' ";
                cmd.ExecuteNonQuery();                  //execute het query
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    rlist.Add(Convert.ToString(reader["EventID"]) + ")" + Convert.ToString(reader["Naam"]) + " From: " + Convert.ToString(reader["StartDatum"]) + " To: " + Convert.ToString(reader["EindDatum"]));
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
            return null;
        }

        public static bool SetReservation(int plaatsID, string betaaldStatus, string startDatum, string eindDatum, string eventID)
        {
            try
            {                
                Datacom.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Datacom.connect;
                cmd.CommandText = "INSERT INTO Reservering(PlaatsID, BetaaldStatus, StartDatum, EindDatum, EventID) VALUES ('" + plaatsID 
                    + "','" + betaaldStatus + "', '" + startDatum + "', '" + eindDatum + "', '" + Convert.ToUInt32(eventID) + "' );";
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

            try
            {
                int Rid = 0;
                try
                {
                    Datacom.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Datacom.connect;
                    cmd.CommandText = "SELECT MAX(ReserveringID) as ReserveringID  FROM Reservering;";
                    cmd.ExecuteNonQuery();                  //execute het query
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Rid = Convert.ToInt32(reader["ReserveringID"]);
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
                cmd1.CommandText = "INSERT INTO AccountReservering(ReserveringReserveringID, AccountAccountID) VALUES ('" + Rid + "', '" + Person.AcID + "');";
                cmd1.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            finally
            {
                Datacom.CloseConnection();
            }

            

        }

        public static void UpdateReservation()
        {
            
        }

        public static List<Reservation> GetReservationList()
        {
            return null;
        }
    }
}
