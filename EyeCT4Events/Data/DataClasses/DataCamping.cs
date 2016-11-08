﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events.Data.DataClasses
{
    public static class DataCamping
    {
        /// <summary>
        /// This method could be used for further expansion of the application.
        /// </summary>
        /// <returns></returns>
        public static Camping GetCamping()
        {
            return null;
        }

        /// <summary>
        /// Gets a list of all Campings from the database
        /// </summary>
        /// <returns></returns>
        public static List<Camping> GetCampingList()
        {
            Datacom.OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT CampingID, Naam, Adres, Stad, PostCode " +
                                            "FROM Camping " +
                                            "ORDER BY Naam;",
                                            Datacom.connect);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Camping> campings = new List<Camping>();
            while (reader.Read())
            {
                int ID = reader.GetInt32(0);
                string name = reader.GetString(1);
                string address = reader.GetString(2);
                string city = reader.GetString(3);
                string zipCode = reader.GetString(4);
                Camping camping = new Camping(ID, name, address, city, zipCode);

                campings.Add(camping);
            }
            reader.Close();
            Datacom.CloseConnection();

            return campings;
        }
    }
}
