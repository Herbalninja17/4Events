using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Globalization;

namespace EyeCT4Events.Data.DataClasses
{
    class DataEvent
    {

        static public List<string> events = new List<string>();

        public DataEvent()
        {
            
        }        

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
            Datacom.OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT e.Naam, e.StartDatum, e.EindDatum, e.CampingID, c.Naam, c.Adres, c.Stad, c.PostCode " +
                                            "FROM ForEvent e, Camping c " +
                                            "WHERE e.CampingID = c.CampingID " +
                                            $"AND e.Naam LIKE '%{name}%';",
                                            Datacom.connect);

            List<Event> events = new List<Event>();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //Get Values Event
                string eventName = reader.GetString(0);
                string startDate = reader.GetString(1);
                string endDate = reader.GetString(2);

                //Get Values Camping
                int campingID = reader.GetInt32(3);
                string campingName = reader.GetString(4);
                string address = reader.GetString(5);
                string city = reader.GetString(6);
                string zipCode = reader.GetString(7);

                //Create Camping
                Camping camping = new Camping(campingID, campingName, address, city, zipCode);

                //Format the date
                string format = "d-M-yyyy";
                DateTime sd = DateTime.ParseExact(startDate, format, CultureInfo.InvariantCulture);
                DateTime ed = DateTime.ParseExact(endDate, format, CultureInfo.InvariantCulture);

                //Create the Event
                Event eEvent = new Event(eventName, sd, ed, camping);

                //Add Event to list
                events.Add(eEvent);

            }
            reader.Close();
            Datacom.CloseConnection();

            return events;
        }

        public static void UpdateEvent(Event eEvent)
        {
            try
            {
                Datacom.OpenConnection();
                SqlCommand cmd = new SqlCommand("UPDATE ForEvent " +
                                               $"SET Naam = {eEvent.Name} " +
                                               $"SET StartDatum = {eEvent.StartDate.ToString("d-M-yyyy")} " +
                                               $"SET EindDatum = {eEvent.EndDate.ToString("d-M-yyyy")} " +
                                               $"WHERE CampingID = {eEvent.Camping}");

                cmd.ExecuteNonQuery();
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
            Datacom.OpenConnection();
            SqlCommand cmd =
                new SqlCommand(
                    "SELECT e.Naam, e.StartDatum, e.EindDatum, e.CampingID, c.Naam, c.Adres, c.Stad, c.PostCode " +
                    "FROM ForEvent e, Camping c " +
                    "WHERE e.CampingID = c.CampingID;",
                    Datacom.connect);

            List<Event> events = new List<Event>();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //Get Values Event
                string eventName = reader.GetString(0);
                string startDate = reader.GetString(1);
                string endDate = reader.GetString(2);

                //Get Values Camping
                int campingID = reader.GetInt32(3);
                string campingName = reader.GetString(4);
                string address = reader.GetString(5);
                string city = reader.GetString(6);
                string zipCode = reader.GetString(7);

                //Create Camping
                Camping camping = new Camping(campingID, campingName, address, city, zipCode);

                //Format the date
                string format = "d-M-yyyy";
                DateTime sd = DateTime.ParseExact(startDate, format, CultureInfo.InvariantCulture);
                DateTime ed = DateTime.ParseExact(endDate, format, CultureInfo.InvariantCulture);

                //Create the Event
                Event eEvent = new Event(eventName, sd, ed, camping);

                //Add Event to list
                events.Add(eEvent);
            }

            return events;
        }

        public static int GetCurrentVisitors()
        {
            return 0;
        }
    }
}
