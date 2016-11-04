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
            return null;
        }

        public static void SetReservation(int rID, int pID, string sDatum, string eDatum)
        {
            try
            {                
                Datacom.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Datacom.connect;
                cmd.CommandText = "INSERT INTO Reservering(ReserveringID, PlaatsID, StartDatum, EindDatum) VALUES ('" + rID + "', '" + pID + "', '" + sDatum + "', '" + eDatum + "' );";
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
