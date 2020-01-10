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

namespace Negambo_Express_Cabs
{
    public partial class Dashboard : MetroForm
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
      
            employee f = new employee();
            f.Show();
            this.Hide();
      
          
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
      
            Records f = new Records();
            f.Show();
            this.Hide();

        }
    }
}
