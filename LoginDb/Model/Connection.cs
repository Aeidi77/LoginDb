using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginDb.Model
{
    internal class Connection
    {
        public MySqlCommand cmd;
        public MySqlDataAdapter da;
        public DataSet ds;
        public MySqlConnection Conn;


        public MySqlConnection GetConn()
        {
            Conn = new MySqlConnection();
            Conn.ConnectionString = "server=localhost;user=root;database=warung_ai";
            try
            {
                Conn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("koneksi gagal" + ex.Message);
            }
            return Conn;
        }
    }
}
