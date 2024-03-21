using System.Windows.Forms;

namespace Menu_DocGhiTxt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Phần này thực chất là đọc file nhưng do lúc tạo nhầm nhé =)))
        private void ghiFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Please select a txt file to show";
            dialog.Filter = "Tệp tin văn bản (*.txt)|*.txt|Tất cả các tệp tin (*.*)|*.*"; // Lọc
            dialog.ShowDialog();
            string path = dialog.FileName; // Lấy đường dẫn của file text đã được chọn
            // Lấy dữ liệu từ file Text
            string data = File.ReadAllText(path); // dựa vào đường dẫn, ta lấy được string
            // là tất cả các kí tự từ file txt
            tbt_Soanthao.Text = data;
            MessageBox.Show(path);
        }
        // Phần này thực chất là ghi file nhưng do lúc tạo nhầm nhé =)))
        private void đọcFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbt_Soanthao.Text.Trim()))// Kiểm tra textBox nhập vào có rỗng hay ko
            {
                MessageBox.Show("Bạn chưa nhập bất kì thứ gì, hãy nhập đã");
            }
            else
            {
                SaveFileDialog dialog = new SaveFileDialog(); // cửa sổ dialog cho phép lưu file
                dialog.Filter = "Tệp tin văn bản (*.txt)|*.txt"; // Lọc
                dialog.ShowDialog(); //Show lên
                                     // Tạo ra 1 file txt và lưu dữ liệu vào theo đường dẫn từ savefileDialog
                string path = dialog.FileName; // lấy đường dẫn
                // Tạo phần hỏi xem có muốn lưu file hay không
                DialogResult result = MessageBox.Show("Bạn có muốn lưu file không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Xử lý khi người dùng chọn Yes
                    File.WriteAllText(path, tbt_Soanthao.Text); //Ghi dữ liệu vào file, nếu file chưa tồn
                                                                // tại thì sẽ tự tạo ra 1 file mới theo đường dẫn mình có
                    MessageBox.Show(path);
                }
                else
                {
                    // Xử lý khi người dùng chọn No hoặc đóng MessageBox
                    Console.WriteLine("Bạn chưa muốn lưu file");
                }
            }     
        }


    }
}