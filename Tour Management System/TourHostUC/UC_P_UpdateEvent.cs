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
    public partial class UC_P_UpdateEvent : UserControl
    {

        function fn = new function();
        String query;

        public UC_P_UpdateEvent()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMedID.Clear();
            txtEventName.Clear();
            txtEventNumber.Clear();
            txtEdate.ResetText();
            txtSdate.ResetText();
            txtPerson.Clear();
            txtPCost.Clear();
        }

        //Int64 
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String eid = txtMedID.Text;
            String ename = txtEventName.Text;
            String enumber = txtEventNumber.Text;
            //String sdate = txtSdate.Text;
            //String edate = txtEdate.Text;
            DateTime sdate = DateTime.Now;
            string eDate = txtSdate.Text;
            DateTime edate = DateTime.Now;
            string sDate = txtEdate.Text;
            //Int64 person = Int64.Parse(txtPerson.Text);
            //Int64 cost = Int64.Parse(txtPCost.Text);


            query = "update ev set eid = '" + eid + "',ename='" + ename + "',enumber='" + enumber + "',sdate='" + sdate + "',edate='" + edate + "' where eid = '" + txtMedID.Text + "'";
            fn.setData(query, "Event Updated Successfully!");
        }

        private void UC_P_UpdateEvent_Load(object sender, EventArgs e)
        {

        }
    }
}
