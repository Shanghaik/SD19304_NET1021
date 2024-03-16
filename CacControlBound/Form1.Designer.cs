namespace CacControlBound
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
            this.grb_Hienthi = new System.Windows.Forms.GroupBox();
            this.dtg1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grb_ChucNang = new System.Windows.Forms.GroupBox();
            this.ptb_Image = new System.Windows.Forms.PictureBox();
            this.rb_FormB = new System.Windows.Forms.RadioButton();
            this.rb_FormA = new System.Windows.Forms.RadioButton();
            this.btn_ShowData = new System.Windows.Forms.Button();
            this.btn_ShowForm = new System.Windows.Forms.Button();
            this.grb_Hienthi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg1)).BeginInit();
            this.grb_ChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_Hienthi
            // 
            this.grb_Hienthi.Controls.Add(this.dtg1);
            this.grb_Hienthi.Controls.Add(this.panel1);
            this.grb_Hienthi.Location = new System.Drawing.Point(17, 16);
            this.grb_Hienthi.Name = "grb_Hienthi";
            this.grb_Hienthi.Size = new System.Drawing.Size(584, 631);
            this.grb_Hienthi.TabIndex = 0;
            this.grb_Hienthi.TabStop = false;
            this.grb_Hienthi.Text = "Hiển thị";
            // 
            // dtg1
            // 
            this.dtg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg1.Location = new System.Drawing.Point(13, 351);
            this.dtg1.Name = "dtg1";
            this.dtg1.RowHeadersWidth = 51;
            this.dtg1.RowTemplate.Height = 29;
            this.dtg1.Size = new System.Drawing.Size(553, 260);
            this.dtg1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 291);
            this.panel1.TabIndex = 0;
            // 
            // grb_ChucNang
            // 
            this.grb_ChucNang.Controls.Add(this.ptb_Image);
            this.grb_ChucNang.Controls.Add(this.rb_FormB);
            this.grb_ChucNang.Controls.Add(this.rb_FormA);
            this.grb_ChucNang.Controls.Add(this.btn_ShowData);
            this.grb_ChucNang.Controls.Add(this.btn_ShowForm);
            this.grb_ChucNang.Location = new System.Drawing.Point(631, 16);
            this.grb_ChucNang.Name = "grb_ChucNang";
            this.grb_ChucNang.Size = new System.Drawing.Size(372, 631);
            this.grb_ChucNang.TabIndex = 1;
            this.grb_ChucNang.TabStop = false;
            this.grb_ChucNang.Text = "Chức năng";
            // 
            // ptb_Image
            // 
            this.ptb_Image.BackColor = System.Drawing.Color.OrangeRed;
            this.ptb_Image.Location = new System.Drawing.Point(49, 386);
            this.ptb_Image.Name = "ptb_Image";
            this.ptb_Image.Size = new System.Drawing.Size(292, 225);
            this.ptb_Image.TabIndex = 4;
            this.ptb_Image.TabStop = false;
            this.ptb_Image.Click += new System.EventHandler(this.ptb_Image_Click);
            // 
            // rb_FormB
            // 
            this.rb_FormB.AutoSize = true;
            this.rb_FormB.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb_FormB.Location = new System.Drawing.Point(105, 130);
            this.rb_FormB.Name = "rb_FormB";
            this.rb_FormB.Size = new System.Drawing.Size(171, 35);
            this.rb_FormB.TabIndex = 3;
            this.rb_FormB.TabStop = true;
            this.rb_FormB.Text = "Show FormB";
            this.rb_FormB.UseVisualStyleBackColor = true;
            // 
            // rb_FormA
            // 
            this.rb_FormA.AutoSize = true;
            this.rb_FormA.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb_FormA.Location = new System.Drawing.Point(105, 66);
            this.rb_FormA.Name = "rb_FormA";
            this.rb_FormA.Size = new System.Drawing.Size(172, 35);
            this.rb_FormA.TabIndex = 2;
            this.rb_FormA.TabStop = true;
            this.rb_FormA.Text = "Show FormA";
            this.rb_FormA.UseVisualStyleBackColor = true;
            // 
            // btn_ShowData
            // 
            this.btn_ShowData.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ShowData.Location = new System.Drawing.Point(53, 306);
            this.btn_ShowData.Name = "btn_ShowData";
            this.btn_ShowData.Size = new System.Drawing.Size(288, 56);
            this.btn_ShowData.TabIndex = 1;
            this.btn_ShowData.Text = "ShowData";
            this.btn_ShowData.UseVisualStyleBackColor = true;
            this.btn_ShowData.Click += new System.EventHandler(this.btn_ShowData_Click);
            // 
            // btn_ShowForm
            // 
            this.btn_ShowForm.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ShowForm.Location = new System.Drawing.Point(53, 208);
            this.btn_ShowForm.Name = "btn_ShowForm";
            this.btn_ShowForm.Size = new System.Drawing.Size(288, 59);
            this.btn_ShowForm.TabIndex = 0;
            this.btn_ShowForm.Text = "ShowForm";
            this.btn_ShowForm.UseVisualStyleBackColor = true;
            this.btn_ShowForm.Click += new System.EventHandler(this.btn_ShowForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 659);
            this.Controls.Add(this.grb_ChucNang);
            this.Controls.Add(this.grb_Hienthi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grb_Hienthi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg1)).EndInit();
            this.grb_ChucNang.ResumeLayout(false);
            this.grb_ChucNang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grb_Hienthi;
        private DataGridView dtg1;
        private Panel panel1;
        private GroupBox grb_ChucNang;
        private RadioButton rb_FormB;
        private RadioButton rb_FormA;
        private Button btn_ShowData;
        private Button btn_ShowForm;
        private PictureBox ptb_Image;
    }
}