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
    public partial class UC_P_Dashboard : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        Int64 count;

        public UC_P_Dashboard()
        {
            InitializeComponent();
        }
        
        private void UC_P_Dashboard_Load(object sender, EventArgs e)
        {
            loadChart();
        }
        
        public void loadChart()
        {
            query = "select count(ename) from ev where eDate <= getdate()";
            ds = fn.getData(query);
            count = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            this.chart1.Series["Active Event"].Points.AddXY("Event Chart", count);

            /*
            query = "select count(ename) from ev where eDate <= getdate()";
            ds = fn.getData(query);
            count = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            this.chart1.Series["Past Event"].Points.AddXY("Event Chart", count);
            */
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            chart1.Series["Active Event"].Points.Clear();
            loadChart();
        }
    }
}
