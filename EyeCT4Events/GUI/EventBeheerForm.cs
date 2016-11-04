using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeCT4Events.GUI;

namespace EyeCT4Events
{
    public partial class EventBeheerForm : Form
    {
        private EventBeheerForm eventForm;
        private HomeForm homeForm;
        

        public EventBeheerForm()
        {
            InitializeComponent();
            eventForm = this;
        }

        public EventBeheerForm(HomeForm homeForm)
        {
            InitializeComponent();
            eventForm = this;
            this.homeForm = homeForm;
        }

        /// <summary>
        /// Om naar de form te gaan om een event aan te maken.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            CreateEventForm cef = new CreateEventForm(eventForm);
            this.Hide();
            cef.Show();
        }

        /// <summary>
        /// Om naar de form te gaan om een event te wijzigen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditEvent_Click(object sender, EventArgs e)
        {
            EditEventForm eef = new EditEventForm(eventForm);
            this.Hide();
            eef.Show();
        }

        private void EventBeheerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            homeForm.Show();
        }
    }
}
