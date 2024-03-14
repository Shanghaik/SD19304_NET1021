namespace ChuongTrinhMayTinh
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
            this.tbt_A = new System.Windows.Forms.TextBox();
            this.tbt_B = new System.Windows.Forms.TextBox();
            this.rbt_Cong = new System.Windows.Forms.RadioButton();
            this.rbt_Tru = new System.Windows.Forms.RadioButton();
            this.rbt_Nhan = new System.Windows.Forms.RadioButton();
            this.rbt_Chia = new System.Windows.Forms.RadioButton();
            this.btn_TinhToan = new System.Windows.Forms.Button();
            this.lb_Ketqua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbt_A
            // 
            this.tbt_A.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_A.Location = new System.Drawing.Point(31, 24);
            this.tbt_A.Name = "tbt_A";
            this.tbt_A.Size = new System.Drawing.Size(570, 38);
            this.tbt_A.TabIndex = 0;
            this.tbt_A.TextChanged += new System.EventHandler(this.tbt_A_TextChanged);
            // 
            // tbt_B
            // 
            this.tbt_B.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_B.Location = new System.Drawing.Point(31, 109);
            this.tbt_B.Name = "tbt_B";
            this.tbt_B.Size = new System.Drawing.Size(570, 38);
            this.tbt_B.TabIndex = 1;
            this.tbt_B.TextChanged += new System.EventHandler(this.tbt_B_TextChanged);
            // 
            // rbt_Cong
            // 
            this.rbt_Cong.AutoSize = true;
            this.rbt_Cong.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbt_Cong.Location = new System.Drawing.Point(58, 195);
            this.rbt_Cong.Name = "rbt_Cong";
            this.rbt_Cong.Size = new System.Drawing.Size(75, 63);
            this.rbt_Cong.TabIndex = 2;
            this.rbt_Cong.TabStop = true;
            this.rbt_Cong.Text = "+";
            this.rbt_Cong.UseVisualStyleBackColor = true;
            // 
            // rbt_Tru
            // 
            this.rbt_Tru.AutoSize = true;
            this.rbt_Tru.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbt_Tru.Location = new System.Drawing.Point(201, 197);
            this.rbt_Tru.Name = "rbt_Tru";
            this.rbt_Tru.Size = new System.Drawing.Size(63, 63);
            this.rbt_Tru.TabIndex = 3;
            this.rbt_Tru.TabStop = true;
            this.rbt_Tru.Text = "-";
            this.rbt_Tru.UseVisualStyleBackColor = true;
            // 
            // rbt_Nhan
            // 
            this.rbt_Nhan.AutoSize = true;
            this.rbt_Nhan.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbt_Nhan.Location = new System.Drawing.Point(361, 197);
            this.rbt_Nhan.Name = "rbt_Nhan";
            this.rbt_Nhan.Size = new System.Drawing.Size(66, 63);
            this.rbt_Nhan.TabIndex = 4;
            this.rbt_Nhan.TabStop = true;
            this.rbt_Nhan.Text = "x";
            this.rbt_Nhan.UseVisualStyleBackColor = true;
            // 
            // rbt_Chia
            // 
            this.rbt_Chia.AutoSize = true;
            this.rbt_Chia.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbt_Chia.Location = new System.Drawing.Point(517, 197);
            this.rbt_Chia.Name = "rbt_Chia";
            this.rbt_Chia.Size = new System.Drawing.Size(63, 63);
            this.rbt_Chia.TabIndex = 5;
            this.rbt_Chia.TabStop = true;
            this.rbt_Chia.Text = "/";
            this.rbt_Chia.UseVisualStyleBackColor = true;
            // 
            // btn_TinhToan
            // 
            this.btn_TinhToan.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_TinhToan.Location = new System.Drawing.Point(28, 287);
            this.btn_TinhToan.Name = "btn_TinhToan";
            this.btn_TinhToan.Size = new System.Drawing.Size(237, 56);
            this.btn_TinhToan.TabIndex = 6;
            this.btn_TinhToan.Text = "Tính";
            this.btn_TinhToan.UseVisualStyleBackColor = true;
            this.btn_TinhToan.Click += new System.EventHandler(this.btn_TinhToan_Click);
            // 
            // lb_Ketqua
            // 
            this.lb_Ketqua.AutoSize = true;
            this.lb_Ketqua.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Ketqua.Location = new System.Drawing.Point(342, 300);
            this.lb_Ketqua.Name = "lb_Ketqua";
            this.lb_Ketqua.Size = new System.Drawing.Size(29, 31);
            this.lb_Ketqua.TabIndex = 7;
            this.lb_Ketqua.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 392);
            this.Controls.Add(this.lb_Ketqua);
            this.Controls.Add(this.btn_TinhToan);
            this.Controls.Add(this.rbt_Chia);
            this.Controls.Add(this.rbt_Nhan);
            this.Controls.Add(this.rbt_Tru);
            this.Controls.Add(this.rbt_Cong);
            this.Controls.Add(this.tbt_B);
            this.Controls.Add(this.tbt_A);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbt_A;
        private TextBox tbt_B;
        private RadioButton rbt_Cong;
        private RadioButton rbt_Tru;
        private RadioButton rbt_Nhan;
        private RadioButton rbt_Chia;
        private Button btn_TinhToan;
        private Label lb_Ketqua;
    }
}