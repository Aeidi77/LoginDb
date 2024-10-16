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
    public partial class Beranda : Form
    {
        public Beranda()
        {
            InitializeComponent();
        }
        private void btnTotal_Click(object sender, EventArgs e)
        {

            try
            {
                int pilih = Convert.ToInt32(txtPilih.Text);
                int banyak = Convert.ToInt32(txtBanyak.Text);
                int total = 0; 

                if (pilih == 1 || pilih == 3 || pilih == 4)
                {
                    total = banyak * 12000;
                }
                else if (pilih == 2)
                {
                    total = banyak * 18000;
                }
                else if (pilih == 6 || pilih == 8)
                {
                    total = banyak * 8000;
                }
                else if (pilih == 5) 
                { 
                    total = banyak * 5000;
                }
                else if (pilih == 7)
                {
                    total = banyak * 10000;
                }
                else
                {
                    MessageBox.Show("Pilihan tidak ada");
                    return; 
                }

                txtTotal.Text = total.ToString();
                MessageBox.Show("Terimakasih");
            }
            catch (FormatException)
            {
               
                MessageBox.Show("Inputan tidak valid. Harap masukkan angka.");
            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            txtBanyak.Text = "";
            txtPilih.Text = "";
            txtTotal.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
    }
}
