using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tour_Management_System.TourHostUC
{
    public partial class UC_P_AddEvent : UserControl
    {
        function fn = new function();
        String query;

        public UC_P_AddEvent()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(txtEventID.Text!="" && txtEventName.Text!="" && txtEventNumber.Text!="" &&txtRegisDate.Text!="" && txtRegisEnd.Text!="" && txtPerson.Text!="" && txtCost.Text != "")
            {
                String eid = txtEventID.Text;
                String ename = txtEventName.Text;
                String enumber = txtEventNumber.Text;
                //String sdate = txtRegisDate.Text;
                //String edate = txtRegisEnd.Text;

                DateTime sdate = DateTime.Now;
                string eDate = txtRegisDate.Text;
                DateTime edate = DateTime.Now;
                string sDate = txtRegisEnd.Text;


                Int64 person = Int64.Parse(txtPerson.Text);
                Int64 perperson = Int64.Parse(txtCost.Text);

                query = "Insert into ev(eid,ename,enumber,sDate,eDate,person,perPerson) values ('" + eid + "','" + ename + "','" + enumber + "','" + sdate + "','" + edate + "'," + person + "," + perperson + ")";
                fn.setData(query, "Event Created.");
            }
            else
            {
                MessageBox.Show("Enter all data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            txtEventID.Clear();
            txtEventName.Clear();
            txtEventNumber.Clear();
            txtRegisDate.ResetText();
            txtRegisEnd.ResetText();
            txtPerson.Clear();
            txtCost.Clear();
        }
    }
}
