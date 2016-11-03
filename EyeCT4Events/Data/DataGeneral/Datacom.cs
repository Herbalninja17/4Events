using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EyeCT4Events.Data
{
    public static class Datacom
    {
        public static SqlConnection connect { get; set; }

        public static bool OpenConnection()
        {
            connect = new SqlConnection();

            try
            {
                connect.ConnectionString = "Data Source=mssql.fhict.local; Database=dbi338530; User Id=dbi338530; Password= Qwerty123";
                connect.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            if (connect.State == System.Data.ConnectionState.Open)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void CloseConnection()
        {
            connect.Close();
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////        
        public static string TestMethode(int data)     // zet all uw data in als parameter in volgorde <Rechard>
        {
            string xxx = "";
            try
            {
                OpenConnection();                       // om connection open te maken
                SqlCommand cmd = new SqlCommand();     // voor het command
                cmd.Connection = connect;               // een connection maken met het command

                cmd.CommandText = "Select x From Test Where y = @Data";

                cmd.Parameters.Add(new SqlParameter("Data", data)); //(@string waarde, parameter waarde)
                cmd.ExecuteNonQuery();                  //execute het query

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    xxx = Convert.ToString(reader["x"]);

                }
            }
            catch (Exception e)
            {
                CloseConnection();
                Console.WriteLine(e.Message);
            }
            return xxx;
        } //goodluck! </Rechard>  
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////   
        public static int GetLatestID(string tablename)
        {
            int id = -1;
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand("SELECT MAX(" + tablename + "id) as " + tablename + "id FROM " + tablename + ";", connect);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id = Convert.ToInt32(reader[tablename +"id"]);
                    }
                }
                return id;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return id;
            }
            finally
            {
                
                CloseConnection();
            }
        }   
    }
}
