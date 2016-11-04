using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EyeCT4Events.Data.DataClasses
{
    class DataEvent
    {
        public DataEvent()
        {
            
        }

        static public List<string> events = new List<string>();

        public static Event GetEvent()
        {
            
            try
            {
                Datacom.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Datacom.connect;
                cmd.CommandText = "Select EventID, Naam, StartDatum, EindDatum From ForEvent";
                cmd.ExecuteNonQuery();                  //execute het query
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    events.Add(Convert.ToString(reader["EventID"]) + ")" + Convert.ToString(reader["Naam"]) + " From: " + Convert.ToString(reader["StartDatum"]) + " To: " + Convert.ToString(reader["EindDatum"]));                    
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

        public static void SetEvent(Event eEvent)
        {
            try
            {
                //begin datum en eind datum naar string.
                DateTime startdatum = eEvent.StartDate;
                string startDatum = startdatum.ToString("d/M/yyyy");
                DateTime einddatum = eEvent.EndDate;
                string eindDatum = einddatum.ToString("d/M/yyyy");
                int ID = eEvent.Camping.ID;

                Datacom.OpenConnection();
                SqlCommand cmd;
                cmd = new SqlCommand("INSERT INTO forevent(CampingID,Naam,startdatum,einddatum) values ('" + ID + "','" + eEvent.Name + "', '" + startDatum + "', '" + eindDatum + "');", Datacom.connect);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Datacom.CloseConnection();
            }
        }

        public static List<Event> SearchEvents(string name)
        {
            //Datacom.OpenConnection();
            //SqlCommand cmd = new SqlCommand("SELECT " +
            //               "FROM ForEvent " +
            //               $"WHERE Naam LIKE '%{name}%';",
            //               Datacom.connect);

            //List<int> products = new List<int>();
            //SqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    products.Add(reader.GetInt32(0));
            //}
            //reader.Close();
            //Datacom.CloseConnection();

            return null;
        }

        public static void UpdateEvent(Event eEvent)
        {
            try
            {
                Datacom.OpenConnection();
                Datacom.command = new SqlCommand("");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Datacom.CloseConnection();
            }
        }

        public static List<Event> GetEventList()
        {
            return null;
        }

        public static int GetCurrentVisitors()
        {
            return 0;
        }
    }
}
