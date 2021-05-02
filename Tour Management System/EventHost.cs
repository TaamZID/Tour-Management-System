using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tour_Management_System
{
    public partial class EventHost : Form
    {
        public EventHost()
        {
            InitializeComponent();
        }

        private void EventHost_Load(object sender, EventArgs e)
        {
            uC_P_Dashboard1.Visible = false;
            uC_P_AddEvent1.Visible = false;
            uC_P_ViewEvent1.Visible = false;
            uC_P_UpdateEvent1.Visible = false;
            uC_P_Booking1.Visible = false;
            btnDashboard.PerformClick();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            uC_P_Dashboard1.Visible = true;
            uC_P_Dashboard1.BringToFront();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            uC_P_AddEvent1.Visible = true;
            uC_P_AddEvent1.BringToFront();
        }

        private void btnViewEvent_Click(object sender, EventArgs e)
        {
            uC_P_ViewEvent1.Visible = true;
            uC_P_ViewEvent1.BringToFront();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            uC_P_UpdateEvent1.Visible = true;
            uC_P_UpdateEvent1.BringToFront();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            uC_P_Booking1.Visible = true;
            uC_P_Booking1.BringToFront();
        }
    }
}
