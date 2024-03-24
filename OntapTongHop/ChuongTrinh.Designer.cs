namespace OntapTongHop
{
    partial class ChuongTrinh
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
            this.btn_Nhap = new System.Windows.Forms.Button();
            this.pn_Hienthi = new System.Windows.Forms.Panel();
            this.btn_NhapAnh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Nhap
            // 
            this.btn_Nhap.Location = new System.Drawing.Point(24, 38);
            this.btn_Nhap.Name = "btn_Nhap";
            this.btn_Nhap.Size = new System.Drawing.Size(233, 64);
            this.btn_Nhap.TabIndex = 0;
            this.btn_Nhap.Text = "Chức năng nhập";
            this.btn_Nhap.UseVisualStyleBackColor = true;
            this.btn_Nhap.Click += new System.EventHandler(this.btn_Nhap_Click);
            // 
            // pn_Hienthi
            // 
            this.pn_Hienthi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pn_Hienthi.Location = new System.Drawing.Point(24, 164);
            this.pn_Hienthi.Name = "pn_Hienthi";
            this.pn_Hienthi.Size = new System.Drawing.Size(750, 450);
            this.pn_Hienthi.TabIndex = 1;
            // 
            // btn_NhapAnh
            // 
            this.btn_NhapAnh.Location = new System.Drawing.Point(308, 38);
            this.btn_NhapAnh.Name = "btn_NhapAnh";
            this.btn_NhapAnh.Size = new System.Drawing.Size(224, 64);
            this.btn_NhapAnh.TabIndex = 2;
            this.btn_NhapAnh.Text = "Chức năng ảnh";
            this.btn_NhapAnh.UseVisualStyleBackColor = true;
            this.btn_NhapAnh.Click += new System.EventHandler(this.btn_NhapAnh_Click);
            // 
            // ChuongTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 641);
            this.Controls.Add(this.btn_NhapAnh);
            this.Controls.Add(this.pn_Hienthi);
            this.Controls.Add(this.btn_Nhap);
            this.Name = "ChuongTrinh";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Nhap;
        private Panel pn_Hienthi;
        private Button btn_NhapAnh;
    }
}