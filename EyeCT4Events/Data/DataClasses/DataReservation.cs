using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Globalization;

namespace EyeCT4Events.Data.DataClasses
{
    public static class DataReservation
    {
        static public List<string> rlist = new List<string>();

        /// <summary>
        /// Gets a list of all reservations in the database.
        /// </summary>
        public static void GetReservation()
        {
            rlist.Clear();
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
                    rlist.Add(Convert.ToString(reader["Naam"]) + " Van: " + Convert.ToString(reader["StartDatum"]) + " Tot: " + Convert.ToString(reader["EindDatum"]));
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
        }

        public static string GetSaldoBand()
        {
            string saldo = "";

            try
            {
                Datacom.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Datacom.connect;
                cmd.CommandText = "select Saldo from Polsband where AccountAccountID = '"+ Person.AcID +"'";
                cmd.ExecuteNonQuery();                  //execute het query
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    saldo = Convert.ToString(reader["Saldo"]);
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
            return saldo;
        }

        public static string GetSaldo()
        {
            string saldo = "";
           
            try
            {
                Datacom.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Datacom.connect;
                cmd.CommandText = "select SUM(p.Prijs) as prijs from PType p, AccountReservering a, Reservering r where p.TypeID = r.PlaatsID and r.ReserveringID = a.ReserveringReserveringID and a.AccountAccountID = '"+ Person.AcID +"' and r.BetaaldStatus = 'Niet betaald'";
                cmd.ExecuteNonQuery();                  //execute het query
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    saldo = Convert.ToString(reader["prijs"]);
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
            return saldo;
        }

        /// <summary>
        /// Inserts a reservation into the database
        /// </summary>
        /// <param name="plaatsID">Plaats ID</param>
        /// <param name="betaaldStatus">Payment Status</param>
        /// <param name="startDatum">Start Date</param>
        /// <param name="eindDatum">End Date</param>
        /// <param name="eventID">Event ID</param>
        /// <returns>bool (true for succes)</returns>
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

        /// <summary>
        /// Gets a list of reservations
        /// </summary>
        /// <returns>List of reservations</returns>
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

        /// <summary>
        /// Gets a list wich contains the reservations of the logged in person
        /// </summary>
        /// <param name="loggedinP">Person</param>
        /// <returns>List of reservations</returns>
        public static List<string> GetReservationsLoggedInPerson(Person loggedinP)
        {
            List<string> list = new List<string>();
            try
            {
                Datacom.OpenConnection();
                SqlCommand cmd = new SqlCommand("SELECT distinct r.reserveringid, r.betaaldstatus, pt.prijs from reservering r inner join plaats p on r.plaatsid = p.plaatsid inner join ptype pt on p.typeid = pt.TypeID inner join AccountReservering ar on r.ReserveringID = ar.ReserveringReserveringID inner join account a on ar.AccountAccountID = a.AccountID where a.email = '" + loggedinP.Email + "' and r.BetaaldStatus = 'Niet betaald' ;", Datacom.connect);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add("Reservering: " + Convert.ToString(reader["reserveringid"]) + " Betaaldstatus: " + Convert.ToString(reader["betaaldstatus"]) + " Prijs: " + Convert.ToString(reader["prijs"]));
                }
                return list;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return list;
            }
            finally
            {
                Datacom.CloseConnection();
            }
        }
    }
}
