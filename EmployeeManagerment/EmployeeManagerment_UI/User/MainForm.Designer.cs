namespace EmployeeManagerment_UI.User
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_monthcalendar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_yearcalendar = new System.Windows.Forms.TextBox();
            this.btn_calendar = new System.Windows.Forms.Button();
            this.btn_reload = new System.Windows.Forms.Button();
            this.btn_addeditevent = new System.Windows.Forms.Button();
            this.btn_accountmanagement = new System.Windows.Forms.Button();
            this.btn_addeditsalary = new System.Windows.Forms.Button();
            this.btn_addeditemployee = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1328, 142);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
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
            this.panel2.Location = new System.Drawing.Point(0, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 802);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(285, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1043, 802);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txt_monthcalendar
            // 
            this.txt_monthcalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_monthcalendar.Location = new System.Drawing.Point(12, 30);
            this.txt_monthcalendar.Name = "txt_monthcalendar";
            this.txt_monthcalendar.Size = new System.Drawing.Size(100, 35);
            this.txt_monthcalendar.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(162, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Năm";
            // 
            // txt_yearcalendar
            // 
            this.txt_yearcalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_yearcalendar.Location = new System.Drawing.Point(162, 30);
            this.txt_yearcalendar.Name = "txt_yearcalendar";
            this.txt_yearcalendar.Size = new System.Drawing.Size(100, 35);
            this.txt_yearcalendar.TabIndex = 10;
            // 
            // btn_calendar
            // 
            this.btn_calendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_calendar.Location = new System.Drawing.Point(12, 75);
            this.btn_calendar.Name = "btn_calendar";
            this.btn_calendar.Size = new System.Drawing.Size(250, 50);
            this.btn_calendar.TabIndex = 12;
            this.btn_calendar.Text = "Lịch công tác";
            this.btn_calendar.UseVisualStyleBackColor = true;
            // 
            // btn_reload
            // 
            this.btn_reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_reload.Location = new System.Drawing.Point(12, 475);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(250, 50);
            this.btn_reload.TabIndex = 17;
            this.btn_reload.Text = "Tải lại";
            this.btn_reload.UseVisualStyleBackColor = true;
            // 
            // btn_addeditevent
            // 
            this.btn_addeditevent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addeditevent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_addeditevent.Location = new System.Drawing.Point(12, 395);
            this.btn_addeditevent.Name = "btn_addeditevent";
            this.btn_addeditevent.Size = new System.Drawing.Size(250, 50);
            this.btn_addeditevent.TabIndex = 16;
            this.btn_addeditevent.Text = "Sự kiện";
            this.btn_addeditevent.UseVisualStyleBackColor = true;
            // 
            // btn_accountmanagement
            // 
            this.btn_accountmanagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_accountmanagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_accountmanagement.Location = new System.Drawing.Point(12, 315);
            this.btn_accountmanagement.Name = "btn_accountmanagement";
            this.btn_accountmanagement.Size = new System.Drawing.Size(250, 50);
            this.btn_accountmanagement.TabIndex = 15;
            this.btn_accountmanagement.Text = "Tài khoản";
            this.btn_accountmanagement.UseVisualStyleBackColor = true;
            // 
            // btn_addeditsalary
            // 
            this.btn_addeditsalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addeditsalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_addeditsalary.Location = new System.Drawing.Point(12, 235);
            this.btn_addeditsalary.Name = "btn_addeditsalary";
            this.btn_addeditsalary.Size = new System.Drawing.Size(250, 50);
            this.btn_addeditsalary.TabIndex = 14;
            this.btn_addeditsalary.Text = "Lương";
            this.btn_addeditsalary.UseVisualStyleBackColor = true;
            // 
            // btn_addeditemployee
            // 
            this.btn_addeditemployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addeditemployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_addeditemployee.Location = new System.Drawing.Point(12, 155);
            this.btn_addeditemployee.Name = "btn_addeditemployee";
            this.btn_addeditemployee.Size = new System.Drawing.Size(250, 50);
            this.btn_addeditemployee.TabIndex = 13;
            this.btn_addeditemployee.Text = "Nhân viên";
            this.btn_addeditemployee.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 944);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_monthcalendar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_yearcalendar;
        private System.Windows.Forms.Button btn_calendar;
        private System.Windows.Forms.Button btn_reload;
        private System.Windows.Forms.Button btn_addeditevent;
        private System.Windows.Forms.Button btn_accountmanagement;
        private System.Windows.Forms.Button btn_addeditsalary;
        private System.Windows.Forms.Button btn_addeditemployee;
    }
}