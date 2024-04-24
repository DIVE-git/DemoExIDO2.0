using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DemoExIDO2._0
{
    public partial class waiter : Form
    {
        int indexRow;
        public waiter(string fam,string name, string otch)
        {
            InitializeComponent();
            label4.Text = $"{fam} {name} {otch}";
            
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


        private void MouseMove1(object sender, MouseEventArgs e)
        {
            DeleteButton.BackColor = Color.FromArgb(159, 85, 159);
        }

        private void MouseLeave1(object sender, EventArgs e)
        {
            DeleteButton.BackColor = Color.FromArgb(188, 158, 188);
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            ConfirmButton.BackColor = Color.FromArgb(159, 85, 159);
        }

        private void MouseLeave(object sender, EventArgs e)
        {
            ConfirmButton.BackColor = Color.FromArgb(188, 158, 188);
        }
        #endregion

        DataTable tableRole;
        private void CreateOrder(object sender, EventArgs e)
        {
            if (groupBox1.Visible == true)
            {
                groupBox1.Visible = false;
                comboBox2.Items.Clear();
            }
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

                tableRole = new DataTable();

                string queryStrRole = "SELECT id, name, price FROM product";
                MySqlCommand commandRole = new MySqlCommand(queryStrRole, conn);
                adapterRole.SelectCommand = commandRole;
                adapterRole.Fill(tableRole);




                for (int i = 0; i < tableRole.Rows.Count; i++)
                {
                    comboBox2.Items.Add(tableRole.Rows[i][1].ToString());
                }

                dbConnect.CloseConnection();



                groupBox2.Visible = false;
                groupBox1.Visible = true;
            }
        }

        private void ViewJournal(object sender, EventArgs e)
        {
            if (groupBox2.Visible == true) groupBox2.Visible = false;
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



                groupBox1.Visible = false;
                groupBox2.Visible = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         //   label2.Text = comboBox1.SelectedIndex.ToString();
            switch (comboBox1.SelectedIndex)
            {
                case 2:
                    radioButton3.Enabled = false;
                    radioButton4.Enabled = false;
                    break;
                case 4:
                    radioButton3.Enabled = false;
                    radioButton4.Enabled = false;
                    break;
                case 5:
                    radioButton3.Enabled = false;
                    radioButton4.Enabled = false;
                    break;
                case 7:
                    radioButton3.Enabled = false;
                    radioButton4.Enabled = false;
                    break;
                default:
                    radioButton3.Enabled = true;
                    radioButton4.Enabled = true;
                    break;


            }
        }

        private void Ehandled(object sender, KeyPressEventArgs e)
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

            string queryStrRole = $"UPDATE orders SET status = '{comboBox3.Text}' WHERE id = {Orders[0, indexRow].Value}";
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
            ViewJournal(sender, e);
            ViewJournal(sender, e);
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            indexRow = dataGridView1.CurrentCell.RowIndex;
            DeleteButton.Enabled = true;
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            if(DeleteButton.Enabled == false) DeleteButton.Enabled = true;
            tableRole.DefaultView.RowFilter = $"name='{comboBox2.Text}'";
            dataGridView1.Rows.Add(tableRole.DefaultView[0].Row[0], comboBox2.Text, tableRole.DefaultView[0].Row[2]);

        //    comboBox2.Text = "";
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.Rows[indexRow]);
            DeleteButton.Enabled = false;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            DBConnect dbConnect = new DBConnect();

            MySqlConnection conn = dbConnect.GetConnection();
            string queryStrRole = $"INSERT INTO orders (shifr,date,time,id_guest,desk,shift,status) VALUES ('45462572/{DateTime.Today.ToShortDateString()}','{DateTime.Today.ToShortDateString()}','{DateTime.Now.ToString("t")}',45462572,'{comboBox1.Text}',21032022,'Новый')";
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

            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                MessageBox.Show(dataGridView1.Rows[i].Cells[0].ToString());
            }

            queryStrRole = $"INSERT INTO product_order (id_order,id_product) VALUES ('45462572/{DateTime.Today.ToShortDateString()}','{dataGridView1.Rows[0].Cells[0]}')";


            dbConnect.CloseConnection();
            MessageBox.Show("Заказ подтверждён!");



            // 45462572/{DateTime.Today.ToShortDateString()}

        }
    }
}
