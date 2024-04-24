namespace DemoExIDO2._0
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.userName = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.visibChange = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deb3 = new System.Windows.Forms.Button();
            this.deb2 = new System.Windows.Forms.Button();
            this.deb1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(176, 218);
            this.userName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(181, 27);
            this.userName.TabIndex = 1;
            this.userName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Enter);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(176, 248);
            this.password.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(181, 27);
            this.password.TabIndex = 2;
            this.password.UseSystemPasswordChar = true;
            this.password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 226);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя пользователя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 248);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(159, 51);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(158)))), ((int)(((byte)(188)))));
            this.button1.Location = new System.Drawing.Point(220, 278);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.EnterBut);
            this.button1.MouseLeave += new System.EventHandler(this.MouseLeave);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 57);
            this.label3.TabIndex = 7;
            this.label3.Text = "1 - админ\r\n2 - повар\r\n3 - оффициант\r\n";
            // 
            // visibChange
            // 
            this.visibChange.AutoSize = true;
            this.visibChange.Location = new System.Drawing.Point(78, 283);
            this.visibChange.Margin = new System.Windows.Forms.Padding(2);
            this.visibChange.Name = "visibChange";
            this.visibChange.Size = new System.Drawing.Size(144, 23);
            this.visibChange.TabIndex = 8;
            this.visibChange.Text = "Показать пароль";
            this.visibChange.UseVisualStyleBackColor = true;
            this.visibChange.CheckedChanged += new System.EventHandler(this.VisibilityChange);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deb3);
            this.groupBox1.Controls.Add(this.deb2);
            this.groupBox1.Controls.Add(this.deb1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(377, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 172);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DEBUG";
            // 
            // deb3
            // 
            this.deb3.Location = new System.Drawing.Point(10, 140);
            this.deb3.Name = "deb3";
            this.deb3.Size = new System.Drawing.Size(75, 23);
            this.deb3.TabIndex = 12;
            this.deb3.Text = "button4";
            this.deb3.UseVisualStyleBackColor = true;
            this.deb3.Click += new System.EventHandler(this.Deb3_Click);
            // 
            // deb2
            // 
            this.deb2.Location = new System.Drawing.Point(10, 111);
            this.deb2.Name = "deb2";
            this.deb2.Size = new System.Drawing.Size(75, 23);
            this.deb2.TabIndex = 11;
            this.deb2.Text = "button3";
            this.deb2.UseVisualStyleBackColor = true;
            this.deb2.Click += new System.EventHandler(this.Deb2_Click);
            // 
            // deb1
            // 
            this.deb1.Location = new System.Drawing.Point(10, 82);
            this.deb1.Name = "deb1";
            this.deb1.Size = new System.Drawing.Size(75, 23);
            this.deb1.TabIndex = 10;
            this.deb1.Text = "button2";
            this.deb1.UseVisualStyleBackColor = true;
            this.deb1.Click += new System.EventHandler(this.Deb1_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(207)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(505, 347);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.visibChange);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userName);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "login";
            this.Text = "Авторизация в систему ИС Кафе";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox visibChange;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deb3;
        private System.Windows.Forms.Button deb2;
        private System.Windows.Forms.Button deb1;
    }
}

