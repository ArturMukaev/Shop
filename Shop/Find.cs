using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Shop
{
    public partial class Find : Form
    {
        public Find()
        {
            InitializeComponent();
        }
        private MainPage m1;
        private void MainPage_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `products` WHERE `products`.`name` =" + "'" + MainPage.searched + "'", db.getConnection());
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
                MessageBox.Show("По данному запросу ничего не найдено!");
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
                    Button pack = new Button();
                    hek.Size = new Size(500, 120);
                    hek.Location = new Point(30, place);

                    this.Controls.Add(hek);
                    hek.Controls.Add(name);
                    hek.Controls.Add(weight);
                    hek.Controls.Add(price);
                    hek.Controls.Add(date);
                    hek.Controls.Add(expdate);
                    hek.Controls.Add(pict);
                    hek.Controls.Add(pack);

                    pack.Text = "В корзину";
                    pack.Name = lis[i].ToString();
                    pack.Location = new Point(400, 85);
                    pack.Size = new Size(80, 25);
                    pack.Font = new System.Drawing.Font("Comic Sans MS", 9F);
                    pack.FlatStyle = FlatStyle.Flat;
                    pack.BackColor = Color.DarkOrchid;
                    pack.Click += Pack;

                    name.Text = lis[i + 2].ToString();
                    name.Location = new Point(150, 10);
                    name.Font = new System.Drawing.Font("Comic Sans MS", 12F);

                    weight.Text = "Вес: " + lis[i + 3].ToString() + " кг";
                    weight.Location = new Point(140, 40);
                    weight.Size = new Size(100, 15);

                    price.Text = "Цена: " + lis[i + 4].ToString() + " Р";
                    price.Location = new Point(140, 60);
                    price.Size = new Size(100, 15);

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


                    place += 130;
                }
            }
        }
        private void Pack(object sender, EventArgs e)
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
            MySqlCommand command = new MySqlCommand("UPDATE `products` SET `taken` =" + ((int)lis[7] + 1).ToString() + " WHERE `products`.`id` =" + ctrl.Name, db.getConnection());
            db.openConnection();
            command.ExecuteNonQuery();
            db.closeConnection();
            MessageBox.Show("Товар добавлен в корзину");
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

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.White;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.DarkOrchid;
        }

        private void case1_MouseEnter(object sender, EventArgs e)
        {
            case1.ForeColor = Color.Orange;
        }

        private void case1_MouseLeave(object sender, EventArgs e)
        {
            case1.ForeColor = Color.Black;
        }

        private void case2_MouseEnter(object sender, EventArgs e)
        {
            case2.ForeColor = Color.Orange;
        }

        private void case2_MouseLeave(object sender, EventArgs e)
        {
            case2.ForeColor = Color.Black;
        }

        private void case3_MouseEnter(object sender, EventArgs e)
        {
            case3.ForeColor = Color.Orange;
        }

        private void case3_MouseLeave(object sender, EventArgs e)
        {
            case3.ForeColor = Color.Black;
        }

        private void case4_MouseEnter(object sender, EventArgs e)
        {
            case4.ForeColor = Color.Orange;
        }

        private void case4_MouseLeave(object sender, EventArgs e)
        {
            case4.ForeColor = Color.Black;
        }

        private void case5_MouseEnter(object sender, EventArgs e)
        {
            case5.ForeColor = Color.Orange;
        }

        private void case5_MouseLeave(object sender, EventArgs e)
        {
            case5.ForeColor = Color.Black;
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

        private Consoles f2;
        private void case1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.f2 = new Consoles();
            this.f2.Show();
        }
        private Games f3;
        private void case2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.f3 = new Games();
            this.f3.Show();
        }
        private Accesso f4;
        private void case3_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.f4 = new Accesso();
            this.f4.Show();
        }
        private Codes f5;
        private void case4_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.f5 = new Codes();
            this.f5.Show();
        }
        private Souvenirs f6;
        private void case5_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.f6 = new Souvenirs();
            this.f6.Show();
        }

        private Basket b1;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.b1 = new Basket();
            this.b1.Show();
        }
    }
}
