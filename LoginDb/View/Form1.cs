using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace LoginDb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
                
        }
        int starP = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            starP += 1;
            MyProgres.Value = starP;
            persen.Text = starP + "%";
            if (MyProgres.Value == 100)
            {
                MyProgres.Value = 0;
                Login Obj = new Login();
                Obj.Show();
               
                this.Hide();
                
                timer1.Stop();

            }
        }
    }
}
