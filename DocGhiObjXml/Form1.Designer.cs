namespace DocGhiObjXml
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grb_Chucnang = new System.Windows.Forms.GroupBox();
            this.tbt_Search = new System.Windows.Forms.TextBox();
            this.btn_Write = new System.Windows.Forms.Button();
            this.btn_Read = new System.Windows.Forms.Button();
            this.grb_Data = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbt_Name = new System.Windows.Forms.TextBox();
            this.dtp_DoB = new System.Windows.Forms.DateTimePicker();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grb_Chucnang.SuspendLayout();
            this.grb_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_Chucnang
            // 
            this.grb_Chucnang.Controls.Add(this.label3);
            this.grb_Chucnang.Controls.Add(this.label2);
            this.grb_Chucnang.Controls.Add(this.label1);
            this.grb_Chucnang.Controls.Add(this.rb_Female);
            this.grb_Chucnang.Controls.Add(this.rb_Male);
            this.grb_Chucnang.Controls.Add(this.dtp_DoB);
            this.grb_Chucnang.Controls.Add(this.tbt_Name);
            this.grb_Chucnang.Controls.Add(this.tbt_Search);
            this.grb_Chucnang.Controls.Add(this.btn_Write);
            this.grb_Chucnang.Controls.Add(this.btn_Read);
            this.grb_Chucnang.Location = new System.Drawing.Point(24, 15);
            this.grb_Chucnang.Name = "grb_Chucnang";
            this.grb_Chucnang.Size = new System.Drawing.Size(916, 222);
            this.grb_Chucnang.TabIndex = 0;
            this.grb_Chucnang.TabStop = false;
            this.grb_Chucnang.Text = "Chức năng";
            // 
            // tbt_Search
            // 
            this.tbt_Search.Location = new System.Drawing.Point(66, 177);
            this.tbt_Search.Name = "tbt_Search";
            this.tbt_Search.PlaceholderText = "Nhập vào đây để tìm kiếm";
            this.tbt_Search.Size = new System.Drawing.Size(767, 27);
            this.tbt_Search.TabIndex = 2;
            // 
            // btn_Write
            // 
            this.btn_Write.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Write.Location = new System.Drawing.Point(66, 95);
            this.btn_Write.Name = "btn_Write";
            this.btn_Write.Size = new System.Drawing.Size(233, 52);
            this.btn_Write.TabIndex = 1;
            this.btn_Write.Text = "Ghi XML";
            this.btn_Write.UseVisualStyleBackColor = true;
            this.btn_Write.Click += new System.EventHandler(this.btn_Write_Click);
            // 
            // btn_Read
            // 
            this.btn_Read.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Read.Location = new System.Drawing.Point(66, 26);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Size = new System.Drawing.Size(233, 52);
            this.btn_Read.TabIndex = 0;
            this.btn_Read.Text = "Đọc XML";
            this.btn_Read.UseVisualStyleBackColor = true;
            this.btn_Read.Click += new System.EventHandler(this.btn_Read_Click);
            // 
            // grb_Data
            // 
            this.grb_Data.Controls.Add(this.dataGridView1);
            this.grb_Data.Location = new System.Drawing.Point(24, 267);
            this.grb_Data.Name = "grb_Data";
            this.grb_Data.Size = new System.Drawing.Size(916, 396);
            this.grb_Data.TabIndex = 1;
            this.grb_Data.TabStop = false;
            this.grb_Data.Text = "Dữ liệu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(851, 328);
            this.dataGridView1.TabIndex = 0;
            // 
            // tbt_Name
            // 
            this.tbt_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbt_Name.Location = new System.Drawing.Point(474, 26);
            this.tbt_Name.Name = "tbt_Name";
            this.tbt_Name.PlaceholderText = "Hãy nhập tên";
            this.tbt_Name.Size = new System.Drawing.Size(359, 31);
            this.tbt_Name.TabIndex = 3;
            // 
            // dtp_DoB
            // 
            this.dtp_DoB.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtp_DoB.Location = new System.Drawing.Point(474, 78);
            this.dtp_DoB.Name = "dtp_DoB";
            this.dtp_DoB.Size = new System.Drawing.Size(358, 31);
            this.dtp_DoB.TabIndex = 4;
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb_Male.Location = new System.Drawing.Point(474, 123);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(72, 29);
            this.rb_Male.TabIndex = 5;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Nam";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb_Female.Location = new System.Drawing.Point(652, 123);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(58, 29);
            this.rb_Female.TabIndex = 6;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Nữ";
            this.rb_Female.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(361, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(361, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ngày sinh";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(361, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Giới tính";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 675);
            this.Controls.Add(this.grb_Data);
            this.Controls.Add(this.grb_Chucnang);
            this.Name = "Form1";
            this.Text = "Form đọc ghi file xml";
            this.grb_Chucnang.ResumeLayout(false);
            this.grb_Chucnang.PerformLayout();
            this.grb_Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grb_Chucnang;
        private TextBox tbt_Search;
        private Button btn_Write;
        private Button btn_Read;
        private GroupBox grb_Data;
        private DataGridView dataGridView1;
        private Label label1;
        private RadioButton rb_Female;
        private RadioButton rb_Male;
        private DateTimePicker dtp_DoB;
        private TextBox tbt_Name;
        private Label label3;
        private Label label2;
    }
}