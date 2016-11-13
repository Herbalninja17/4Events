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
        private int fileID;
        private List<Message> messagelist = new List<Message>();

        public MessageForm(int fileid)
        {
            InitializeComponent();
            fileID = fileid;
            messagelist = Data.DataClasses.DataMessage.GetMessageList(fileID);
            if(messagelist.Count != 0)
            {
                foreach(Message m in messagelist)
                {
                    lbMessages.Items.Add(m.Poster.Name + ": " + m.MessageString);
                }
            }
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {

        }

        private void MessageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SocialMediaForm smf = new SocialMediaForm();
            smf.Show();
        }
    }
}
