using System;
using System.Collections;
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
            messagelist = Message.GetMessageList(File.FileID);
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
            if (lbMessages.SelectedItem != null)
            {
                Message message = new Message(tbMessage.Text, Login.loggedinUser, DateTime.Now);
                string selectedmessage = Convert.ToString(lbMessages.SelectedItem);
                string selectedperson = selectedmessage.Substring(0, selectedmessage.IndexOf(":"));
                
                int selectedMessage = Message.SetPersonAccountIDByName(selectedperson);

                Message.SetMessageWithResponse(message, message.Poster, File, selectedMessage);
                FillListBox();
                tbMessage.Clear();
            }
            else
            {
                Message message = new Message(tbMessage.Text, Login.loggedinUser, DateTime.Now);
                Message.SetMessage(message, message.Poster, File);
                FillListBox();
                tbMessage.Clear();
            }
        }

        private void FillListBox()
        {
            lbMessages.Items.Clear();
            messagelist.Clear();

            messagelist = Message.GetMessageList(File.FileID);

            if (messagelist.Count != 0)
            {
                foreach (Message m in messagelist)
                {
                    lbMessages.Items.Add(m.Poster.Name + ": " + m.MessageString);
                }
            }
        }
    }
}
