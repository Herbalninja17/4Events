using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyeCT4Events.GUI
{
    public partial class MessageForm : Form
    {
        private File File;
        private List<Message> messagelist = new List<Message>();

        public MessageForm(File file)
        {
            InitializeComponent();
            File = file; 
            messagelist = Data.DataClasses.DataMessage.GetMessageList(File.FileID);
            if(messagelist.Count != 0)
            {
                foreach(Message m in messagelist)
                {
                    lbMessages.Items.Add(m.Poster.Name + ": " + m.MessageString);
                }
            }
        }
        /// <summary>
        /// Verstuur een bericht.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            Message message = new Message(tbMessage.Text, Login.loggedinUser, DateTime.Now);
            Data.DataClasses.DataMessage.SetMessage(message, message.Poster, File);
            lbMessages.Items.Clear();
            messagelist.Clear();
            messagelist = Data.DataClasses.DataMessage.GetMessageList(File.FileID);
            if (messagelist.Count != 0)
            {
                foreach (Message m in messagelist)
                {
                    lbMessages.Items.Add(m.Poster.Name + ": " + m.MessageString);
                }
            }
            tbMessage.Clear();
        }

        private void MessageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SocialMediaForm smf = new SocialMediaForm();
            smf.Show();
        }
    }
}
