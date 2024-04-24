using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoExIDO2._0.Forms
{
    public partial class ShiftCreate : Form
    {

        public ShiftCreate()
        {
            InitializeComponent();
            Text = $"Создание смены на {System.DateTime.Today.ToShortDateString()}";


            DBConnect dbConnect = new DBConnect();
            try
            {
                dbConnect.OpenConnection();

            }
            catch
            {
                Close();
                return;
            }


            MySqlConnection conn = dbConnect.GetConnection();

            MySqlDataAdapter adapterRole = new MySqlDataAdapter();

            DataTable table = new DataTable();

            string queryStrRole = "SELECT id, role, lastname, name, parent FROM users";
            MySqlCommand command = new MySqlCommand(queryStrRole, conn);
            adapterRole.SelectCommand = command;
            adapterRole.Fill(table);

            table.DefaultView.RowFilter = "role='Повар'";

            for (int i = 0; i < table.DefaultView.Count; i++)
            {
                string fio = $"{table.DefaultView[i].Row[2]} {table.DefaultView[i].Row[3]} {table.DefaultView[i].Row[4]}";
                comboBox1.Items.Add(fio);
            }

            table.DefaultView.RowFilter = "role='Официант'";

            for (int i = 0; i < table.DefaultView.Count; i++)
            {
                string fio = $"{table.DefaultView[i].Row[2]} {table.DefaultView[i].Row[3]} {table.DefaultView[i].Row[4]}";
                comboBox2.Items.Add(fio);
            }

            table.DefaultView.RowFilter = "role='Администратор'";

            for (int i = 0; i < table.DefaultView.Count; i++)
            {
                string fio = $"{table.DefaultView[i].Row[2]} {table.DefaultView[i].Row[3]} {table.DefaultView[i].Row[4]}";
                comboBox3.Items.Add(fio);
            }



            table.DefaultView.RowFilter = "";
            dbConnect.CloseConnection();


            
        }




        private void ehandled(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void confirmBut_Click(object sender, EventArgs e)
        {


            DBConnect dbConnect = new DBConnect();

            try
            {
                dbConnect.OpenConnection();

            }
            catch
            {
                return;
            }

            MySqlConnection conn = dbConnect.GetConnection();

            MySqlDataAdapter adapterRole = new MySqlDataAdapter();

            DataTable table = new DataTable();

            string queryStrRole = $"SELECT id FROM `users` WHERE lastname = '{comboBox1.Text.Split()[0]}'";
            MySqlCommand command = new MySqlCommand(queryStrRole, conn);
            adapterRole.SelectCommand = command;
            adapterRole.Fill(table);

            string id1 = table.Rows[0].ItemArray[0].ToString();


            command = new MySqlCommand($"SELECT id FROM `users` WHERE lastname = '{comboBox2.Text.Split()[0]}'", conn);
            adapterRole.SelectCommand = command;
            adapterRole.Fill(table);

            string id2 = table.Rows[1].ItemArray[0].ToString();


            command = new MySqlCommand($"SELECT id FROM `users` WHERE lastname = '{comboBox3.Text.Split()[0]}'", conn);
            adapterRole.SelectCommand = command;
            adapterRole.Fill(table);

            string id3 = table.Rows[2].ItemArray[0].ToString();

            test(id1, id2, id3);


            dbConnect.CloseConnection();
        }

        private void test(string i1,string i2, string i3)
        {
            DBConnect dbConnect = new DBConnect();

            MySqlConnection conn = dbConnect.GetConnection();

            string insquery = $"INSERT INTO Changes(ID_waiter, ID_cook, ID_admin) VALUES({i1},{i2},{i3})";
            MySqlCommand command = new MySqlCommand(insquery, conn);
            try
            {
                dbConnect.OpenConnection();
                command.ExecuteNonQuery();

            }
            catch
            {
                return;
            }


            dbConnect.CloseConnection();
            Close();
        }
    }
}
