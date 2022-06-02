using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


namespace AtelierPro2CNED.Connexion
{
    public class Connect
    {
        private string username;
        private string password;

        public Connect(string user, string pwd) {
            this.username = user;
            this.password = pwd;
        }
        
        public NpgsqlConnection connexion()
        {
            
            try
            {
                string connstring = "Server=localhost;Port=5432;User Id=" + this.username + ";Password=" + this.password + ";Database=atelierprocned;";
                NpgsqlConnection connection = new NpgsqlConnection(connstring);
                return connection;
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.ToString());
                return null;
                throw;
            }
        }
    }
}
