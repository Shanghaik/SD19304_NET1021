namespace Menu_DocGhiTxt
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thaoTácVớiFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ghiFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đọcFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thaoTácVớiFileẢnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đọcẢnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ghiẢnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbt_Soanthao = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thaoTácVớiFileToolStripMenuItem,
            this.thaoTácVớiFileẢnhToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1049, 39);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thaoTácVớiFileToolStripMenuItem
            // 
            this.thaoTácVớiFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ghiFileToolStripMenuItem,
            this.đọcFileToolStripMenuItem});
            this.thaoTácVớiFileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.thaoTácVớiFileToolStripMenuItem.Name = "thaoTácVớiFileToolStripMenuItem";
            this.thaoTácVớiFileToolStripMenuItem.Size = new System.Drawing.Size(236, 35);
            this.thaoTácVớiFileToolStripMenuItem.Text = "Thao tác với file txt";
            // 
            // ghiFileToolStripMenuItem
            // 
            this.ghiFileToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.ghiFileToolStripMenuItem.Name = "ghiFileToolStripMenuItem";
            this.ghiFileToolStripMenuItem.Size = new System.Drawing.Size(224, 36);
            this.ghiFileToolStripMenuItem.Text = "Đọc file";
            this.ghiFileToolStripMenuItem.Click += new System.EventHandler(this.ghiFileToolStripMenuItem_Click);
            
            // 
            // đọcFileToolStripMenuItem
            // 
            this.đọcFileToolStripMenuItem.Name = "đọcFileToolStripMenuItem";
            this.đọcFileToolStripMenuItem.Size = new System.Drawing.Size(224, 36);
            this.đọcFileToolStripMenuItem.Text = "Ghi file";
            this.đọcFileToolStripMenuItem.Click += new System.EventHandler(this.đọcFileToolStripMenuItem_Click);
            // 
            // thaoTácVớiFileẢnhToolStripMenuItem
            // 
            this.thaoTácVớiFileẢnhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đọcẢnhToolStripMenuItem,
            this.ghiẢnhToolStripMenuItem});
            this.thaoTácVớiFileẢnhToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.thaoTácVớiFileẢnhToolStripMenuItem.Name = "thaoTácVớiFileẢnhToolStripMenuItem";
            this.thaoTácVớiFileẢnhToolStripMenuItem.Size = new System.Drawing.Size(245, 35);
            this.thaoTácVớiFileẢnhToolStripMenuItem.Text = "Thao tác với file ảnh";
            // 
            // đọcẢnhToolStripMenuItem
            // 
            this.đọcẢnhToolStripMenuItem.Name = "đọcẢnhToolStripMenuItem";
            this.đọcẢnhToolStripMenuItem.Size = new System.Drawing.Size(190, 36);
            this.đọcẢnhToolStripMenuItem.Text = "Đọc ảnh";
            // 
            // ghiẢnhToolStripMenuItem
            // 
            this.ghiẢnhToolStripMenuItem.Name = "ghiẢnhToolStripMenuItem";
            this.ghiẢnhToolStripMenuItem.Size = new System.Drawing.Size(190, 36);
            this.ghiẢnhToolStripMenuItem.Text = "Ghi ảnh";
            // 
            // tbt_Soanthao
            // 
            this.tbt_Soanthao.Location = new System.Drawing.Point(29, 140);
            this.tbt_Soanthao.Multiline = true;
            this.tbt_Soanthao.Name = "tbt_Soanthao";
            this.tbt_Soanthao.Size = new System.Drawing.Size(994, 440);
            this.tbt_Soanthao.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 653);
            this.Controls.Add(this.tbt_Soanthao);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Chương trình Notpad fake";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem thaoTácVớiFileToolStripMenuItem;
        private ToolStripMenuItem ghiFileToolStripMenuItem;
        private ToolStripMenuItem đọcFileToolStripMenuItem;
        private TextBox tbt_Soanthao;
        private ToolStripMenuItem thaoTácVớiFileẢnhToolStripMenuItem;
        private ToolStripMenuItem đọcẢnhToolStripMenuItem;
        private ToolStripMenuItem ghiẢnhToolStripMenuItem;
    }
}