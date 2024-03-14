namespace LamQuenVoiWinform
{
    partial class frm_Login
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
            this.btn_Login = new System.Windows.Forms.Button();
            this.tbt_Username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Robot = new System.Windows.Forms.CheckBox();
            this.tbt_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Gold;
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Login.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_Login.Location = new System.Drawing.Point(231, 260);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(260, 55);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Đăng nhập";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            this.btn_Login.MouseLeave += new System.EventHandler(this.btn_Login_MouseLeave);
            this.btn_Login.MouseHover += new System.EventHandler(this.btn_Login_MouseHover);
            // 
            // tbt_Username
            // 
            this.tbt_Username.Location = new System.Drawing.Point(231, 50);
            this.tbt_Username.Name = "tbt_Username";
            this.tbt_Username.PlaceholderText = "Hãy nhập username";
            this.tbt_Username.Size = new System.Drawing.Size(425, 27);
            this.tbt_Username.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // cb_Robot
            // 
            this.cb_Robot.AutoSize = true;
            this.cb_Robot.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.cb_Robot.Location = new System.Drawing.Point(232, 192);
            this.cb_Robot.Name = "cb_Robot";
            this.cb_Robot.Size = new System.Drawing.Size(271, 32);
            this.cb_Robot.TabIndex = 3;
            this.cb_Robot.Text = "Tôi không phải người máy";
            this.cb_Robot.UseVisualStyleBackColor = true;
            // 
            // tbt_Password
            // 
            this.tbt_Password.Location = new System.Drawing.Point(232, 114);
            this.tbt_Password.Name = "tbt_Password";
            this.tbt_Password.PasswordChar = '*';
            this.tbt_Password.PlaceholderText = "Hãy nhập password";
            this.tbt_Password.Size = new System.Drawing.Size(424, 27);
            this.tbt_Password.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(29, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 385);
            this.Controls.Add(this.tbt_Password);
            this.Controls.Add(this.cb_Robot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbt_Username);
            this.Controls.Add(this.btn_Login);
            this.Name = "frm_Login";
            this.Text = "Form đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Login;
        private TextBox tbt_Username;
        private Label label1;
        private CheckBox cb_Robot;
        private TextBox tbt_Password;
        private Label label2;
    }
}