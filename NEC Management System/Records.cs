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
    public partial class Records : MetroForm
    {
        public Records()
        {
            InitializeComponent();
        }

        private void Records_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'negamboDataSet4.tbl_Trip' table. You can move, or remove it, as needed.
            this.tbl_TripTableAdapter.Fill(this.negamboDataSet4.tbl_Trip);


        }

        private void metroPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard f = new Dashboard();
            f.Show();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\ARKLIGHT\Desktop\WANTED\Negambo Express Cabs\negambo.mdf; Integrated Security = True; Connect Timeout = 30");
            string query = "insert into  tbl_Trip values('" + txtdate.Text+ "','" + txttime.Text + "','" + txtsmeter.Text + "','" + txtetime.Text + "','" + txtemeter.Text + "','" + txtkm.Text + "','" + txtprice.Text + "','" + txtdes.Text + "','" + txtcname.Text + "','" + txttel.Text + "','" + txtcaddress.Text + "')";
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

        private void btnload_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\ARKLIGHT\Desktop\WANTED\Negambo Express Cabs\negambo.mdf; Integrated Security = True; Connect Timeout = 30");
            string query = "select * from tbl_Trip";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataSet set = new DataSet();
            adapter.Fill(set, "tbl_Trip");
            dataGridView1.DataSource = set.Tables["tbl_Trip"];
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\ARKLIGHT\Desktop\WANTED\Negambo Express Cabs\negambo.mdf; Integrated Security = True; Connect Timeout = 30");
            string query = "update tbl_Trip set Date and time ='" + txtdate.Text+ "',Start time='" + txttime.Text + "',Start Meter='" + txtsmeter.Text + "',End Time'" + txtetime.Text + "',End Meter='" + txtemeter.Text + "',Total Km='" + txtkm.Text + "',Price='" + txtprice.Text + "',Destinationn='" + txtdes.Text + "'Customer Name='" + txtcname.Text + "',Customer Tel No='" + txttel.Text + "',Customer Address='" + txtcaddress.Text + "';";
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

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");

        }
    }
}
