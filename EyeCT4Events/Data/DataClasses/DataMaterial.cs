﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyeCT4Events.Data.DataClasses
{
    public static class DataMaterial
    {
        /// <summary>
        /// Gets a certain Product from the database.
        /// </summary>
        /// <param name="materialID">Material ID</param>
        /// <returns>Material</returns>
        public static List<Material> GetMaterial(Person p) 
        {
            List<Material> materiallist = new List<Material>();
            Datacom.OpenConnection();
            SqlCommand cmd = new SqlCommand($"SELECT p.ProductID, p.Naam, p.PrijsPerDag, p.Omschrijving,v.betaalstatus ,p.PStatus " +
                                            $"FROM Product p " +
                                            "inner join verhuur v on p.productid = v.ProductProductID " +
                                            "inner join Polsband pb on v.PolsbandBandID = pb.BandID " +
                                            "inner join account a on a.accountid = pb.AccountAccountID " +
                                            $"WHERE a.email  = '{p.Email}'",
                                            Datacom.connect);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                decimal price = reader.GetDecimal(2);
                string description = reader.GetString(3);
                string PStatus = reader.GetString(5);
                string Bstatus = reader.GetString(4);
                bool betaalstatus;
                bool status;
                if (PStatus == "Beschikbaar")
                {
                    status = false;
                }
                else
                {
                    status = true;
                }
                if(Bstatus == "")
                {
                    betaalstatus = false;
                }
                else
                {
                    betaalstatus = true;
                }

                Datacom.CloseConnection();

                Material m = new Material(id, name, description, price, betaalstatus, status);
            }

            return materiallist;
        }

        /// <summary>
        /// Gets a list of all Products from the database that are availeble (Beschikbaar).
        /// </summary>
        /// <returns>List of Materials</returns>
        public static List<Material> AvailableMaterialList() 
        {
            Datacom.OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT Omschrijving, ProductID, Naam, PrijsPerDag " +
                                            "FROM Product " +
                                            "WHERE PStatus = 'Beschikbaar' " +
                                            "ORDER BY Naam, Omschrijving;",
                                            Datacom.connect);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Material> products = new List<Material>();
            while (reader.Read())
            {
                int id = reader.GetInt32(1);
                string description = reader.GetString(0);
                string name = reader.GetString(2);
                decimal price = reader.GetDecimal(3);

                Material product = new Material(id, name, description, price, false, false);

                products.Add(product);
            }
            reader.Close();
            Datacom.CloseConnection();

            return products;
        }

        /// <summary>
        /// Sets a product to rented (Verhuurd) in the database.
        /// </summary>
        /// <param name="materialID">Material ID</param>
        public static void SetMaterialHired(int materialID) 
        {
            Datacom.OpenConnection();
            SqlCommand cmd = new SqlCommand("UPDATE Product " +
                           "SET PStatus = 'Verhuurd' " +
                           $"WHERE ProductID = {materialID};",
                           Datacom.connect);
            cmd.ExecuteNonQuery();
            Datacom.CloseConnection();
        }

        /// <summary>
        /// Sets a product to availeble (Beschikbaar) in the database
        /// </summary>
        /// <param name="materialID">Material ID</param>
        public static void SetMaterialAvailable(int materialID)
        {
            Datacom.OpenConnection();
            SqlCommand cmd = new SqlCommand("UPDATE Product " +
                                            "SET PStatus = 'Beschikbaar' " +
                                            $"WHERE ProductID = {materialID};",
                           Datacom.connect);
            cmd.ExecuteNonQuery();
            Datacom.CloseConnection();
        }

        /// <summary>
        /// Gets a list of Product ID's containing the input value
        /// </summary>
        /// <param name="name">Name</param>
        /// <returns>List of Product ID's</returns>
        public static List<int> SearchMaterials(string name) 
        {
            Datacom.OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT ProductID " +
                           "FROM Product " +
                           $"WHERE Naam LIKE '%{name}%';",
                           Datacom.connect);

            List<int> products = new List<int>();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                products.Add(reader.GetInt32(0));
            }
            reader.Close();
            Datacom.CloseConnection();

            return products;
        }
    }
}
