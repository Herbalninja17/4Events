using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyeCT4Events.Data.DataClasses
{
    public class DataMaterial
    {
        public DataMaterial()
        {
            
        }

        public static Material GetMaterial(int materialID)
        {
            Datacom.OpenConnection();
            SqlCommand cmd = new SqlCommand($"SELECT ProductID, Naam, PrijsPerDag " +
                                            $"FROM Product " +
                                            $"WHERE ProductID = {materialID}",
                                            Datacom.connect);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int id = reader.GetInt32(0);
            string name = reader.GetString(1);
            decimal price = reader.GetDecimal(2);
            reader.Close();
            Datacom.CloseConnection();

            Material m = new Material(id, name, "Test", price, false);
            return m;
        }

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

                Material product = new Material(id, name, description, price, false);

                products.Add(product);
            }
            reader.Close();
            Datacom.CloseConnection();

            return products;
        }

        public static void SetMaterialHired(int materialID)
        {
            Datacom.OpenConnection();
            new SqlCommand("ALTER TABLE Product " +
                           "SET PStatus = 'Verhuurd' " +
                           $"WHERE ProductID = {materialID}");
            Datacom.CloseConnection();
        }

        public static List<int> SearchMaterials(string name)
        {
            Datacom.OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT ProductID " +
                           "FROM Product " +
                           $"WHERE Naam LIKE '%{name}%'",
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

        public static void UpdateMaterial()
        {
            
        }
    }
}
