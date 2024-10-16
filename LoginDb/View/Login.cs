using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginDb
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserController user = new UserController();
            if ((txtUserName.Text == "") || (txtPassword.Text == ""))
            {
                MessageBox.Show("Data login harus diisi", "Login salah", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string name = txtUserName.Text;
                string pass = txtPassword.Text;

                DataTable table = user.getlist(new MySqlConnector.MySqlCommand
                    ("SELECT * FROM users WHERE username = '" + name + "' AND password = '" + pass + "'"));
                if (table.Rows.Count > 0)
                {
                    Beranda obj = new Beranda();
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username dan password tidak ditemukan", "Login salah", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void lblSignIn_Click(object sender, EventArgs e)
        {
            SignIn Obj = new SignIn();
            Obj.Show();
            this.Hide();
        }
    }
}
