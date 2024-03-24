namespace OntapTongHop
{
    public partial class ChuongTrinh : Form
    {
        public ChuongTrinh() // Constructor
        {
            InitializeComponent(); // Khỏi tạo các control của form
        }

        private void btn_Nhap_Click(object sender, EventArgs e)
        {
            // Xóa hết các thành phần còn có trên Panel
            pn_Hienthi.Controls.Clear();
            // Khi click vào nút thì hiển thị form Nhập chữ vào trong panel
            // của form Chương trình
            // Tạo ra 1 đối tượng formNhapChu để thêm vào panel
            FormNhapChu nhap = new FormNhapChu();
            nhap.TopLevel = false; // Loại bỏ top level
            // Vì 1 form mặc định là top level- chỉ chứa các thành phần khác nhưng
            // Xóa khung, chỉ hiển thị phần thân form
            nhap.FormBorderStyle = FormBorderStyle.None;
            // bây giờ chúng ta lại muốn nó nằm trong một panel
            // Thêm form đó vào panel
            pn_Hienthi.Controls.Add(nhap);
            nhap.Show(); // Lưu ý chỉ dùng show chứ không phải showDialog
        }

        private void btn_NhapAnh_Click(object sender, EventArgs e)
        {
            // Xóa hết các thành phần còn có trên Panel
            pn_Hienthi.Controls.Clear();
            FormNhapAnh nhap = new FormNhapAnh();
            nhap.TopLevel = false; // Loại bỏ top level
            // Vì 1 form mặc định là top level- chỉ chứa các thành phần khác nhưng
            // bây giờ chúng ta lại muốn nó nằm trong một panel
            // Xóa khung, chỉ hiển thị phần thân form
            nhap.FormBorderStyle = FormBorderStyle.None;
            // Thêm form đó vào panel
            pn_Hienthi.Controls.Add(nhap);
            nhap.Show(); // Lưu ý chỉ dùng show chứ không phải showDialog
        }
    }
}