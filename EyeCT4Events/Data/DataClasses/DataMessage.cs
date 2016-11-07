﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
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

        public static List<Message> GetMessageList(int fileID)
        {
            List<Message> messages = new List<Message>();

            Datacom.OpenConnection();

            SqlCommand cmd = new SqlCommand("SELECT a.Naam, a.Email, r.Bericht, r.ResponseID, r.Datum " +
                                            "FROM Response r, Account a " +
                                            "WHERE r.AccountAccountID = a.AccountID " +
                                           $"AND r.MediaMediaID = {fileID};",
                                            Datacom.connect);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                //Start with creating the poster
                string name = reader.GetString(0);
                string email = reader.GetString(1);

                Person p = new Person(name, email);

                //Get the values for the message
                string messageString = reader.GetString(2);
                int id = reader.GetInt32(3);
                string date = reader.GetString(4);
                DateTime postTime = DateTime.ParseExact(date, "g", CultureInfo.InvariantCulture);

                //Set the message
                Message message = new Message(p, messageString, id, postTime);

                messages.Add(message);
            }

            return messages;
        }
    }
}
