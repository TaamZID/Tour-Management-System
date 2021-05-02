using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tour_Management_System
{
#pragma warning disable IDE1006 // Naming Styles
    class function
#pragma warning restore IDE1006 // Naming Styles
    {
#pragma warning disable IDE1006 // Naming Styles
        protected SqlConnection getConnection()
#pragma warning restore IDE1006 // Naming Styles
        {
#pragma warning disable IDE0017 // Simplify object initialization
            SqlConnection con = new SqlConnection();
#pragma warning restore IDE0017 // Simplify object initialization
            con.ConnectionString = "data source = DESKTOP-U1M0RMC;database=tour;integrated security =True";
            return con;
        }

        public DataSet getData(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void setData(String query,String msg)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(msg,"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
