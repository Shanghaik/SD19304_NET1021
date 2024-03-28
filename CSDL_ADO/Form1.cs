﻿namespace CSDL_ADO
{
    public partial class Form1 : Form
    {
        Services services = new Services();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            List<Sinhvien> sinhviens = services.GetAll();
            LoadDataToGridView(sinhviens);
        }
        // Tạo 1 phương thức chung để Load dữ liệu lên dataGriview theo cấu hình
        public void LoadDataToGridView(List<Sinhvien> sv)
        {
            int stt = 1;
            // Xác định số lượng cột của datagridView
            dtg_Data.ColumnCount = 5; // Có 4 thuộc tính nhưng ta sẽ thêm 1 cột số thứ tự
            dtg_Data.Columns[0].HeaderText = "Số thứ tự"; // đặt tên hiển thị mới cho cột
            dtg_Data.Columns[1].HeaderText = "Tên";
            dtg_Data.Columns[2].HeaderText = "Ngày sinh";
            dtg_Data.Columns[3].HeaderText = "Ngành";
            dtg_Data.Columns[4].HeaderText = "Giới tính";
            // Truyền dữ liệu vào dataGridview
            foreach (var sinhvien in sv) // thêm từng bản ghi vào datagridView
            {
                string gt = sinhvien.Gtinh ? "Nam" : "Nữ";
                dtg_Data.Rows.Add(stt++, sinhvien.Name, sinhvien.Dob, sinhvien.Major, gt);
            }
        }
    }
}