namespace Shop
{
    partial class Consoles
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.search = new System.Windows.Forms.TextBox();
            this.case5 = new System.Windows.Forms.Label();
            this.case4 = new System.Windows.Forms.Label();
            this.case3 = new System.Windows.Forms.Label();
            this.case2 = new System.Windows.Forms.Label();
            this.case1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "GAMER";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.search);
            this.panel1.Controls.Add(this.case5);
            this.panel1.Controls.Add(this.case4);
            this.panel1.Controls.Add(this.case3);
            this.panel1.Controls.Add(this.case2);
            this.panel1.Controls.Add(this.case1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 2;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Image = global::Shop.Properties.Resources.krest;
            this.pictureBox3.Location = new System.Drawing.Point(746, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseEnter += new System.EventHandler(this.pictureBox3_MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::Shop.Properties.Resources.lupa;
            this.pictureBox2.Location = new System.Drawing.Point(528, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Shop.Properties.Resources.Pocket1;
            this.pictureBox1.Location = new System.Drawing.Point(613, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(294, 24);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(228, 22);
            this.search.TabIndex = 7;
            this.search.Enter += new System.EventHandler(this.search_Enter);
            // 
            // case5
            // 
            this.case5.AutoSize = true;
            this.case5.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.case5.Location = new System.Drawing.Point(680, 70);
            this.case5.Name = "case5";
            this.case5.Size = new System.Drawing.Size(74, 19);
            this.case5.TabIndex = 6;
            this.case5.Text = "Сувениры";
            this.case5.Click += new System.EventHandler(this.case5_Click);
            this.case5.MouseEnter += new System.EventHandler(this.case5_MouseEnter);
            this.case5.MouseLeave += new System.EventHandler(this.case5_MouseLeave);
            // 
            // case4
            // 
            this.case4.AutoSize = true;
            this.case4.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.case4.Location = new System.Drawing.Point(545, 70);
            this.case4.Name = "case4";
            this.case4.Size = new System.Drawing.Size(123, 19);
            this.case4.TabIndex = 5;
            this.case4.Text = "Коды погашения";
            this.case4.Click += new System.EventHandler(this.case4_Click);
            this.case4.MouseEnter += new System.EventHandler(this.case4_MouseEnter);
            this.case4.MouseLeave += new System.EventHandler(this.case4_MouseLeave);
            // 
            // case3
            // 
            this.case3.AutoSize = true;
            this.case3.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.case3.Location = new System.Drawing.Point(436, 70);
            this.case3.Name = "case3";
            this.case3.Size = new System.Drawing.Size(86, 19);
            this.case3.TabIndex = 4;
            this.case3.Text = "Аксессуары";
            this.case3.Click += new System.EventHandler(this.case3_Click);
            this.case3.MouseEnter += new System.EventHandler(this.case3_MouseEnter);
            this.case3.MouseLeave += new System.EventHandler(this.case3_MouseLeave);
            // 
            // case2
            // 
            this.case2.AutoSize = true;
            this.case2.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.case2.Location = new System.Drawing.Point(372, 70);
            this.case2.Name = "case2";
            this.case2.Size = new System.Drawing.Size(44, 19);
            this.case2.TabIndex = 3;
            this.case2.Text = "Игры";
            this.case2.Click += new System.EventHandler(this.case2_Click);
            this.case2.MouseEnter += new System.EventHandler(this.case2_MouseEnter);
            this.case2.MouseLeave += new System.EventHandler(this.case2_MouseLeave);
            // 
            // case1
            // 
            this.case1.AutoSize = true;
            this.case1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.case1.Location = new System.Drawing.Point(217, 70);
            this.case1.Name = "case1";
            this.case1.Size = new System.Drawing.Size(140, 19);
            this.case1.TabIndex = 2;
            this.case1.Text = "Игровые приставки";
            this.case1.MouseEnter += new System.EventHandler(this.case1_MouseEnter);
            this.case1.MouseLeave += new System.EventHandler(this.case1_MouseLeave);
            // 
            // Consoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Consoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.Click += new System.EventHandler(this.MainPage_Click);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPage_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPage_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label case4;
        private System.Windows.Forms.Label case3;
        private System.Windows.Forms.Label case2;
        private System.Windows.Forms.Label case1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label case5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

