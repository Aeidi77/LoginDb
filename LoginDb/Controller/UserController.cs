using LoginDb.Model;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginDb
{
    internal class UserController : Model.Connection
    {

        Connection koneksi = new Connection();
        public DataTable getlist(MySqlCommand cmd)
        {
            cmd.Connection = koneksi.GetConn();
            DataTable dt = new DataTable();

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                //mengambil dan mengisinya ke dataTable
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        /**/

        public void tambahUser(string id, string user, string pass)
        {
            string tambah = " INSERT INTO users VALUES (" + "@id,@username,@password)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@id", MySqlConnector.MySqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@username", MySqlConnector.MySqlDbType.VarChar).Value = user;
                cmd.Parameters.Add("@password", MySqlConnector.MySqlDbType.VarChar).Value = pass;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah Data Gagal " + ex.Message);
            }
        }
    }
}
