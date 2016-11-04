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

            Material m = new Material(name, price, false);
            return m;
        }

        public static void UpdateMaterial()
        {
            
        }
    }
}
