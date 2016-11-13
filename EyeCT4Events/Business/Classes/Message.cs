using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events
{
    public class Message : IComparable<Message>
    {
        //Fields
        private string messageString;
        private int messageID;
        private int previousMessageID;
        private Person poster;

        //Properties
        /// <summary>
        /// The Actual message.
        /// </summary>
        public string MessageString
        {
            get { return messageString; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    if (value == null) { throw new ArgumentNullException("messageString"); }
                    throw new ArgumentException("messageString");
                }
                messageString = value;
            }
        }

        /// <summary>
        /// Taken from the database.
        /// </summary>
        public int MessageID { get { return messageID; } private set { messageID = value; } }

        /// <summary>
        /// Taken from the database.
        /// </summary>
        public int PreviousMessageID { get { return previousMessageID; } private set { previousMessageID = value; } }

        /// <summary>
        /// Taken from the database. Time the post was send (recorded in the database).
        /// </summary>
        public DateTime PostTime { get; private set; }

        /// <summary>
        /// Person that wrote the message.
        /// </summary>
        public Person Poster
        {
            get { return poster; }
            set
            {
                if (value == null) { throw new ArgumentNullException("poster"); }
                poster = value;
            }
        }

        /// <summary>
        /// Constructor
        /// For taking reactions to previous messages from the database.
        /// </summary>
        /// <param name="messageString">The actual message.</param>
        /// <param name="messageID">ID of the message.</param>
        /// <param name="previousMessageID">ID of the previous message.</param>
        /// <param name="poster">Person who posted the message.</param>
        /// <param name="postTime">Time the message was posted.</param>
        public Message(string messageString, int messageID, int previousMessageID, Person poster, DateTime postTime)
        {
            MessageString = messageString;
            MessageID = messageID;
            PreviousMessageID = previousMessageID;
            Poster = poster;
            PostTime = postTime;
        }

        /// <summary>
        /// Constructor
        /// For taking original messages from the database (not reacting to other messages).
        /// </summary>
        /// <param name="poster">Person that posted the message.</param>
        /// <param name="messageString">The actual message.</param>
        /// <param name="messageID">ID of the message.</param>
        /// <param name="postTime">Time the message was posted.</param>
        public Message(Person poster, string messageString, int messageID, DateTime postTime)
        {
            Poster = poster;
            MessageString = messageString;
            MessageID = messageID;
            PostTime = postTime;
        }

        /// <summary>
        /// Constructor
        /// For creating messages.
        /// </summary>
        /// <param name="messageString">The actual message.</param>
        /// <param name="poster">Person who posted the message.</param>
        public Message(string messageString, Person poster, DateTime postTime)
        {
            MessageString = messageString;
            MessageID = messageID;
            PreviousMessageID = previousMessageID;
            Poster = poster;
            PostTime = postTime;
        }

        /// <summary>
        /// Constructor
        /// For creating reactions to messages.
        /// </summary>
        /// <param name="messageString">The actual message.</param>
        /// <param name="messageString">MessageID of the message that is reacted to.</param>
        /// <param name="poster">Person who posted the message.</param>
        public Message(string messageString, int previousMessageID, Person poster, DateTime postTime)
        {
            MessageString = messageString;
            PreviousMessageID = previousMessageID;
            Poster = poster;
            PostTime = postTime;
        }

        public static List<Message> GetMessageList(int id)
        {
            List<Message> messagelist = Data.DataClasses.DataMessage.GetMessageList(id);
            return messagelist;
        }
        public static int SetPersonAccountIDByName(string personid)
        {
            int id = Data.DataClasses.DataPerson.SetPersonAccountIDByName(personid);
            return id;
        }

        public static void SetMessageWithResponse(Message message, Person poster, File file, int selectedMessage)
        {
            Data.DataClasses.DataMessage.SetMessageWithResponse(message,poster,file,selectedMessage);
        }

        public static void SetMessage(Message message, Person poster, File file)
        {
            Data.DataClasses.DataMessage.SetMessage(message, poster, file);
        }

        //methods
        public override string ToString()
        {
            return Poster.Email
                + " | " + MessageID
                + " | " + previousMessageID
                + " | " + MessageString
                + " | " + PostTime
                ;
        }

        public int CompareTo(Message other)
        {
            throw new NotImplementedException();
        }
    }
}
