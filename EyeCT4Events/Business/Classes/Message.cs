using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events
{
    public class Message
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
                if(String.IsNullOrWhiteSpace(value))
                {
                    if(value == null) { throw new ArgumentNullException("messageString"); }
                    throw new ArgumentException("messageString");
                }
                messageString = value;
            }
        }

        public int MessageID
        {
            get { return messageID; }
            set
            {
                if(value <= 0) { throw new ArgumentOutOfRangeException("messageID"); }
                messageID = value;
            }
        }

        public int PreviousMessageID
        {
            get { return previousMessageID; }
            set
            {
                //Will equal 0 if there was no previous message.
                if(value < 0) { throw new ArgumentOutOfRangeException("previousMessageID"); }
                previousMessageID = value;
            }
        }

        /// <summary>
        /// Person that wrote the message.
        /// </summary>
        public Person Poster
        {
            get { return poster; }
            set
            {
                if(value == null) { throw new ArgumentNullException("poster"); }
                poster = value;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="messageString">The actual message.</param>
        /// <param name="messageID">ID of the message.</param>
        /// <param name="previousMessageID">ID of the previous message.</param>
        /// <param name="poster">Person who posted the message.</param>
        public Message(string messageString, int messageID, int previousMessageID, Person poster)
        {
            MessageString = messageString;
            MessageID = messageID;
            PreviousMessageID = previousMessageID;
            Poster = poster;
        }

        //methods
        public override string ToString()
        {
            return Poster.Email
                + " | " + MessageID
                + " | " + previousMessageID
                + " | " + MessageString
                ;
        }
    }
}
