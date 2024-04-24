using DemoExIDO2._0.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DemoExIDO2._0
{
    public partial class admin : Form
    {
        int indexRow;   
        public admin(string fam, string name, string otch)
        {
            InitializeComponent();
            label2.Text = $"{fam} {name} {otch}";

            switch (fam)
            {
                case "Беляева":
                    pictureBox1.Image = Properties.Resources.Беляева;
                    break;
                case "Иванов":
                    pictureBox1.Image = Properties.Resources.Иванов;
                    break;
                case "Игнатов":
                    pictureBox1.Image = Properties.Resources.Игнатов;
                    break;
                case "Миронов":
                    pictureBox1.Image = Properties.Resources.Миронов;
                    break;
                case "Петров":
                    pictureBox1.Image = Properties.Resources.Петров;
                    break;
                case "Смирнова":
                    pictureBox1.Image = Properties.Resources.Смирнова;
                    break;
                case "Стрелков":
                    pictureBox1.Image = Properties.Resources.Стрелков;
                    break;
                case "Федоров":
                    pictureBox1.Image = Properties.Resources.Федоров;
                    break;
                case "Хохлов":
                    pictureBox1.Image = Properties.Resources.Хохлов;
                    break;
                case "Ширяев":
                    pictureBox1.Image = Properties.Resources.Ширяев;
                    break;
                default:
                    pictureBox1.Image = pictureBox1.ErrorImage;
                    break;
            }
        }



        #region Закрывающие кнопки
        private void ExitButton(object sender, EventArgs e)
        {
            if (MessageBox.Show("Подтвердите закрытие приложения", "Выход", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) Environment.Exit(0);

        }


        private void MouseMove(object sender, MouseEventArgs e)
        {
            EmployeeRefButton.BackColor = Color.FromArgb(159, 85, 159);
        }

        private void MouseLeave(object sender, EventArgs e)
        {
            EmployeeRefButton.BackColor = Color.FromArgb(188, 158, 188);
        }

        private void MouseMove1(object sender, MouseEventArgs e)
        {
            ShiftRefButton.BackColor = Color.FromArgb(159, 85, 159);
        }

        private void MouseLeave1(object sender, EventArgs e)
        {
            ShiftRefButton.BackColor = Color.FromArgb(188, 158, 188);
        }


        private void MouseMove2(object sender, MouseEventArgs e)
        {
            OrderRefButton.BackColor = Color.FromArgb(159, 85, 159);
        }

        private void MouseLeave2(object sender, EventArgs e)
        {
            OrderRefButton.BackColor = Color.FromArgb(188, 158, 188);
        }

        private void MouseMove3(object sender, MouseEventArgs e)
        {
            DismissButton.BackColor = Color.FromArgb(255, 85, 159);
        }

        private void MouseLeave3(object sender, EventArgs e)
        {
            DismissButton.BackColor = Color.FromArgb(188, 158, 188);
        }


        #endregion

        private void Register(object sender, EventArgs e)
        {
            Create create = new Create();
            create.ShowDialog();

        }

        private void OpenJournal(object sender, EventArgs e)
        {
            if (Tabcontrol1.Visible == true) Tabcontrol1.Visible = false;
            else
            {
                Tabcontrol1.Visible = true;
            }
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // try
           // {
                ShiftCreate shift = new ShiftCreate();
                shift.ShowDialog();
         //   }
          //  catch
          //  {
             //   return;
          //  }
        }

        private void EmployeeRefButton_Click(object sender, EventArgs e)
        {
            EmplployeeRefresh();
        }

        private void OrderRefButton_Click(object sender, EventArgs e)
        {
            OrderRefresh();
        }

        private void ShiftRefButton_Click(object sender, EventArgs e)
        {
            ShiftRefresh();
        }




        private void EmplployeeRefresh()
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

            string queryStrRole = "Select id AS 'ID', role AS 'Роль', lastname AS 'Фамилия', name AS 'Имя', parent AS 'Отчество', login AS 'Имя пользователя', status AS 'Статус' FROM users";
            MySqlCommand command = new MySqlCommand(queryStrRole, conn);
            adapterRole.SelectCommand = command;
            adapterRole.Fill(table);

            Employees.DataSource = table;

            dbConnect.CloseConnection();
        }

        private void OrderRefresh()
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

            string queryStrRole = "SELECT id as 'ID', shifr AS 'Код заказа', date as 'Дата создания', time as 'Время заказа', id_guest as 'Код клиента', desk as 'Стол', shift as 'Смена', status as 'Статус' FROM orders";
            MySqlCommand command = new MySqlCommand(queryStrRole, conn);
            adapterRole.SelectCommand = command;
            adapterRole.Fill(table);

            Orders.DataSource = table;

            dbConnect.CloseConnection();
        }
        private void ShiftRefresh()
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

            string queryStrRole = "SELECT id as 'ID смены', ID_waiter as 'ID официанта', ID_cook AS 'ID повара', ID_admin as 'ID администратора' FROM `Changes`";
            MySqlCommand command = new MySqlCommand(queryStrRole, conn);
            adapterRole.SelectCommand = command;
            adapterRole.Fill(table);

            Shifts.DataSource = table;

            dbConnect.CloseConnection();
        }

        private void DismissButton_Click(object sender, EventArgs e)
        {
            DBConnect dbConnect = new DBConnect();

            MySqlConnection conn = dbConnect.GetConnection();

            string queryStrRole = $"DELETE FROM users WHERE id = {Employees[0, indexRow].Value}";
            MySqlCommand command = new MySqlCommand(queryStrRole, conn);

            try
            {
                dbConnect.OpenConnection();
                command.ExecuteNonQuery();
            }
            catch
            {
                return;
            }



            EmplployeeRefresh();
        }

        private void Employees_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            indexRow = Employees.CurrentCell.RowIndex;
           // MessageBox.Show(Employees.CurrentCell.RowIndex.ToString(), Employees[0, indexRow].Value.ToString());
        }
    }
}
