using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidgets;
using Phidgets.Events;

namespace EyeCT4Events.GUI
{
    public partial class RfidForm : Form
    {
        public RfidForm()
        {
            InitializeComponent();
        }

        RFID rfid;
        public bool connected = false;
        public string tagstring = "NULL";

        private void RFIDclass_Load(object sender, EventArgs e)
        {         
            rfid = new RFID();
            openCmdLine(rfid);
            rfid.Tag += new TagEventHandler(rfid_Tag);
            rfid.Attach += new AttachEventHandler(rfid_Attach);
            rfid.TagLost += new TagEventHandler(rfid_TagLost);
            rfid.Detach += new DetachEventHandler(rfid_Detach);            
        }

        void rfid_Tag(object sender, TagEventArgs e)
        {
            label1.Text = e.Tag;
            tagstring = e.Tag;
            connected = true;
        }
        void rfid_TagLost(object sender, TagEventArgs e)
        {
            label1.Text = "NULL";
            tagstring = "NULL";
            connected = false;
        }

        void rfid_Attach(object sender, AttachEventArgs e)
        {
            RFID attached = (RFID)sender;
        }

        void rfid_Detach(object sender, DetachEventArgs e)
        {
            RFID detached = (RFID)sender;
        }

        private void openCmdLine(Phidget p)
        {
            openCmdLine(p, null);
        }

        private void openCmdLine(Phidget p, String pass)
        {
            int serial = -1;
            String logFile = null;
            int port = 5001;
            String host = null;
            bool remote = false, remoteIP = false;
            string[] args = Environment.GetCommandLineArgs();
            String appName = args[0];

            try
            { //Parse the flags
                for (int i = 1; i < args.Length; i++)
                {
                    if (args[i].StartsWith("-"))
                        switch (args[i].Remove(0, 1).ToLower())
                        {
                            case "l":
                                logFile = (args[++i]);
                                break;
                            case "n":
                                serial = int.Parse(args[++i]);
                                break;
                            case "r":
                                remote = true;
                                break;
                            case "s":
                                remote = true;
                                host = args[++i];
                                break;
                            case "p":
                                pass = args[++i];
                                break;
                            case "i":
                                remoteIP = true;
                                host = args[++i];
                                if (host.Contains(":"))
                                {
                                    port = int.Parse(host.Split(':')[1]);
                                    host = host.Split(':')[0];
                                }
                                break;
                            default:
                                goto usage;
                        }
                    else
                        goto usage;
                }
                if (logFile != null)
                    Phidget.enableLogging(Phidget.LogLevel.PHIDGET_LOG_INFO, logFile);
                if (remoteIP)
                    p.open(serial, host, port, pass);
                else if (remote)
                    p.open(serial, host, pass);
                else
                    p.open(serial);
                return; //success
            }
            catch { }
            usage:
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Invalid Command line arguments." + Environment.NewLine);
            sb.AppendLine("Usage: " + appName + " [Flags...]");
            sb.AppendLine("Flags:\t-n   serialNumber\tSerial Number, omit for any serial");
            sb.AppendLine("\t-l   logFile\tEnable phidget21 logging to logFile.");
            sb.AppendLine("\t-r\t\tOpen remotely");
            sb.AppendLine("\t-s   serverID\tServer ID, omit for any server");
            sb.AppendLine("\t-i   ipAddress:port\tIp Address and Port. Port is optional, defaults to 5001");
            sb.AppendLine("\t-p   password\tPassword, omit for no password" + Environment.NewLine);
            sb.AppendLine("Examples: ");
            sb.AppendLine(appName + " -n 50098");
            sb.AppendLine(appName + " -r");
            sb.AppendLine(appName + " -s myphidgetserver");
            sb.AppendLine(appName + " -n 45670 -i 127.0.0.1:5001 -p paswrd");
            MessageBox.Show(sb.ToString(), "Argument Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
             
        }

        private void antennaChk_CheckedChanged(object sender, EventArgs e)
        {
            rfid.Antenna = antennaChk.Checked;
        }

        private void ledChk_CheckedChanged(object sender, EventArgs e)
        {
            rfid.LED = ledChk.Checked;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tagstring != "NULL")
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
