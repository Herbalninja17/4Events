﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events.Data.DataClasses
{
    class DataCampingSpot
    {
        public DataCampingSpot()
        {
            
        }

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
        public static bool CheckCampingSpot(int campingspotid)
        {
            try
            {
                Datacom.OpenConnection();
                SqlCommand cmd = new SqlCommand("select p.* from plaats p inner join reservering r on p.plaatsid = r.PlaatsID inner join forevent e on r.eventid = e.eventid where p.plaatsid = " + campingspotid +  ";", Datacom.connect);
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
    }
}
