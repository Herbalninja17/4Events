using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events.Data.DataClasses
{
    public static class DataCampingSpot
    {
        /// <summary>
        /// Gets a campingspot from the database with a certain spotID.
        /// </summary>
        /// <param name="spotID">Spot ID</param>
        /// <returns></returns>
        public static CampingSpot GetCampingSpot(int spotID)
        {
            Datacom.OpenConnection();

            SqlCommand cmd = new SqlCommand("SELECT t.Naam, p.PlaatsID, p.Plaatsnummer, t.Capaciteit, p.Status, t.Prijs " +
                                            "FROM Plaats p, PType t " +
                                            "WHERE p.TypeID = t.TypeID " +
                                           $"AND PlaatsID = {spotID};",
                                            Datacom.connect);

            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string name = reader.GetString(0);
            int place = reader.GetInt32(1);
            int placenr = reader.GetInt32(2);
            int capacity = reader.GetInt32(3);
            string statusString = reader.GetString(4);
            decimal price = reader.GetDecimal(5);

            SpotType type = (SpotType)Enum.Parse(typeof(SpotType), name);
            bool status;
            if (statusString == "Beschikbaar")
            {
                status = false;
            }
            else
            {
                status = true;
            }

            CampingSpot spot = new CampingSpot(type, place, placenr, capacity, status, price);

            Datacom.CloseConnection();

            return spot;
        }

        /// <summary>
        /// Sets a camping spot to occupied (Verhuurd) with a certain spot ID
        /// </summary>
        /// <param name="spotID">Spot ID</param>
        public static void ReserveCampingSpot(int spotID)
        {
            Datacom.OpenConnection();

            SqlCommand cmd = new SqlCommand("UPDATE Plaats " +
                                            "SET Status = 'Verhuurd' " +
                                            $"WHERE PlaatsID = {spotID};",
                                            Datacom.connect);

            cmd.ExecuteNonQuery();

            Datacom.CloseConnection();
        }

        /// <summary>
        /// Gets the max number of people from a camping spot.
        /// </summary>
        /// <param name="plaatsid">Plaats ID</param>
        /// <returns>Capacity</returns>
        public static int GetCampingSpotCapacity(int plaatsid)
        {
            int capacity = 0;
            try
            {
                Datacom.OpenConnection();
                SqlCommand cmd = new SqlCommand("SELECT pt.capaciteit from ptype pt inner join plaats p on pt.typeid = p.typeid where p.plaatsid = " + plaatsid + ";", Datacom.connect);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    capacity = Convert.ToInt32(reader["capaciteit"]);
                }
                return capacity;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return capacity;
            }
            finally
            {
                Datacom.CloseConnection();
            }
        }

        /// <summary>
        /// Checks of a campingspot is occupied between a certain period of time.
        /// </summary>
        /// <param name="campingspotid">Campingspot ID</param>
        /// <param name="begindate">Start Date</param>
        /// <param name="enddate">End Date</param>
        /// <returns>Occupied status (bool)</returns>
        public static bool CheckCampingSpot(int campingspotid,string begindate,string enddate)
        {
            try
            {
                Datacom.OpenConnection();
                SqlCommand cmd = new SqlCommand("select p.* from plaats p inner join reservering r on p.plaatsid = r.PlaatsID inner join forevent e on r.eventid = e.eventid where p.plaatsid = " + campingspotid + " and (convert(date,'" + begindate + "',105) between convert(date,r.startdatum,105) and convert(date,r.einddatum,105) OR convert(date,'" + enddate + "',105) between convert(date,r.startdatum,105) and convert(date,r.einddatum,105));", Datacom.connect);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                Datacom.CloseConnection();
            }
        }

        /// <summary>
        /// Gets a list of all campingspots from the database of a certain camping
        /// </summary>
        /// <param name="campingID">Camping ID</param>
        /// <returns>List of campingspots</returns>
        public static List<CampingSpot> GetCampingSpotList(int campingID)
        {
            Datacom.OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT t.Naam, p.PlaatsID, p.Plaatsnummer, t.Capaciteit, p.Status, t.Prijs " +
                                            "FROM Plaats p, PType t " +
                                            "WHERE p.TypeID = t.TypeID " +
                                            $"AND CampingID = {campingID};",
                                            Datacom.connect);

            SqlDataReader reader = cmd.ExecuteReader();
            List<CampingSpot> spots = new List<CampingSpot>();
            while (reader.Read())
            {
                //Get Values
                string name = reader.GetString(0);
                int id = reader.GetInt32(1);
                int place = reader.GetInt32(2);
                int capacity = reader.GetInt32(3);
                string statusString = reader.GetString(4);
                decimal price = reader.GetDecimal(5);

                //Convert some Values
                SpotType type = (SpotType) Enum.Parse(typeof(SpotType), name);
                bool status;
                if (statusString == "Beschikbaar")
                {
                    status = false;
                }
                else
                {
                    status = true;
                }

                //Set values
                CampingSpot spot = new CampingSpot(type, id, place, capacity, status, price);

                //Put in list
                spots.Add(spot);
            }
            reader.Close();
            Datacom.CloseConnection();

            return spots;
        }
        public static List<string> GetCampingSpotType()
        {
            List<string> campingtypelist = new List<string>();
            try
            {
                Datacom.OpenConnection();
                SqlCommand cmd = new SqlCommand("select naam from ptype;", Datacom.connect);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    campingtypelist.Add(Convert.ToString(reader["naam"]));
                }
                return campingtypelist;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return campingtypelist;
            }
            finally
            {
                Datacom.CloseConnection();
            }
        }
        public static List<string> GetCampingSpotNumber(string typenaam)
        {
            List<string> campingspotnumber = new List<string>();
            try
            {
                Datacom.OpenConnection();
                SqlCommand cmd = new SqlCommand("SELECT p.plaatsid FROM plaats p INNER JOIN ptype pt on p.typeid = pt.typeid WHERE pt.naam = '" + typenaam + "';", Datacom.connect);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    campingspotnumber.Add(Convert.ToString(reader["plaatsid"]));
                }
                return campingspotnumber;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return campingspotnumber;
            }
            finally
            {
                Datacom.CloseConnection();
            }
        }
    }
}
