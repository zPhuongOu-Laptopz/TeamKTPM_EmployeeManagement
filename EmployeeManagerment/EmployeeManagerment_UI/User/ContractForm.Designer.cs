namespace EmployeeManagerment_UI.User
{
    partial class ContractForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtp_signdate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_enddate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_startdate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_payforms = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_contracttype = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbb_position = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_department = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_firstname = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_contractdescription = new System.Windows.Forms.TabPage();
            this.rtxt_contractdescription = new System.Windows.Forms.RichTextBox();
            this.grid_listcontract = new System.Windows.Forms.DataGridView();
            this.btn_addcontract = new System.Windows.Forms.Button();
            this.btn_deletecontract = new System.Windows.Forms.Button();
            this.btn_editcontract = new System.Windows.Forms.Button();
            this.btn_reloadcontract = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_contractdescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_listcontract)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1268, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtp_signdate);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dtp_enddate);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dtp_startdate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_payforms);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_contracttype);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbb_position);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbb_department);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbb_firstname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(287, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 596);
            this.panel1.TabIndex = 1;
            // 
            // dtp_signdate
            // 
            this.dtp_signdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_signdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_signdate.Location = new System.Drawing.Point(751, 227);
            this.dtp_signdate.Name = "dtp_signdate";
            this.dtp_signdate.Size = new System.Drawing.Size(220, 39);
            this.dtp_signdate.TabIndex = 8;
            this.dtp_signdate.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(524, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 32);
            this.label8.TabIndex = 17;
            this.label8.Text = "Ngày ký:";
            // 
            // dtp_enddate
            // 
            this.dtp_enddate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_enddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_enddate.Location = new System.Drawing.Point(751, 157);
            this.dtp_enddate.Name = "dtp_enddate";
            this.dtp_enddate.Size = new System.Drawing.Size(220, 39);
            this.dtp_enddate.TabIndex = 7;
            this.dtp_enddate.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(524, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 32);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ngày kết thúc:";
            // 
            // dtp_startdate
            // 
            this.dtp_startdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_startdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_startdate.Location = new System.Drawing.Point(751, 87);
            this.dtp_startdate.Name = "dtp_startdate";
            this.dtp_startdate.Size = new System.Drawing.Size(220, 39);
            this.dtp_startdate.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(524, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 32);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ngày bắt đầu:";
            // 
            // txt_payforms
            // 
            this.txt_payforms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_payforms.Location = new System.Drawing.Point(751, 17);
            this.txt_payforms.Name = "txt_payforms";
            this.txt_payforms.Size = new System.Drawing.Size(220, 39);
            this.txt_payforms.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(524, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Thanh toán:";
            // 
            // txt_contracttype
            // 
            this.txt_contracttype.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contracttype.Location = new System.Drawing.Point(262, 227);
            this.txt_contracttype.Name = "txt_contracttype";
            this.txt_contracttype.Size = new System.Drawing.Size(220, 39);
            this.txt_contracttype.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(35, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Loại hợp đồng:";
            // 
            // cbb_position
            // 
            this.cbb_position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_position.FormattingEnabled = true;
            this.cbb_position.Items.AddRange(new object[] {
            "Trưởng phòng",
            "Nhân viên"});
            this.cbb_position.Location = new System.Drawing.Point(262, 157);
            this.cbb_position.Name = "cbb_position";
            this.cbb_position.Size = new System.Drawing.Size(220, 40);
            this.cbb_position.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(35, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Chức vụ:";
            // 
            // cbb_department
            // 
            this.cbb_department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_department.FormattingEnabled = true;
            this.cbb_department.Items.AddRange(new object[] {
            "Nhân sự",
            "Kinh doanh",
            "Kế toán",
            "Tài vụ",
            "IT"});
            this.cbb_department.Location = new System.Drawing.Point(262, 87);
            this.cbb_department.Name = "cbb_department";
            this.cbb_department.Size = new System.Drawing.Size(220, 40);
            this.cbb_department.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(35, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bộ phận:";
            // 
            // cbb_firstname
            // 
            this.cbb_firstname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_firstname.FormattingEnabled = true;
            this.cbb_firstname.Location = new System.Drawing.Point(262, 17);
            this.cbb_firstname.Name = "cbb_firstname";
            this.cbb_firstname.Size = new System.Drawing.Size(220, 40);
            this.cbb_firstname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(35, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhân viên:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_contractdescription);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 421);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(981, 175);
            this.tabControl1.TabIndex = 22;
            // 
            // tab_contractdescription
            // 
            this.tab_contractdescription.Controls.Add(this.rtxt_contractdescription);
            this.tab_contractdescription.Location = new System.Drawing.Point(4, 41);
            this.tab_contractdescription.Name = "tab_contractdescription";
            this.tab_contractdescription.Size = new System.Drawing.Size(973, 130);
            this.tab_contractdescription.TabIndex = 0;
            this.tab_contractdescription.Text = "Mô tả";
            this.tab_contractdescription.UseVisualStyleBackColor = true;
            // 
            // rtxt_contractdescription
            // 
            this.rtxt_contractdescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxt_contractdescription.Location = new System.Drawing.Point(0, 0);
            this.rtxt_contractdescription.Name = "rtxt_contractdescription";
            this.rtxt_contractdescription.Size = new System.Drawing.Size(973, 130);
            this.rtxt_contractdescription.TabIndex = 9;
            this.rtxt_contractdescription.Text = "";
            // 
            // grid_listcontract
            // 
            this.grid_listcontract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_listcontract.Dock = System.Windows.Forms.DockStyle.Top;
            this.grid_listcontract.Location = new System.Drawing.Point(0, 200);
            this.grid_listcontract.Name = "grid_listcontract";
            this.grid_listcontract.RowTemplate.Height = 28;
            this.grid_listcontract.Size = new System.Drawing.Size(287, 200);
            this.grid_listcontract.TabIndex = 0;
            // 
            // btn_addcontract
            // 
            this.btn_addcontract.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addcontract.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_addcontract.Location = new System.Drawing.Point(0, 398);
            this.btn_addcontract.Name = "btn_addcontract";
            this.btn_addcontract.Size = new System.Drawing.Size(286, 77);
            this.btn_addcontract.TabIndex = 10;
            this.btn_addcontract.Text = "Thêm";
            this.btn_addcontract.UseVisualStyleBackColor = true;
            // 
            // btn_deletecontract
            // 
            this.btn_deletecontract.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletecontract.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_deletecontract.Location = new System.Drawing.Point(0, 470);
            this.btn_deletecontract.Name = "btn_deletecontract";
            this.btn_deletecontract.Size = new System.Drawing.Size(286, 77);
            this.btn_deletecontract.TabIndex = 11;
            this.btn_deletecontract.Text = "Xóa";
            this.btn_deletecontract.UseVisualStyleBackColor = true;
            // 
            // btn_editcontract
            // 
            this.btn_editcontract.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editcontract.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_editcontract.Location = new System.Drawing.Point(0, 543);
            this.btn_editcontract.Name = "btn_editcontract";
            this.btn_editcontract.Size = new System.Drawing.Size(286, 77);
            this.btn_editcontract.TabIndex = 12;
            this.btn_editcontract.Text = "Sửa";
            this.btn_editcontract.UseVisualStyleBackColor = true;
            // 
            // btn_reloadcontract
            // 
            this.btn_reloadcontract.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reloadcontract.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_reloadcontract.Location = new System.Drawing.Point(0, 613);
            this.btn_reloadcontract.Name = "btn_reloadcontract";
            this.btn_reloadcontract.Size = new System.Drawing.Size(286, 77);
            this.btn_reloadcontract.TabIndex = 13;
            this.btn_reloadcontract.Text = "Tải lại";
            this.btn_reloadcontract.UseVisualStyleBackColor = true;
            // 
            // ContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 796);
            this.Controls.Add(this.btn_reloadcontract);
            this.Controls.Add(this.btn_editcontract);
            this.Controls.Add(this.btn_deletecontract);
            this.Controls.Add(this.btn_addcontract);
            this.Controls.Add(this.grid_listcontract);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContractForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContractForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab_contractdescription.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_listcontract)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grid_listcontract;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_contractdescription;
        private System.Windows.Forms.RichTextBox rtxt_contractdescription;
        private System.Windows.Forms.Button btn_addcontract;
        private System.Windows.Forms.Button btn_deletecontract;
        private System.Windows.Forms.Button btn_editcontract;
        private System.Windows.Forms.Button btn_reloadcontract;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_firstname;
        private System.Windows.Forms.ComboBox cbb_position;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_department;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_contracttype;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_payforms;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_signdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_enddate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_startdate;
        private System.Windows.Forms.Label label6;
    }
}