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
                string startDatum = startdatum.ToShortDateString();
                DateTime einddatum = eEvent.EndDate;
                string eindDatum = einddatum.ToShortDateString();

                Datacom.OpenConnection();
                Datacom.command = new SqlCommand("INSERT INTO forevent(Naam,startdatum,einddatum) values ('" + eEvent.Name + "', '" + startDatum + "', '" + eindDatum + "';)");
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
