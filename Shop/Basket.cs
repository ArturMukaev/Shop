using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Shop
{
    public partial class Basket : Form
    {
        public Basket()
        {
            InitializeComponent();
        }
        private MainPage m1;
        public static int costt = 0;
        public static string order = "";
        private void MainPage_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `products` WHERE `products`.`taken` > 0", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            List<object> lis = new List<object>();
            foreach (DataRow row in table.Rows)
            {
                var cells = row.ItemArray;
                foreach (var cell in cells)
                {
                    lis.Add(cell);
                }
            }
            if (lis.Count == 0)
            {
                MessageBox.Show("Сначала добавьте товары в корзину!");
                this.Close();
                this.m1 = new MainPage();
                this.m1.Show();
            }
            else
            {
                int place = 100;
                for (int i = 0; i < lis.Count; i += 8)
                {
                    GroupBox hek = new GroupBox();
                    Label name = new Label();
                    PictureBox pict = new PictureBox();
                    Label weight = new Label();
                    Label price = new Label();
                    Label date = new Label();
                    Label expdate = new Label();
                    Label ammount = new Label();
                    Label totalCost = new Label();
                    Button remove = new Button();
                    hek.Size = new Size(500, 120);
                    hek.Location = new Point(30, place);

                    this.Controls.Add(hek);
                    hek.Controls.Add(name);
                    hek.Controls.Add(weight);
                    hek.Controls.Add(price);
                    hek.Controls.Add(date);
                    hek.Controls.Add(expdate);
                    hek.Controls.Add(pict);
                    hek.Controls.Add(ammount);
                    hek.Controls.Add(totalCost);
                    hek.Controls.Add(remove);

                    name.Text = lis[i + 2].ToString();
                    name.Location = new Point(150, 10);
                    name.Font = new System.Drawing.Font("Comic Sans MS", 12F);

                    weight.Text = "Вес: " + lis[i + 3].ToString() + " кг";
                    weight.Location = new Point(140, 40);
                    weight.Size = new Size(100, 15);

                    ammount.Text = "Количество: " + lis[i + 7].ToString();
                    ammount.Location = new Point(340, 40);
                    ammount.Size = new Size(100, 15);

                    totalCost.Text = "Итого цена: " + ((int)lis[i + 4]*(int)lis[i + 7]).ToString() + " Р";
                    totalCost.Location = new Point(340, 80);
                    totalCost.Size = new Size(150, 15);

                    price.Text = "Цена: " + lis[i + 4].ToString() + " Р";
                    price.Location = new Point(140, 60);
                    price.Size = new Size(100, 15);

                    remove.Text = "Убрать";
                    remove.Name = lis[i].ToString();
                    remove.Location = new Point(417, 10);
                    remove.Size = new Size(80, 25);
                    remove.Font = new System.Drawing.Font("Comic Sans MS", 9F);
                    remove.FlatStyle = FlatStyle.Flat;
                    remove.BackColor = Color.DarkOrchid;
                    remove.Click += Remove;

                    date.Text = "Дата выпуска: " + lis[i + 5].ToString();
                    date.Location = new Point(140, 80);
                    date.Size = new Size(150, 15);

                    expdate.Text = "Годен до: " + lis[i + 6].ToString();
                    expdate.Location = new Point(140, 100);
                    expdate.Size = new Size(150, 15);

                    Bitmap image = new Bitmap(@"img\" + lis[i + 2].ToString() + ".jpg");
                    pict.Image = image;
                    pict.Location = new Point(20, 10);
                    pict.SizeMode = PictureBoxSizeMode.Zoom;
                    pict.Size = new Size(100, 100);

                    order += lis[i + 2].ToString()+" x"+ lis[i + 7].ToString()+ " + ";
                    costt += (int)lis[i + 4] * (int)lis[i + 7];
                    place += 130;
                }
                total.Text = "Итоговая сумма к оплате: " + costt.ToString() + " Р";
            }
        }
        private Basket b1;
        private void Remove(object sender, EventArgs e)
        {
            var ctrl = (sender as Control);
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command1 = new MySqlCommand("SELECT * FROM `products` WHERE `products`.`id` =" + ctrl.Name, db.getConnection());
            adapter.SelectCommand = command1;
            adapter.Fill(table);
            List<object> lis = new List<object>();
            foreach (DataRow row in table.Rows)
            {
                var cells = row.ItemArray;
                foreach (var cell in cells)
                {
                    lis.Add(cell);
                }
            }
            MySqlCommand command = new MySqlCommand("UPDATE `products` SET `taken` =" + ((int)lis[7] - 1).ToString() + " WHERE `products`.`id` =" + ctrl.Name, db.getConnection());
            db.openConnection();
            command.ExecuteNonQuery();
            db.closeConnection();
            MessageBox.Show("Товар удален из корзины");
            this.Close();
            costt = 0;
            order = "";
            this.b1 = new Basket();
            this.b1.Show();
            
        }

        Point lastPoint;
        private void MainPage_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void MainPage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.White;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.DarkOrchid;
        }

        private void MainPage_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }


        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Orange;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.m1 = new MainPage();
            this.m1.Show();
        }

        private void ready_MouseEnter(object sender, EventArgs e)
        {
            ready.BackColor = Color.Gold;
        }

        private void ready_MouseLeave(object sender, EventArgs e)
        {
            ready.BackColor = Color.HotPink;
        }
        private Order or1;
        private void ready_Click(object sender, EventArgs e)
        {

            this.Close();
            this.b1 = new Basket();
            this.b1.Show();
            this.Close();
            this.or1 = new Order();
            this.or1.Show();
        }

        private void Basket_FormClosed(object sender, FormClosedEventArgs e)
        {
            costt = 0;
            order = "";
        }
    }
}
