namespace DocGhiObjXml
{
    public partial class Form1 : Form
    {
        Services services = new Services(); // Tạo 1 đối tượng services
        public Form1() // Cái này là constructor đấy các đại ca ạ
        {
            
            services = new Services(); // Khởi tạo trong constructor
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // Ghi
        private void btn_Write_Click(object sender, EventArgs e)
        {
            services.ReadFromXML(); // đọc trước dữ liệu từ file xml vào trong list đã
            bool gioitinh = false;
            if(rb_Male.Checked) gioitinh|= true;
            services.WriteToXML(tbt_Name.Text, dtp_DoB.Value, gioitinh);
            dataGridView1.DataSource = services.List;
        }
        // Đọc file
        private void btn_Read_Click(object sender, EventArgs e)
        {
            var data = services.ReadFromXML();
            if (data) // nếu đọc thành công
            {
                MessageBox.Show("đọc thành công");
                dataGridView1.DataSource = services.List;
            }
        }
    }
}