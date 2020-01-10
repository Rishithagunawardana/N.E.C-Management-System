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
    public partial class login : MetroForm
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            metroProgressBar1.Value = metroProgressBar1.Value + 2;
            if (metroProgressBar1.Value>99)
            {
                Dashboard f = new Dashboard();
                f.Show();
                this.Hide();
                timer1.Enabled = false;

            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\ARKLIGHT\Desktop\WANTED\Negambo Express Cabs\negambo.mdf; Integrated Security = True; Connect Timeout = 30");
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) FROM login  where  username='" + txtuser.Text + "'and  password='" + txtpsw.Text + "'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                timer1.Enabled = true;
                Dashboard ds = new Dashboard();
                ds.Show();


            }
            else
            {
                MessageBox.Show(" please check your usernme and password");
            }

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();


        }
    }
}
