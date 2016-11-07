using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events.Data.DataClasses
{
    public class DataMessage
    {
        public DataMessage()
        {
            
        }

        public static Message GetMessage()
        {
            return null;
        }

        public static void SetMessage(Message msg, Person poster, File file)
        {
            Datacom.OpenConnection();

            //Get the ID of the poster
            SqlCommand cmdPoster = new SqlCommand("SELECT AccountID " +
                                                  "FROM Account " +
                                                  $"WHERE Email = {poster.Email};",
                                                  Datacom.connect);
            SqlDataReader reader = cmdPoster.ExecuteReader();
            reader.Read();
            int posterID = reader.GetInt32(0);
            reader.Close();

            //Arrange the values needed
            int fileId = file.FileID;
            string message = msg.MessageString;
            DateTime date = msg.PostTime;
            string postTime = date.ToString("g");

            //Set the values
            SqlCommand cmd = new SqlCommand("INSERT INTO Response(AccountAccountID, MediaMediaID, Bericht, Datum) " +
                                            $"VALUES ({posterID}, {fileId}, '{message}', '{postTime}');",
                                            Datacom.connect);
            cmd.ExecuteNonQuery();

            Datacom.CloseConnection();
        }

        public static void UpdateMessage()
        {
            
        }

        public static List<Message> GetMessageList()
        {
            return null;
        }
    }
}
