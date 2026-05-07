using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Proyecto1.Modelos
{
    public class ConnectionBD
    {
        public MySqlConnection connManager;
        string server = "127.0.0.1";
        string database = "pr1 ex";
        string user = "root";
        string pass = "root";

        public MySqlConnection DataSource()
        {
            connManager = new MySqlConnection($"server={server};database={database};Uid={user};password={pass};");
            return connManager;
        }

        public void ConnectOpened()
        {
            DataSource();
            connManager.Open();
        }
        public void ConnectClosed()
        {
            //DataSource();
            connManager.Close();
        }

        public bool ExecuteQuery(string sql)
        {
            bool result = false;
            try
            {
                ConnectOpened();
                MySqlCommand cmd = new MySqlCommand(sql, connManager);
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (Exception w)
            {
                Console.WriteLine("ERROOOOOOR " + w.Message);
                MessageBox.Show("Error: " + w.Message);
            }
            finally
            {
                ConnectClosed();
            }
            return result;
        }
        public DataTable ExecuteQuerySelect(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                ConnectOpened();
                MySqlCommand cmd = new MySqlCommand(sql, connManager);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception w)
            {
                Console.WriteLine("ERROOOOOOR " + w.Message);
                MessageBox.Show("Error: " + w.Message);
            }
            finally
            {
                ConnectClosed();
            }
            return dt;
        }
    }
}
