using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tour_Management_System.AdministratorUC
{
    public partial class UC_Dashboard : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;


        public UC_Dashboard()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_Dashboard_Load(this, null);
        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            query = "select count(userRole) from users where userRole = 'Administrator'";
            ds = fn.getData(query);
            setLabel(ds, AdminLabel);

            query = "select count(userRole) from users where userRole = 'Tour Host'";
            ds = fn.getData(query);
            setLabel(ds, HostLabel);

            query = "SELECT SUM(person) FROM ev";
            ds = fn.getData(query);
            setLabel(ds, label7);
        }

        private void setLabel(DataSet ds, Label lbl)
        {
            if (ds.Tables[0].Rows.Count != 0)
            {
                lbl.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                lbl.Text = "0";
            }
        }
    }
}
