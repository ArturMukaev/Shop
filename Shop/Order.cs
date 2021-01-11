using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Shop
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Yellow;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkOrange;
        }
        private Basket b1;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Basket.costt = 0;
            Basket.order = "";
            this.b1 = new Basket();
            this.b1.Show();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Yellow;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightCoral;
        }
        private MainPage m1;
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
            {
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("INSERT INTO `orders` (`surname`, `name`, `patronymic`, `adress`, `telephone`, `mail`, `price`, `ordered`) VALUES (" + "'" + textBox1.Text + "', '" +
                    textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "', '" + Basket.costt.ToString() + "', '" + Basket.order + "')", db.getConnection());
                db.openConnection();
                command.ExecuteNonQuery();
                db.closeConnection();
                MessageBox.Show("Заказ оформлен! Ожидайте звонка.");
                this.Close();
                Basket.costt = 0;
                Basket.order = "";
                this.m1 = new MainPage();
                this.m1.Show();
                MySqlCommand command1 = new MySqlCommand("UPDATE `products` SET `taken` = 0 WHERE `products`.`taken` > 0", db.getConnection());
                db.openConnection();
                command1.ExecuteNonQuery();
                db.closeConnection();
            }
            else
            {
                MessageBox.Show("Заполните сначала все регистрационные поля!");
            }
        }

        private void Order_Load(object sender, EventArgs e)
        {
            label9.Text = "Итого к оплате: " + Basket.costt.ToString() + " Р";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == ' ' || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == ' ' || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == ' ' || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


    }
}
