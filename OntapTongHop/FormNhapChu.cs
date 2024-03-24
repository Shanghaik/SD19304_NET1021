using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OntapTongHop
{
    public partial class FormNhapChu : Form
    {
        public FormNhapChu()
        {
            InitializeComponent();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            // Khi ấn vào đây ta lưu dữ liệu vào file txt
            // Cho phép ta mở các thư mục vào tạo file mới
            // Tạo ra 1 biến để lưu dữ liệu lấy được từ textBox
            string textData = tbt_Nhap.Text;
            // Mở SaveFile Dialog để tạo mới và lưu file
            SaveFileDialog dialog = new SaveFileDialog();
            // Tạo bộ lọc để lọc file chỉ là txt
            dialog.Filter = "Tệp tin văn bản (*.txt)|*.txt";
            // Hiển thị hộp thoại
            dialog.ShowDialog();
            // Lấy đường dẫn tới file vừa tạo để thực hiện việc lưu dữ liệu
            string filePath = dialog.FileName;
            // Tạo 1 cửa sổ xác nhận xem bạn có muốn lưu file hay không?
            DialogResult result = MessageBox.Show("Bạn có muôn lưu trữ vào file không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) // nếu chọn yes thì thực hiện lưu vào file
            {
                // Lưu dữ liệu vào file có đường dẫn đã được lấy là filePath
                File.WriteAllText(filePath, textData);
                MessageBox.Show("Lưu thành công");
            }
            else MessageBox.Show("Tiếp tục nhập");
        }

        private void btn_Doc_Click(object sender, EventArgs e)
        {
            // Khi ấn vào đây ta đọc dữ liệu từ file txt
            // Cho phép ta mở các thư mục vào đọc file dược chọn từ các thư mục đó
            // cần sử dụng 1 OpenFileDialog để mở
            // mở OpenFileDialog
            OpenFileDialog dialog = new OpenFileDialog();
            // Tạo bộ lọc các loại file
            dialog.Title = "Please select a txt file to show";
            dialog.Filter = "Tệp tin văn bản (*.txt)|*.txt|Tất cả các tệp tin (*.*)|*.*"; // Lọc
            dialog.ShowDialog();
            //Lấy đường dẫn từ dialog đã chọn
            string filePath = dialog.FileName;
            // Đưa dữ liệu từ file txt đã chọn vào textBox
            tbt_Nhap.Text = File.ReadAllText(filePath);
            MessageBox.Show("Đọc thành công");
        }
    }
}
