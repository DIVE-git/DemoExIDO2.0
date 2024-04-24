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
    
    public partial class cook : Form
    {
        int indexRow;
        public cook(string fam, string name, string otch)
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
        #endregion

        private void ViewOrders(object sender, EventArgs e)
        {
            if (groupBox1.Visible == true) groupBox1.Visible = false;
            else
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

                DataTable tableRole = new DataTable();

                string queryStrRole = "SELECT id as 'ID', shifr AS 'Код заказа', date as 'Дата создания', time as 'Время заказа', id_guest as 'Код клиента', desk as 'Стол', shift as 'Смена', status as 'Статус' FROM orders";
                MySqlCommand commandRole = new MySqlCommand(queryStrRole, conn);
                adapterRole.SelectCommand = commandRole;
                adapterRole.Fill(tableRole);

                Orders.DataSource = tableRole;

                dbConnect.CloseConnection();

                groupBox1.Visible = true;
            }
        }

        private void ehandled(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Orders_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            indexRow = Orders.CurrentCell.RowIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConnect dbConnect = new DBConnect();

            MySqlConnection conn = dbConnect.GetConnection();

            string queryStrRole = $"UPDATE orders SET status = '{comboBox1.Text}' WHERE id = {Orders[0, indexRow].Value}";
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
            ViewOrders(sender, e);
            ViewOrders(sender, e);
        }
    }
}
