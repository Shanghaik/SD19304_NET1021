using EFCoreVs3Layer.BUS;
using EFCoreVs3Layer.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFCoreVs3Layer.PRL
{
    public partial class Main : Form
    {
        DongVatServices services = new DongVatServices();
        public Main()
        {
            InitializeComponent();
        }
        public void LoadDataToGridView(List<Dongvat> dongvats)
        {
            dtg_data.Rows.Clear(); 
            dtg_data.ColumnCount = 2; // Có 2 thuộc tính
            dtg_data.Columns[0].HeaderText = "Mã"; // đặt tên hiển thị mới cho cột
            dtg_data.Columns[1].HeaderText = "Tên";

            // Truyền dữ liệu vào dataGridview
            foreach (var dongvat in dongvats) // thêm từng bản ghi vào datagridView
            {         
                dtg_data.Rows.Add(dongvat.MaDv, dongvat.TenDv);
            }
            dtg_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 

        }
        private void btn_Show_Click(object sender, EventArgs e)
        {
            var dongvats = services.GetAllDV();
            LoadDataToGridView(dongvats);
        }
        private void tbt_Search_TextChanged(object sender, EventArgs e)
        {
            var dongvats = services.GetDVbyName(tbt_Search.Text);
            LoadDataToGridView(dongvats);
        }
    }
}
