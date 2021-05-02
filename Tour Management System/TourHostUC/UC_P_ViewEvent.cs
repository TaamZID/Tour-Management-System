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
    public partial class UC_P_ViewEvent : UserControl
    {
        function fn = new function();
        String query;


        public UC_P_ViewEvent()
        {
            InitializeComponent();
        }

        private void UC_P_ViewEvent_Load(object sender, EventArgs e)
        {
            query = "select * from ev";
            setDataGridView(query);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from ev where ename like '"+txtSearch.Text+"%'";
            setDataGridView(query);
        }

        private void setDataGridView(String query)
        {
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        String eventId;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                eventId = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?","Delete Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "delete from ev where eid = '" + eventId + "'";
                fn.setData(query, "Event Record Deleted.");
                UC_P_ViewEvent_Load(this, null);
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_P_ViewEvent_Load(this, null);
        }
    }
}
