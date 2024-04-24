namespace DemoExIDO2._0
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.администрированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регистрацияПользователяВСистемеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.журналToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tabcontrol1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DismissButton = new System.Windows.Forms.Button();
            this.EmployeeRefButton = new System.Windows.Forms.Button();
            this.Employees = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ShiftRefButton = new System.Windows.Forms.Button();
            this.Shifts = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.OrderRefButton = new System.Windows.Forms.Button();
            this.Orders = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.Tabcontrol1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Employees)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Shifts)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.администрированиеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(976, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // администрированиеToolStripMenuItem
            // 
            this.администрированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.регистрацияПользователяВСистемеToolStripMenuItem,
            this.создатьToolStripMenuItem,
            this.журналToolStripMenuItem});
            this.администрированиеToolStripMenuItem.Name = "администрированиеToolStripMenuItem";
            this.администрированиеToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.администрированиеToolStripMenuItem.Text = "Администрирование";
            // 
            // регистрацияПользователяВСистемеToolStripMenuItem
            // 
            this.регистрацияПользователяВСистемеToolStripMenuItem.Name = "регистрацияПользователяВСистемеToolStripMenuItem";
            this.регистрацияПользователяВСистемеToolStripMenuItem.Size = new System.Drawing.Size(345, 26);
            this.регистрацияПользователяВСистемеToolStripMenuItem.Text = "Регистрация сотрудника в системе";
            this.регистрацияПользователяВСистемеToolStripMenuItem.Click += new System.EventHandler(this.Register);
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(345, 26);
            this.создатьToolStripMenuItem.Text = "Создание смены";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // журналToolStripMenuItem
            // 
            this.журналToolStripMenuItem.Name = "журналToolStripMenuItem";
            this.журналToolStripMenuItem.Size = new System.Drawing.Size(345, 26);
            this.журналToolStripMenuItem.Text = "Журнал";
            this.журналToolStripMenuItem.Click += new System.EventHandler(this.OpenJournal);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.ExitButton);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(366, 305);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добро пожаловать!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(344, 339);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Федоров Федор Федорович";
            // 
            // Tabcontrol1
            // 
            this.Tabcontrol1.Controls.Add(this.tabPage1);
            this.Tabcontrol1.Controls.Add(this.tabPage2);
            this.Tabcontrol1.Controls.Add(this.tabPage3);
            this.Tabcontrol1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tabcontrol1.Location = new System.Drawing.Point(13, 28);
            this.Tabcontrol1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Tabcontrol1.Name = "Tabcontrol1";
            this.Tabcontrol1.SelectedIndex = 0;
            this.Tabcontrol1.Size = new System.Drawing.Size(950, 482);
            this.Tabcontrol1.TabIndex = 15;
            this.Tabcontrol1.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(207)))), ((int)(((byte)(217)))));
            this.tabPage1.Controls.Add(this.DismissButton);
            this.tabPage1.Controls.Add(this.EmployeeRefButton);
            this.tabPage1.Controls.Add(this.Employees);
            this.tabPage1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(942, 450);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Журнал сотрудников";
            // 
            // DismissButton
            // 
            this.DismissButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(158)))), ((int)(((byte)(188)))));
            this.DismissButton.Location = new System.Drawing.Point(415, 404);
            this.DismissButton.Name = "DismissButton";
            this.DismissButton.Size = new System.Drawing.Size(118, 35);
            this.DismissButton.TabIndex = 11;
            this.DismissButton.Text = "Уволить";
            this.DismissButton.UseVisualStyleBackColor = false;
            this.DismissButton.Click += new System.EventHandler(this.DismissButton_Click);
            this.DismissButton.MouseLeave += new System.EventHandler(this.MouseLeave3);
            this.DismissButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove3);
            // 
            // EmployeeRefButton
            // 
            this.EmployeeRefButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(158)))), ((int)(((byte)(188)))));
            this.EmployeeRefButton.Location = new System.Drawing.Point(811, 373);
            this.EmployeeRefButton.Name = "EmployeeRefButton";
            this.EmployeeRefButton.Size = new System.Drawing.Size(118, 35);
            this.EmployeeRefButton.TabIndex = 10;
            this.EmployeeRefButton.Text = "Обновить";
            this.EmployeeRefButton.UseVisualStyleBackColor = false;
            this.EmployeeRefButton.Click += new System.EventHandler(this.EmployeeRefButton_Click);
            this.EmployeeRefButton.MouseLeave += new System.EventHandler(this.MouseLeave);
            this.EmployeeRefButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            // 
            // Employees
            // 
            this.Employees.AllowUserToAddRows = false;
            this.Employees.AllowUserToDeleteRows = false;
            this.Employees.AllowUserToResizeColumns = false;
            this.Employees.AllowUserToResizeRows = false;
            this.Employees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Employees.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Employees.Location = new System.Drawing.Point(7, 31);
            this.Employees.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Employees.Name = "Employees";
            this.Employees.RowHeadersWidth = 51;
            this.Employees.Size = new System.Drawing.Size(925, 336);
            this.Employees.TabIndex = 9;
            this.Employees.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Employees_CellMouseDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(207)))), ((int)(((byte)(217)))));
            this.tabPage2.Controls.Add(this.ShiftRefButton);
            this.tabPage2.Controls.Add(this.Shifts);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(942, 450);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Журнал смен";
            // 
            // ShiftRefButton
            // 
            this.ShiftRefButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(158)))), ((int)(((byte)(188)))));
            this.ShiftRefButton.Location = new System.Drawing.Point(814, 397);
            this.ShiftRefButton.Name = "ShiftRefButton";
            this.ShiftRefButton.Size = new System.Drawing.Size(118, 35);
            this.ShiftRefButton.TabIndex = 11;
            this.ShiftRefButton.Text = "Обновить";
            this.ShiftRefButton.UseVisualStyleBackColor = false;
            this.ShiftRefButton.Click += new System.EventHandler(this.ShiftRefButton_Click);
            this.ShiftRefButton.MouseLeave += new System.EventHandler(this.MouseLeave1);
            this.ShiftRefButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove1);
            // 
            // Shifts
            // 
            this.Shifts.AllowUserToAddRows = false;
            this.Shifts.AllowUserToDeleteRows = false;
            this.Shifts.AllowUserToResizeColumns = false;
            this.Shifts.AllowUserToResizeRows = false;
            this.Shifts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Shifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Shifts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Shifts.Location = new System.Drawing.Point(7, 55);
            this.Shifts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Shifts.Name = "Shifts";
            this.Shifts.RowHeadersWidth = 51;
            this.Shifts.Size = new System.Drawing.Size(925, 336);
            this.Shifts.TabIndex = 10;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(207)))), ((int)(((byte)(217)))));
            this.tabPage3.Controls.Add(this.OrderRefButton);
            this.tabPage3.Controls.Add(this.Orders);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage3.Size = new System.Drawing.Size(942, 450);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Журнал заказов";
            // 
            // OrderRefButton
            // 
            this.OrderRefButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(158)))), ((int)(((byte)(188)))));
            this.OrderRefButton.Location = new System.Drawing.Point(814, 397);
            this.OrderRefButton.Name = "OrderRefButton";
            this.OrderRefButton.Size = new System.Drawing.Size(118, 35);
            this.OrderRefButton.TabIndex = 11;
            this.OrderRefButton.Text = "Обновить";
            this.OrderRefButton.UseVisualStyleBackColor = false;
            this.OrderRefButton.Click += new System.EventHandler(this.OrderRefButton_Click);
            this.OrderRefButton.MouseLeave += new System.EventHandler(this.MouseLeave2);
            this.OrderRefButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove2);
            // 
            // Orders
            // 
            this.Orders.AllowUserToAddRows = false;
            this.Orders.AllowUserToDeleteRows = false;
            this.Orders.AllowUserToResizeColumns = false;
            this.Orders.AllowUserToResizeRows = false;
            this.Orders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Orders.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Orders.Location = new System.Drawing.Point(7, 55);
            this.Orders.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Orders.Name = "Orders";
            this.Orders.RowHeadersWidth = 51;
            this.Orders.Size = new System.Drawing.Size(925, 336);
            this.Orders.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DemoExIDO2._0.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(828, 31);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 132);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DemoExIDO2._0.Properties.Resources.Федоров;
            this.pictureBox1.Location = new System.Drawing.Point(366, 134);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(207)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(976, 522);
            this.Controls.Add(this.Tabcontrol1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "admin";
            this.Text = "Форма администратора ИС Кафе";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Tabcontrol1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Employees)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Shifts)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem администрированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem регистрацияПользователяВСистемеToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl Tabcontrol1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolStripMenuItem журналToolStripMenuItem;
        private System.Windows.Forms.DataGridView Employees;
        private System.Windows.Forms.DataGridView Shifts;
        private System.Windows.Forms.DataGridView Orders;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.Button EmployeeRefButton;
        private System.Windows.Forms.Button DismissButton;
        private System.Windows.Forms.Button ShiftRefButton;
        private System.Windows.Forms.Button OrderRefButton;
    }
}

