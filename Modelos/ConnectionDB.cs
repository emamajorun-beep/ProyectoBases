using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Proyecto1.Modelos
{
    public class ConnectionDB
    {
        public MySqlConnection connManager;
        string server = "127.0.0.1;";
        string database = "recursos;";
        string user = "root;";
        string pass = "root;";

        public MySqlConnection DataSource()
        {
            connManager = new MySqlConnection($"server={server} database={database} Uid={user} password={pass}");
            return connManager;
        }

        public void ConnectOpened()
        {
            //DataSource();
            connManager.Open();
        }
        public void ConnectClosed()
        {
            DataSource();
            connManager.Close();
        }

        public bool ExecuteQuery(string sql)
        {
            bool result = false;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, DataSource());
                ConnectOpened();

                cmd.ExecuteNonQuery();
                result = true;
                //ConnectClosed();
            }
            catch (Exception w)
            {
                Console.WriteLine("ERROOOOOOR " + w.Message);

                ConnectClosed();
            }
            finally
            {
                ConnectClosed();
            }
            return result;
        }
    }
}
