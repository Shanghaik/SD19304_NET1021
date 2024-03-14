namespace LamQuenVoiWinform
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            // Check điều kiện về username và password không rỗng
            if (tbt_Username.Text != "" && tbt_Password.Text != "")
            {
                // tạo 1 đối tượng formLogin ra
                frmHome home = new frmHome();
                // Hiển thị (show) đối tượng vừa tạo
                MessageBox.Show("Đăng nhập thành công");
                home.ShowDialog();
            }
            else
            {
                // Thông báo
                MessageBox.Show("Hãy nhập username và password");
            }
                
        }

        private void btn_Login_MouseHover(object sender, EventArgs e)
        {
            // Sự kiện khi di chuột vào nút này
            // Sửa màu nền thành màu xanh lam nhạt
            btn_Login.BackColor = Color.LightBlue;
        }

        private void btn_Login_MouseLeave(object sender, EventArgs e)
        {
            // Sự kiện khi di chuột ra khỏi nút này
            // Sửa màu nền thành màu vàng gold
            btn_Login.BackColor = Color.Gold;
        }
    }
}