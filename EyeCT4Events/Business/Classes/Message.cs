using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Events
{
    public class Message
    {
        public string MessageString { get; set; }
        public int MessageID { get; set; }
        public int PreviousMessageID { get; set; }
        public Person Poster { get; set; }

        public Message(string messageString, int messageID, int previousMessageID, Person poster)
        {
            MessageString = messageString;
            MessageID = messageID;
            PreviousMessageID = previousMessageID;
            Poster = poster;
        }
    }
}
