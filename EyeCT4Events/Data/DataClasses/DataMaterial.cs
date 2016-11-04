using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            SqlCommand cmd = new SqlCommand($"SELECT Naam, PrijsPerDag " +
                                            $"FROM Product " +
                                            $"WHERE ProductID = {materialID}",
                                            Datacom.connect);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string name = reader.GetString(0);
            decimal price = reader.GetDecimal(1);
            reader.Close();
            Datacom.CloseConnection();

            Material m = new Material(name, price, false);
            return m;
        }

        public static List<String> AvailableMaterialList()
        {
            Datacom.OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT Omschrijving, Naam, PrijsPerDag" +
                                            "FROM Product" +
                                            "WHERE PStatus = Beschikbaar");
            SqlDataReader reader = cmd.ExecuteReader();
            List<string> producten = new List<string>();
            while (reader.Read())
            {
                string omschrijving = reader.GetString(0);
                string naam = reader.GetString(1);
                decimal prijs = reader.GetDecimal(2);

                string product = $"{naam} - {omschrijving} - {prijs}";

                producten.Add(product);
            }
            reader.Close();
            Datacom.CloseConnection();

            return producten;
        }

        public static Material SetMaterialHired()
        {
            return null;
        }

        public static void UpdateMaterial()
        {
            
        }
    }
}
