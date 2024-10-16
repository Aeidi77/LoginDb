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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UserController user = new UserController();
            try
            {
                user.tambahUser(txtId.Text, txtUser.Text, txtPass.Text);
                MessageBox.Show("New User Add", "Add User",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtId.Focus();
                Login Obj = new Login();
                Obj.Show();
                this.Hide();
;            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"eror",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
    }
}
