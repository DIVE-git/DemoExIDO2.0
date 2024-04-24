using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DemoExIDO2._0
{
    internal class DBConnect
    {
        string connectString = "server = 195.24.254.116; port = 3306; database = ido; user = IDO; password = IDO";
       // string connectString = "server = 192.168.3.11; port = 3306; database = ido; user = IDO; password = IDO";
        MySqlConnection SqlConnection;

        public DBConnect()
        {
            SetConnection();
        }

        public DBConnect(string connect)
        {
            connectString = connect;
            SetConnection();
        }

        public void SetConnection()
        {
            SqlConnection = new MySqlConnection(connectString);
        }


        public void OpenConnection()
        {
            //Надо закомментить эту строку
            //SetConnection();

            if (SqlConnection.State == System.Data.ConnectionState.Closed)
            {

                try
                {
                    SqlConnection.Open();
                }
                catch
                {
                    MessageBox.Show("Произошла ошибка подключения к базе данных. Проверьте соединение!", "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new Exception();
                }

            }
        }

        public void CloseConnection()
        {
            if (SqlConnection.State == System.Data.ConnectionState.Open) SqlConnection.Close();
        }

        public MySqlConnection GetConnection()
        {
            SetConnection();

            return SqlConnection;
        }
    }
}
