using System.Runtime.Intrinsics.X86;

namespace CacControlBound
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ShowForm_Click(object sender, EventArgs e)
        { // Add 1 form vào Panel 
            panel1.Controls.Clear(); // Xóa hết các thành phần trên nó
            // 1 Form được hiểu là 1 control có level cao nhất (Top) để
            // chứa các control khác cho nên khi muốn add form vào trong panel thì
            // cần set nó không còn là top level nữa
            // Khi 1 control chứa các control khác đồng nghĩa với việc nó được
            // coi là parent của control đó
            if (rb_FormA.Checked)
            {
                FormA frmA = new FormA(); // tạo đối tượng form để add
                frmA.FormBorderStyle = FormBorderStyle.None; // Bỏ khung xung quanh form
                frmA.TopLevel = false; // không để nó là top level
                panel1.Controls.Add(frmA);
                frmA.Show();
            }
            else if (rb_FormB.Checked)
            {
                FormB frmB = new FormB(); // tạo đối tượng form để add
                frmB.FormBorderStyle = FormBorderStyle.None; // Bỏ khung xung quanh form
                frmB.TopLevel = false; // không để nó là top level
                panel1.Controls.Add(frmB);
                frmB.Show();
            }
            else MessageBox.Show("Hãy chọn form để thêm vào");
        }

        private void btn_ShowData_Click(object sender, EventArgs e)
        {
            // Fake 1 List data Obj để show lên datagridView
            List<Sinhvien> sinhviens = new List<Sinhvien>() {
                new Sinhvien() {ID = Guid.NewGuid(), Ten = "KhanhPG", Nganh = "UDPM", Tuoi = 21},
                new Sinhvien() {ID = Guid.NewGuid(), Ten = "DungNA", Nganh = "UDPM", Tuoi = 21},
                new Sinhvien() {ID = Guid.NewGuid(), Ten = "GiapVV", Nganh = "UDPM", Tuoi = 21},
                new Sinhvien() {ID = Guid.NewGuid(), Ten = "TienNH", Nganh = "UDPM", Tuoi = 21}
            };
            // Thêm thẳng dữ liệu và datagridView
            dtg1.DataSource = sinhviens;
        }
        // Khi click vào pictureBox thì sẽ hiển thị ra 1 OpenFileDialog cho phép chọn file
        private void ptb_Image_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog= new OpenFileDialog();
            dialog.Filter = "Files|*.jpg;*.jpeg;*.png;...";
            dialog.Title = "Please select an image file to encrypt.";
            dialog.ShowDialog();
            ptb_Image.SizeMode = PictureBoxSizeMode.StretchImage; // Chỉnh ảnh vừa khung
            var path = dialog.FileName; // Lấy đường dẫn tới ảnh được chọn
            ptb_Image.ImageLocation = path; // Gán đường dẫn cho pictureBox
        }
    }
    public class Sinhvien
    {
        public Sinhvien()
        {
        }
        public Sinhvien(Guid iD, string ten, string nganh, int tuoi)
        {
            ID = iD;
            Ten = ten;
            Nganh = nganh;
            Tuoi = tuoi;
        }
        public Guid ID { get; set; } // prop tab tab
        public string Ten { get; set; }
        public string Nganh { get; set; }
        public int Tuoi { get; set; }
    }
}