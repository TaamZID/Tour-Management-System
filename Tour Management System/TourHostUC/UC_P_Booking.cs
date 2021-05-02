using DGVPrinterHelper;
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
    public partial class UC_P_Booking : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        //String currentUser = "";

        public UC_P_Booking()
        {
            InitializeComponent();
        }

        /*public string ID
        {
            set { currentUser = value; }
        }*/

        private void UC_P_Booking_Load(object sender, EventArgs e)
        {
            listBoxEvents.Items.Clear();
            query = "select ename from ev where eDate <= getDate()";
            ds = fn.getData(query);

            for(int i = 0; i < ds.Tables[0].Rows.Count;i++)
            {
                listBoxEvents.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            listBoxEvents.Items.Clear();
            query = "select ename from ev where ename like '" + txtSearch.Text + "%'and eDate <=getdate()";
            ds = fn.getData(query);

            for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxEvents.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_P_Booking_Load(this, null);
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTotalPerson.Clear();

            String name = listBoxEvents.GetItemText(listBoxEvents.SelectedItem);

            txtEventName.Text = name;

            query="select eid,eDate,perPerson from ev where ename='"+name+"'";
            ds = fn.getData(query);
            txtEventID.Text = ds.Tables[0].Rows[0][0].ToString();
            txtRegisDate.Text = ds.Tables[0].Rows[0][1].ToString();
            txtCost.Text = ds.Tables[0].Rows[0][2].ToString();
        }

        Int64 totalAmount = 0;
        public void txtTotalPerson_TextChanged(object sender, EventArgs e)
        {
            if (txtTotalPerson.Text != "")
            {
                Int64 unitPrice = Int64.Parse(txtCost.Text);
                Int64 noOfUnit = Int64.Parse(txtTotalPerson.Text);
                totalAmount = unitPrice * noOfUnit;
                //totalAmount = totalAmount + int.Parse(txtAmount.Text);
                txtAmount.Text = totalAmount.ToString();
            }
            else
            {
                txtAmount.Clear();
            }
        }

        protected int n;
        protected Int64 person, cost;

        

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

       

       

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*try
            {
                 = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch { }*/
        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            if (txtEventID.Text != "")
            {
                String name = listBoxEvents.GetItemText(listBoxEvents.SelectedItem);
                txtEventName.Text = name;
                query = "select person from ev where eid='" + txtEventID.Text + "'";
                query = "select eid,person,perPerson from ev where ename='" + name + "'";
                ds = fn.getData(query);

                person = Int64.Parse(ds.Tables[0].Rows[0][1].ToString());
                txtCost.Text = ds.Tables[0].Rows[0][2].ToString();

                if (person > 0)
                {
                    n = guna2DataGridView1.Rows.Add();
                    guna2DataGridView1.Rows[n].Cells[0].Value = txtEventID.Text;
                    guna2DataGridView1.Rows[n].Cells[1].Value = txtEventName.Text;
                    guna2DataGridView1.Rows[n].Cells[2].Value = txtTotalPerson.Text;
                    guna2DataGridView1.Rows[n].Cells[3].Value = txtCost.Text;
                    guna2DataGridView1.Rows[n].Cells[4].Value = txtAmount.Text;



                    //cost = Int64.Parse(txtCost.Text);
                    //person = Int64.Parse(txtTotalPerson.Text);

                    //cost = Int64.Parse(txtCost.Text);
                    //Int64 totalAmount = person * cost;
                    //totalAmount = cost * person + int.Parse(txtAmount.Text);
                    //totalAmounnt = totalAmounnt + int.Parse(txtAmount.Text);
                    //label8.Text = "Taka: " + txtAmount.ToString();
                }
                //clearAll();
                //UC_P_Booking_Load(query, null);
            }
            else
            {
                MessageBox.Show("Select Event First.", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /*private void clearAll()
        {
            txtEventID.Clear();
            txtEventName.Clear();
            txtCost.Clear();
            txtTotalPerson.Clear();
        }*/
        private void txtRemove_Click(object sender, EventArgs e)
        {
            if (EventID != null)
            {
                try
                {
                    guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index);
                }
                catch
                {

                }
                finally
                {
                    query = "select person from ev where eid='" + EventID + "'";
                    ds = fn.getData(query);
                    fn.setData(query, "Event Removed from Cart.");
                }
            }
        }
        private void txtPurchase_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "Event Bill";
            print.SubTitle = String.Format("Date: {0}", DateTime.Now.Date);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumberInHeader = false;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "Total Amount: " + totalAmount;
            print.FooterSpacing = 2;
            print.PrintDataGridView(guna2DataGridView1);
            
            totalAmount = 0;
            guna2DataGridView1.DataSource = 0;
        }
    }
}
