using DemoExIDO2._0;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DemoExIDO2
{
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
        }

        private void Save(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(familia.Text) || string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(otchestvo.Text))
            {
                MessageBox.Show("Введите ФИО", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(password.Text))
            {
                MessageBox.Show("Заполнены не все поля", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else if (password.Text != passConfirm.Text)
            {
                MessageBox.Show("Пароли не совпадают", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DBConnect dbConnect = new DBConnect();

            MySqlConnection conn = dbConnect.GetConnection();
            string status = "Работает";

            if (checkBox1.Checked) status = "Уволен";
            string insquery = $"INSERT INTO users(role, lastname,name,parent,login,password,status) VALUES('{comboBox1.Text}','{familia.Text}','{name.Text}','{otchestvo.Text}','{email.Text}','{password.Text}','{status}')";
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

        private void MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.FromArgb(159, 85, 159);
        }

        private void MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(188, 158, 188);
        }

        private void ehandled(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
