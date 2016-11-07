using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Globalization;

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
                cmd.CommandText = "Select F.Naam as Naam, F.StartDatum as StartDatum, F.EindDatum as EindDatum From ForEvent F, Reservering R, AccountReservering A Where F.EventID = R.EventID And R.ReserveringID = A.ReserveringReserveringID And A.AccountAccountID = '"+ Person.AcID +"' ";
                cmd.ExecuteNonQuery();                  //execute het query
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    rlist.Add(Convert.ToString(reader["Naam"]) + " From: " + Convert.ToString(reader["StartDatum"]) + " To: " + Convert.ToString(reader["EindDatum"]));
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

        public static List<Reservation> GetReservationList()
        {
            List<Reservation> reservations = new List<Reservation>();
            Datacom.OpenConnection();

            SqlCommand cmd = new SqlCommand("SELECT r.PlaatsID, r.ReserveringID, e.StartDatum, e.Einddatum " +
                                            "FROM Reservering r, ForEvent e " +
                                            "WHERE r.EventID = e.EventID;");

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                CampingSpot spot = DataCampingSpot.GetCampingSpot(reader.GetInt32(0));

                int reservationID = reader.GetInt32(1);

                string sDate = reader.GetString(2);
                string eDate = reader.GetString(3);
                string format = "d-M-yyyy";
                DateTime startDate = DateTime.ParseExact(sDate, format, CultureInfo.InvariantCulture);
                DateTime endDate = DateTime.ParseExact(eDate, format, CultureInfo.InvariantCulture);

                bool isRunning;
                int result1 = DateTime.Compare(startDate, DateTime.Now);
                int result2 = DateTime.Compare(endDate, DateTime.Now);

                if (result1 > 0 && result2 < 0)
                {
                    isRunning = true;
                }
                else
                {
                    isRunning = false;
                }

                Reservation reservation = new Reservation(reservationID, isRunning, spot);

                reservations.Add(reservation);
            }

            reader.Close();
            Datacom.CloseConnection();

            return reservations;
        }
    }
}
