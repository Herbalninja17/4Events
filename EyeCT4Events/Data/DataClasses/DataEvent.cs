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

        public static Event GetEvent()
        {
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
