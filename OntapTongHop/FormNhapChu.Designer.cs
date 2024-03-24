namespace OntapTongHop
{
    partial class FormNhapChu
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
            this.tbt_Nhap = new System.Windows.Forms.TextBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Doc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbt_Nhap
            // 
            this.tbt_Nhap.Location = new System.Drawing.Point(12, 89);
            this.tbt_Nhap.Multiline = true;
            this.tbt_Nhap.Name = "tbt_Nhap";
            this.tbt_Nhap.Size = new System.Drawing.Size(704, 300);
            this.tbt_Nhap.TabIndex = 0;
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(154, 12);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(121, 57);
            this.btn_Luu.TabIndex = 1;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Doc
            // 
            this.btn_Doc.Location = new System.Drawing.Point(444, 12);
            this.btn_Doc.Name = "btn_Doc";
            this.btn_Doc.Size = new System.Drawing.Size(112, 57);
            this.btn_Doc.TabIndex = 2;
            this.btn_Doc.Text = "Đọc";
            this.btn_Doc.UseVisualStyleBackColor = true;
            this.btn_Doc.Click += new System.EventHandler(this.btn_Doc_Click);
            // 
            // FormNhapChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(728, 401);
            this.Controls.Add(this.btn_Doc);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.tbt_Nhap);
            this.Name = "FormNhapChu";
            this.Text = "FormNhapChu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbt_Nhap;
        private Button btn_Luu;
        private Button btn_Doc;
    }
}