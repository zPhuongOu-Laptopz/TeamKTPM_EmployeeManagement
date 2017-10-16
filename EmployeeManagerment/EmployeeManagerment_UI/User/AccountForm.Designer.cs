namespace EmployeeManagerment_UI.User
{
    partial class AccountForm
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
            this.btn_addaccount = new System.Windows.Forms.Button();
            this.btn_deleteaccount = new System.Windows.Forms.Button();
            this.btn_editaccount = new System.Windows.Forms.Button();
            this.btn_reloadaccount = new System.Windows.Forms.Button();
            this.btn_backaccount = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grid_listaccount = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_department = new System.Windows.Forms.ComboBox();
            this.cbb_position = new System.Windows.Forms.ComboBox();
            this.cbb_firstname = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_accountname = new System.Windows.Forms.TextBox();
            this.txt_accountpassword = new System.Windows.Forms.TextBox();
            this.txt_accountlevel = new System.Windows.Forms.TextBox();
            this.cb_isactiveaccount = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_listaccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_addaccount
            // 
            this.btn_addaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addaccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_addaccount.Location = new System.Drawing.Point(3, 200);
            this.btn_addaccount.Name = "btn_addaccount";
            this.btn_addaccount.Size = new System.Drawing.Size(292, 77);
            this.btn_addaccount.TabIndex = 8;
            this.btn_addaccount.Text = "Thêm";
            this.btn_addaccount.UseVisualStyleBackColor = true;
            // 
            // btn_deleteaccount
            // 
            this.btn_deleteaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteaccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_deleteaccount.Location = new System.Drawing.Point(3, 273);
            this.btn_deleteaccount.Name = "btn_deleteaccount";
            this.btn_deleteaccount.Size = new System.Drawing.Size(292, 77);
            this.btn_deleteaccount.TabIndex = 9;
            this.btn_deleteaccount.Text = "Xóa";
            this.btn_deleteaccount.UseVisualStyleBackColor = true;
            // 
            // btn_editaccount
            // 
            this.btn_editaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editaccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_editaccount.Location = new System.Drawing.Point(3, 347);
            this.btn_editaccount.Name = "btn_editaccount";
            this.btn_editaccount.Size = new System.Drawing.Size(292, 77);
            this.btn_editaccount.TabIndex = 10;
            this.btn_editaccount.Text = "Sửa";
            this.btn_editaccount.UseVisualStyleBackColor = true;
            // 
            // btn_reloadaccount
            // 
            this.btn_reloadaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reloadaccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_reloadaccount.Location = new System.Drawing.Point(3, 420);
            this.btn_reloadaccount.Name = "btn_reloadaccount";
            this.btn_reloadaccount.Size = new System.Drawing.Size(292, 77);
            this.btn_reloadaccount.TabIndex = 11;
            this.btn_reloadaccount.Text = "Tải lại";
            this.btn_reloadaccount.UseVisualStyleBackColor = true;
            // 
            // btn_backaccount
            // 
            this.btn_backaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backaccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_backaccount.Location = new System.Drawing.Point(3, 491);
            this.btn_backaccount.Name = "btn_backaccount";
            this.btn_backaccount.Size = new System.Drawing.Size(292, 77);
            this.btn_backaccount.TabIndex = 12;
            this.btn_backaccount.Text = "Quay lại";
            this.btn_backaccount.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cb_isactiveaccount);
            this.panel1.Controls.Add(this.txt_accountlevel);
            this.panel1.Controls.Add(this.txt_accountpassword);
            this.panel1.Controls.Add(this.txt_accountname);
            this.panel1.Controls.Add(this.cbb_firstname);
            this.panel1.Controls.Add(this.cbb_position);
            this.panel1.Controls.Add(this.cbb_department);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.grid_listaccount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(301, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 742);
            this.panel1.TabIndex = 0;
            // 
            // grid_listaccount
            // 
            this.grid_listaccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_listaccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grid_listaccount.Location = new System.Drawing.Point(0, 331);
            this.grid_listaccount.Name = "grid_listaccount";
            this.grid_listaccount.RowTemplate.Height = 28;
            this.grid_listaccount.Size = new System.Drawing.Size(999, 411);
            this.grid_listaccount.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1300, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(63, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bộ phận:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(63, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chức vụ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(63, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhân viên:";
            // 
            // cbb_department
            // 
            this.cbb_department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_department.FormattingEnabled = true;
            this.cbb_department.Items.AddRange(new object[] {
            "Kế toán",
            "Bảo vệ",
            "Công nghệ thông tin",
            "Kinh doanh",
            "Nhân sự"});
            this.cbb_department.Location = new System.Drawing.Point(290, 12);
            this.cbb_department.Name = "cbb_department";
            this.cbb_department.Size = new System.Drawing.Size(220, 40);
            this.cbb_department.TabIndex = 1;
            // 
            // cbb_position
            // 
            this.cbb_position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_position.FormattingEnabled = true;
            this.cbb_position.Location = new System.Drawing.Point(290, 88);
            this.cbb_position.Name = "cbb_position";
            this.cbb_position.Size = new System.Drawing.Size(220, 40);
            this.cbb_position.TabIndex = 2;
            // 
            // cbb_firstname
            // 
            this.cbb_firstname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_firstname.FormattingEnabled = true;
            this.cbb_firstname.Location = new System.Drawing.Point(290, 166);
            this.cbb_firstname.Name = "cbb_firstname";
            this.cbb_firstname.Size = new System.Drawing.Size(220, 40);
            this.cbb_firstname.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(552, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tài khoản:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(552, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(552, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 32);
            this.label6.TabIndex = 3;
            this.label6.Text = "Cấp độ:";
            // 
            // txt_accountname
            // 
            this.txt_accountname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_accountname.Location = new System.Drawing.Point(783, 12);
            this.txt_accountname.Name = "txt_accountname";
            this.txt_accountname.Size = new System.Drawing.Size(181, 39);
            this.txt_accountname.TabIndex = 4;
            // 
            // txt_accountpassword
            // 
            this.txt_accountpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_accountpassword.Location = new System.Drawing.Point(783, 88);
            this.txt_accountpassword.Name = "txt_accountpassword";
            this.txt_accountpassword.Size = new System.Drawing.Size(181, 39);
            this.txt_accountpassword.TabIndex = 5;
            // 
            // txt_accountlevel
            // 
            this.txt_accountlevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_accountlevel.Location = new System.Drawing.Point(783, 166);
            this.txt_accountlevel.Name = "txt_accountlevel";
            this.txt_accountlevel.Size = new System.Drawing.Size(181, 39);
            this.txt_accountlevel.TabIndex = 6;
            // 
            // cb_isactiveaccount
            // 
            this.cb_isactiveaccount.AutoSize = true;
            this.cb_isactiveaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_isactiveaccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cb_isactiveaccount.Location = new System.Drawing.Point(552, 235);
            this.cb_isactiveaccount.Name = "cb_isactiveaccount";
            this.cb_isactiveaccount.Size = new System.Drawing.Size(169, 36);
            this.cb_isactiveaccount.TabIndex = 7;
            this.cb_isactiveaccount.Text = "Kích hoạt";
            this.cb_isactiveaccount.UseVisualStyleBackColor = true;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 942);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_backaccount);
            this.Controls.Add(this.btn_reloadaccount);
            this.Controls.Add(this.btn_editaccount);
            this.Controls.Add(this.btn_deleteaccount);
            this.Controls.Add(this.btn_addaccount);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_listaccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_addaccount;
        private System.Windows.Forms.Button btn_deleteaccount;
        private System.Windows.Forms.Button btn_editaccount;
        private System.Windows.Forms.Button btn_reloadaccount;
        private System.Windows.Forms.Button btn_backaccount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grid_listaccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_department;
        private System.Windows.Forms.ComboBox cbb_firstname;
        private System.Windows.Forms.ComboBox cbb_position;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_accountname;
        private System.Windows.Forms.TextBox txt_accountlevel;
        private System.Windows.Forms.TextBox txt_accountpassword;
        private System.Windows.Forms.CheckBox cb_isactiveaccount;
    }
}