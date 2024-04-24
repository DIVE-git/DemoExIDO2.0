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

namespace DemoExIDO2._0
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }




        #region Закрывающие кнопки


        private void OnClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Подтвердите закрытие приложения", "Выход", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) e.Cancel = true;
        }


        private void MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.FromArgb(159, 85, 159);
        }

        private void MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(188, 158, 188);
        }



        #endregion

        private void EnterBut(object sender, EventArgs e)
        {
            if (userName.Text == "" || password.Text == "")
            {
                MessageBox.Show("Неверные данные авторизации!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string login = userName.Text;
            string pass = password.Text;

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

            DataTable tableRole = new DataTable();

            string queryStrRole = $"Select id, role, lastname, name, parent, status FROM users WHERE login = '{login}' AND password = '{pass}'";
            MySqlCommand commandRole = new MySqlCommand(queryStrRole, conn);
            adapterRole.SelectCommand = commandRole;
            adapterRole.Fill(tableRole);

            MessageBox.Show(tableRole.Rows.Count.ToString());
          //  string idUser = tableRole.Rows[0].ItemArray[0].ToString();
            string role = tableRole.Rows[0].ItemArray[1].ToString();

            string f = tableRole.Rows[0].ItemArray[2].ToString();
            string i = tableRole.Rows[0].ItemArray[3].ToString();
            string o = tableRole.Rows[0].ItemArray[4].ToString();
            string status = tableRole.Rows[0].ItemArray[5].ToString();

            if (status == "Уволен")
            {
                MessageBox.Show("Данный сотрудник уволен", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            switch (role)
            {
                case "Администратор":
                    admin adm = new admin(f, i, o);
                    adm.ShowDialog();
                    break;
                case "Официант":

                    waiter wai = new waiter(f, i, o);
                    wai.ShowDialog();
                    break;
                case "Повар":
                    cook cook = new cook(f, i, o);
                    cook.ShowDialog();
                    break;
                default:
                    MessageBox.Show("Неверные данные авторизации!", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            dbConnect.CloseConnection();
        }

        private void VisibilityChange(object sender, EventArgs e)
        {
            if (visibChange.Checked == true) password.UseSystemPasswordChar = false;
            else password.UseSystemPasswordChar = true;
        }

        private void Enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) EnterBut(sender, e);
        }
        #region DEBUG

        private void Deb1_Click(object sender, EventArgs e)
        {
            admin adm = new admin("DEBUG", "", "");
            adm.ShowDialog();
        }

        private void Deb2_Click(object sender, EventArgs e)
        {
            cook cook = new cook("DEBUG","","");
            cook.ShowDialog();
        }

        private void Deb3_Click(object sender, EventArgs e)
        {
            waiter wai = new waiter("DEBUG", "", "");
            wai.ShowDialog();
        }
        #endregion
    }
}
