using System.Windows.Forms;

namespace CSDL_ADO
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
            tbt_Name.ReadOnly = false;
        }
        // Tạo 1 phương thức chung để Load dữ liệu lên dataGriview theo cấu hình
        public void LoadDataToGridView(List<Sinhvien> sv)
        {
            // Xóa dữ liệu cũ để thêm dữ liệu mới
            dtg_Data.Rows.Clear();
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
            dtg_Data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Tự động bơm đầy vào view
        }

        private void tbt_Search_TextChanged(object sender, EventArgs e)
        {
            var data = services.SearchByName(tbt_Search.Text);
            LoadDataToGridView(data);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tbt_Major.Text = string.Empty;
            tbt_Name.Text = string.Empty;
            rdb_Female.Checked = false;
            rdb_Male.Checked = true;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string name = tbt_Name.Text;
            string dob = dtp_Dob.Value.ToString("yyyy-MM-dd");
            // Chuyển data từ định dạng Datetime sang string dạng yyyy-MM-dd (2022-11-11)
            string major = tbt_Major.Text;
            bool gtinh = rdb_Male.Checked;
            services.CreateSinhvien(name, dob, major, gtinh);
            LoadDataToGridView(services.GetAll());
        }

        private void dtg_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sự kiện khi chúng ta click vào 1 ô bất kì trên dataGridView sẽ load dữ liệu lên các control
            // Lấy vị trí click
            int index = e.RowIndex; // Lấy ra cái dòng
            var rowData = dtg_Data.Rows[index]; // Lấy tất cả dữ liệu của dòng mà có ô được click
            // Cell - 1 ô bất kì, Column - Cột bất kì,  Row - Dòng bất kì
            string ten = rowData.Cells[1].Value.ToString(); // Để ý sẽ thấy Cell[0] là cột số thứ tự
            DateTime dob = (DateTime)rowData.Cells[2].Value;
            string major = rowData.Cells[3].Value.ToString();
            bool gtinh = rowData.Cells[4].Value.ToString().Equals("Nam"); // So sánh dữ liệu hiển thị với Nam, nếu
            // là Nam thì true, Nữ thì False
            // Gán giá trị cho các control 
            tbt_Name.Text = ten;
            dtp_Dob.Value = dob;
            tbt_Major.Text = major;
            if (gtinh)
            {
                rdb_Male.Checked = true;
            }
            else
            {
                rdb_Female.Checked = true;
            }
            tbt_Name.ReadOnly = true; // Không cho sửa tên khi click vào 1 ô
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            services.XoaSinhvien(tbt_Name.Text);
            LoadDataToGridView(services.GetAll());
        }
    }
}