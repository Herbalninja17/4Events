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
        public DataReservation()
        {
            
        }

        public static Reservation GetReservation()
        {
            //try
            //{
            //    Datacom.OpenConnection();
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Connection = Datacom.connect;
            //    cmd.CommandText = "Select Naam, StartDatum, EindDatum From ForEvent";
            //    cmd.ExecuteNonQuery();                  //execute het query
            //    SqlDataReader reader = cmd.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        events.Add(Convert.ToString(reader["EventID"]) + ")" + Convert.ToString(reader["Naam"]) + " From: " + Convert.ToString(reader["StartDatum"]) + " To: " + Convert.ToString(reader["EindDatum"]));
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //}
            //finally
            //{
            //    Datacom.CloseConnection();
            //}
            return null;
        }

        public static void SetReservation(int pID, string bet, string sDatum, string eDatum, string x)
        {
            try
            {                
                Datacom.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Datacom.connect;
                cmd.CommandText = "INSERT INTO Reservering(PlaatsID, BetaaldStatus, StartDatum, EindDatum, EventID) VALUES ('" + pID + "','" + bet + "', '" + sDatum + "', '" + eDatum + "', '" + Convert.ToUInt32(x) + "' );";
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

        public static void UpdateReservation()
        {
            
        }

        public static List<Reservation> GetReservationList()
        {
            return null;
        }
    }
}
