using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Negambo_Express_Cabs
{
    public partial class employee : MetroForm
    {
        public employee()
        {
            InitializeComponent();
        }

        private void employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'negamboDataSet3.tbl_employee' table. You can move, or remove it, as needed.
            this.tbl_employeeTableAdapter.Fill(this.negamboDataSet3.tbl_employee);
            // TODO: This line of code loads data into the 'negamboDataSet2.tbl_employee' table. You can move, or remove it, as needed.


        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void employeedata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void negamboDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnload_Click(object sender, EventArgs e)
        {
            
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
          
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\ARKLIGHT\Desktop\WANTED\Negambo Express Cabs\negambo.mdf; Integrated Security = True; Connect Timeout = 30");
            string query = "insert into  tbl_employee values('" + txtname.Text.ToString() + "','" + txtaddress.Text.ToString() + "','" + txtcon.Text.ToString() + "','" + txtnic.Text.ToString() + "','" + txtndl.Text.ToString() + "','" + txtecon.Text.ToString() + "')";
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                con.Close();
            }
        }

        private void btnupdate_Click_1(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\ARKLIGHT\Desktop\WANTED\Negambo Express Cabs\negambo.mdf; Integrated Security = True; Connect Timeout = 30");
            string query = "update tbl_employee set name='" + txtname.Text.ToString() + "',address='" + txtaddress.Text.ToString() + "',contact_no='" + txtcon.Text.ToString() + "',nic_no='" + txtnic.Text.ToString() + "',ndl_no='" + txtndl.Text.ToString() + "',e_no='" + txtecon.Text.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("record updated!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                con.Close();
            }
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard f = new Dashboard();
            f.Show();

        }

        private void btnload_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\ARKLIGHT\Desktop\WANTED\Negambo Express Cabs\negambo.mdf; Integrated Security = True; Connect Timeout = 30");
            string query = "select * from tbl_employee";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataSet set = new DataSet();
            adapter.Fill(set, "tbl_employee");
            dataGridView1.DataSource = set.Tables["tbl_employee"];
        }
    }
}
