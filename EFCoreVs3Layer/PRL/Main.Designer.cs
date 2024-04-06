namespace EFCoreVs3Layer.PRL
{
    partial class Main
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
            this.btn_Show = new System.Windows.Forms.Button();
            this.tbt_Search = new System.Windows.Forms.TextBox();
            this.dtg_data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_data)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Show
            // 
            this.btn_Show.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Show.Location = new System.Drawing.Point(30, 38);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(253, 45);
            this.btn_Show.TabIndex = 0;
            this.btn_Show.Text = "Hiển thị";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // tbt_Search
            // 
            this.tbt_Search.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_Search.Location = new System.Drawing.Point(428, 45);
            this.tbt_Search.Name = "tbt_Search";
            this.tbt_Search.Size = new System.Drawing.Size(632, 38);
            this.tbt_Search.TabIndex = 1;
            this.tbt_Search.TextChanged += new System.EventHandler(this.tbt_Search_TextChanged);
            // 
            // dtg_data
            // 
            this.dtg_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_data.Location = new System.Drawing.Point(36, 153);
            this.dtg_data.Name = "dtg_data";
            this.dtg_data.RowHeadersWidth = 51;
            this.dtg_data.RowTemplate.Height = 29;
            this.dtg_data.Size = new System.Drawing.Size(1024, 432);
            this.dtg_data.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 619);
            this.Controls.Add(this.dtg_data);
            this.Controls.Add(this.tbt_Search);
            this.Controls.Add(this.btn_Show);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Show;
        private TextBox tbt_Search;
        private DataGridView dtg_data;
    }
}