namespace ChuongTrinhMayTinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool CheckInputData()
        {
            double check = 0;
            // Cố gắng ép kiểu dữ liệu từ TextBox nhập A, nếu được thì trả về true, sai thì trả về false
            bool checkA = Double.TryParse(tbt_A.Text, out check);// => Kết quả thu được sẽ lưu vào check
            // Cố gắng ép kiểu dữ liệu từ TextBox nhập B, nếu được thì trả về true, sai thì trả về false
            bool checkB = Double.TryParse(tbt_B.Text, out check);
            return checkA && checkB;
            // Khi cả A và B đều là Double thì checkA && checkB là true && true => true
            // Khi 1 trong 2 A hoặc B không là Double thì checkA && checkB là true && false => false
            // Khi cả A và B không là Double thì checkA && checkB là false && false => false
        }
        public void TinhToan()
        {
            if (CheckInputData())
            {
                double a = Convert.ToDouble(tbt_A.Text);
                double b = Convert.ToDouble(tbt_B.Text);
                if (rbt_Cong.Checked)
                {
                    lb_Ketqua.Text = a + b + "";
                }
                else if (rbt_Tru.Checked)
                {
                    lb_Ketqua.Text = a - b + "";
                }
                else if (rbt_Nhan.Checked)
                {
                    lb_Ketqua.Text = a * b + "";
                }
                else if (rbt_Chia.Checked)
                {
                    if (b == 0) MessageBox.Show("Không thể chia cho 0");
                    else lb_Ketqua.Text = a / b + "";
                }
                else MessageBox.Show("Hãy chọn phép tính");
            }
            else
            {
                MessageBox.Show("Dữ liệu lỗi lòi");
            }
        }
        private void btn_TinhToan_Click(object sender, EventArgs e)
        {
            TinhToan();
        }
        // Sự kiện Text Change cho phép thực thi các câu lệnh khi chúng ta tác động lên dữ liệu của TextBox
        private void tbt_A_TextChanged(object sender, EventArgs e)
        {
            if(tbt_A.Text.Length > 0 && tbt_B.Text.Length > 0) {
                TinhToan();
            }
        }

        private void tbt_B_TextChanged(object sender, EventArgs e)
        {
            if (tbt_A.Text.Length > 0 && tbt_B.Text.Length > 0)
            {
                TinhToan();
            }
        }
    }
}