﻿namespace EmployeeManagerment_UI.User
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid_listemployee = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_monthcalendar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_yearcalendar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_calendar = new System.Windows.Forms.Button();
            this.btn_addeditemployee = new System.Windows.Forms.Button();
            this.btn_addeditsalary = new System.Windows.Forms.Button();
            this.btn_accountmanagement = new System.Windows.Forms.Button();
            this.btn_addeditevent = new System.Windows.Forms.Button();
            this.btn_reload = new System.Windows.Forms.Button();
            this.bnt_supplier = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_listemployee)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_listemployee
            // 
            this.grid_listemployee.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_listemployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_listemployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_listemployee.DefaultCellStyle = dataGridViewCellStyle4;
            this.grid_listemployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_listemployee.GridColor = System.Drawing.Color.Black;
            this.grid_listemployee.Location = new System.Drawing.Point(201, 132);
            this.grid_listemployee.Margin = new System.Windows.Forms.Padding(2);
            this.grid_listemployee.Name = "grid_listemployee";
            this.grid_listemployee.RowTemplate.Height = 28;
            this.grid_listemployee.Size = new System.Drawing.Size(660, 475);
            this.grid_listemployee.TabIndex = 2;
            this.grid_listemployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(201, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 132);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::EmployeeManagerment_UI.Properties.Resources.em_01;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(-45, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(719, 131);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt_monthcalendar
            // 
            this.txt_monthcalendar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txt_monthcalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_monthcalendar.ForeColor = System.Drawing.Color.Black;
            this.txt_monthcalendar.Location = new System.Drawing.Point(7, 180);
            this.txt_monthcalendar.Margin = new System.Windows.Forms.Padding(2);
            this.txt_monthcalendar.Name = "txt_monthcalendar";
            this.txt_monthcalendar.Size = new System.Drawing.Size(85, 29);
            this.txt_monthcalendar.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tháng";
            // 
            // txt_yearcalendar
            // 
            this.txt_yearcalendar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txt_yearcalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_yearcalendar.ForeColor = System.Drawing.Color.Black;
            this.txt_yearcalendar.Location = new System.Drawing.Point(107, 180);
            this.txt_yearcalendar.Margin = new System.Windows.Forms.Padding(2);
            this.txt_yearcalendar.Name = "txt_yearcalendar";
            this.txt_yearcalendar.Size = new System.Drawing.Size(85, 29);
            this.txt_yearcalendar.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(106, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Năm";
            // 
            // btn_calendar
            // 
            this.btn_calendar.BackgroundImage = global::EmployeeManagerment_UI.Properties.Resources.ca_012;
            this.btn_calendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_calendar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_calendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_calendar.Location = new System.Drawing.Point(1, 243);
            this.btn_calendar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_calendar.Name = "btn_calendar";
            this.btn_calendar.Size = new System.Drawing.Size(200, 52);
            this.btn_calendar.TabIndex = 12;
            this.btn_calendar.UseVisualStyleBackColor = false;
            this.btn_calendar.Click += new System.EventHandler(this.btn_calendar_Click);
            // 
            // btn_addeditemployee
            // 
            this.btn_addeditemployee.BackColor = System.Drawing.Color.White;
            this.btn_addeditemployee.BackgroundImage = global::EmployeeManagerment_UI.Properties.Resources.nv_01;
            this.btn_addeditemployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_addeditemployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_addeditemployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addeditemployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_addeditemployee.Location = new System.Drawing.Point(1, 295);
            this.btn_addeditemployee.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addeditemployee.Name = "btn_addeditemployee";
            this.btn_addeditemployee.Size = new System.Drawing.Size(200, 52);
            this.btn_addeditemployee.TabIndex = 13;
            this.btn_addeditemployee.UseVisualStyleBackColor = false;
            this.btn_addeditemployee.Click += new System.EventHandler(this.btn_addeditemployee_Click);
            // 
            // btn_addeditsalary
            // 
            this.btn_addeditsalary.BackgroundImage = global::EmployeeManagerment_UI.Properties.Resources.l_01;
            this.btn_addeditsalary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_addeditsalary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_addeditsalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addeditsalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_addeditsalary.Location = new System.Drawing.Point(1, 347);
            this.btn_addeditsalary.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addeditsalary.Name = "btn_addeditsalary";
            this.btn_addeditsalary.Size = new System.Drawing.Size(200, 52);
            this.btn_addeditsalary.TabIndex = 14;
            this.btn_addeditsalary.UseVisualStyleBackColor = false;
            this.btn_addeditsalary.Click += new System.EventHandler(this.btn_addeditsalary_Click);
            // 
            // btn_accountmanagement
            // 
            this.btn_accountmanagement.BackgroundImage = global::EmployeeManagerment_UI.Properties.Resources.id_01;
            this.btn_accountmanagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_accountmanagement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_accountmanagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_accountmanagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_accountmanagement.Location = new System.Drawing.Point(1, 399);
            this.btn_accountmanagement.Margin = new System.Windows.Forms.Padding(2);
            this.btn_accountmanagement.Name = "btn_accountmanagement";
            this.btn_accountmanagement.Size = new System.Drawing.Size(200, 52);
            this.btn_accountmanagement.TabIndex = 15;
            this.btn_accountmanagement.UseVisualStyleBackColor = false;
            this.btn_accountmanagement.Click += new System.EventHandler(this.btn_accountmanagement_Click);
            // 
            // btn_addeditevent
            // 
            this.btn_addeditevent.BackgroundImage = global::EmployeeManagerment_UI.Properties.Resources.sk_01;
            this.btn_addeditevent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_addeditevent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_addeditevent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addeditevent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_addeditevent.Location = new System.Drawing.Point(1, 451);
            this.btn_addeditevent.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addeditevent.Name = "btn_addeditevent";
            this.btn_addeditevent.Size = new System.Drawing.Size(200, 52);
            this.btn_addeditevent.TabIndex = 16;
            this.btn_addeditevent.UseVisualStyleBackColor = false;
            this.btn_addeditevent.Click += new System.EventHandler(this.btn_addeditevent_Click);
            // 
            // btn_reload
            // 
            this.btn_reload.BackgroundImage = global::EmployeeManagerment_UI.Properties.Resources.tailai;
            this.btn_reload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_reload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_reload.Location = new System.Drawing.Point(1, 555);
            this.btn_reload.Margin = new System.Windows.Forms.Padding(2);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(200, 52);
            this.btn_reload.TabIndex = 17;
            this.btn_reload.UseVisualStyleBackColor = false;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // bnt_supplier
            // 
            this.bnt_supplier.BackgroundImage = global::EmployeeManagerment_UI.Properties.Resources.vattu_01;
            this.bnt_supplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bnt_supplier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bnt_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_supplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bnt_supplier.Location = new System.Drawing.Point(1, 503);
            this.bnt_supplier.Margin = new System.Windows.Forms.Padding(2);
            this.bnt_supplier.Name = "bnt_supplier";
            this.bnt_supplier.Size = new System.Drawing.Size(200, 52);
            this.bnt_supplier.TabIndex = 18;
            this.bnt_supplier.UseVisualStyleBackColor = false;
            this.bnt_supplier.Click += new System.EventHandler(this.bnt_supplier_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.BackgroundImage = global::EmployeeManagerment_UI.Properties.Resources.Untitled_1_01;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.bnt_supplier);
            this.panel2.Controls.Add(this.btn_reload);
            this.panel2.Controls.Add(this.btn_addeditevent);
            this.panel2.Controls.Add(this.btn_accountmanagement);
            this.panel2.Controls.Add(this.btn_addeditsalary);
            this.panel2.Controls.Add(this.btn_addeditemployee);
            this.panel2.Controls.Add(this.btn_calendar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_yearcalendar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_monthcalendar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 607);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::EmployeeManagerment_UI.Properties.Resources.design_by__01;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(205, 132);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EmployeeManagerment_UI.Properties.Resources.Untitled_1_01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(861, 607);
            this.Controls.Add(this.grid_listemployee);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.grid_listemployee)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView grid_listemployee;
        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_monthcalendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_yearcalendar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_calendar;
        private System.Windows.Forms.Button btn_addeditemployee;
        private System.Windows.Forms.Button btn_addeditsalary;
        private System.Windows.Forms.Button btn_accountmanagement;
        private System.Windows.Forms.Button btn_addeditevent;
        private System.Windows.Forms.Button btn_reload;
        private System.Windows.Forms.Button bnt_supplier;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}