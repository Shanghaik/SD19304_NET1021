using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDL_ADO
{
    internal class Services
    {
        // Khai báo 1 chuỗi Connectionstring để thực hiện liên kết với CSDL
        string connectionString;
        public Services()
        {
            connectionString = @"Data Source=SHANGHAIK;Initial Catalog=ADO_SD19304;Integrated Security=True";
        }
        //Các phương thức
        // 1. Đọc data từ CSDL
        public List<Sinhvien> GetAll()
        {
            List<Sinhvien> list = new List<Sinhvien>();
            // Tạo 1 dataTable để lưu trữ dữ liệu lấy được từ SQL
            DataTable data = new DataTable();
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open(); // Mở kết nối với SQL
                string query = "select * from Sinhvien";
                // Thực hiện truy vấn thông qua kết nối từ connectionString
                SqlCommand command = new SqlCommand(query, con);
                // Tạo ra 1 adapter để có thể chứa tạm thời dữ liệu lấy được
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                // Đổ dữ liệu vừa thu được vào trong DataTable
                adapter.Fill(data);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message); // Hiển thị lỗi nếu có
            }
            finally
            {
                con.Close(); // Dù có ra sao đi chăng nữa, thì kết nối vẫn cần đóng
            }
            foreach (DataRow row in data.Rows)
            {
                Sinhvien sv = new Sinhvien
                {
                    Name = row["ten"].ToString(),
                    Dob = Convert.ToDateTime(row["dob"].ToString()),
                    Major = row["major"].ToString(),
                    Gtinh = row["gtinh"].ToString().ToLower().Equals("true")
                    // Thêm các trường khác tương ứng
                };
                list.Add(sv);
            }
            return list;
        }
        // 2. Ghi data vào CSDL
        public void CreateSinhvien(string name, string dob, string major, bool gtinh)
        {
            // 4 tham số truyền vào phương thức sẽ lấy dữ liệu từ form
            // (các textbox, datetimePicker và radioButton
            SqlConnection con = new SqlConnection(connectionString);
            int gt = gtinh ? 1 : 0;
            string query = $"Insert into Sinhvien values (N'{name}', '{dob}', N'{major}', {gt})";
            SqlCommand command = new SqlCommand(query, con);
            try
            {
                con.Open(); // Mở kết nối
                command.ExecuteReader(); // Chạy câu truy vấn
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally { 
                con.Close(); 
            }
        }
        // 3. Sửa data trong CSDL
        public void SuaSinhVien(string name, string dob, string major, bool gtinh)
        {
            // 4 tham số truyền vào phương thức sẽ lấy dữ liệu từ form
            // (các textbox, datetimePicker và radioButton
            SqlConnection con = new SqlConnection(connectionString);
            int gt = gtinh ? 1 : 0;
            string query = $"Update Sinhvien set major = N'{major}', dob = '{dob}', gtinh = {gt} " +
                $"where ten = N'{name}'";
            SqlCommand command = new SqlCommand(query, con);
            try
            {
                con.Open(); // Mở kết nối
                command.ExecuteReader(); // Chạy câu truy vấn
                MessageBox.Show("Sửa thành công");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
        }
        // 4. Xóa data
        public void XoaSinhvien(string name)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string query = $"delete from Sinhvien where ten = N'{name}'"; // Tạo truy vấn xóa
            SqlCommand command = new SqlCommand(query, con);
            try
            {
                con.Open();
                int count = command.ExecuteNonQuery(); // Trả về số dòng được xóa (affected)
                MessageBox.Show($"Đã xóa {count} bản ghi");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally { 
                con.Close(); 
            }
        }
        // 5. Tìm kiếm
        public List<Sinhvien> SearchByName(string name)
        {
            var allData = GetAll(); // Lấy hết danh sách sinh viên ra đã
            List<Sinhvien> search = new List<Sinhvien>();
            foreach (var item in allData)
            {
                if (item.Name.Contains(name)) // Nếu tên có chữ chuỗi nhập vào thì thêm vào danh sách trả về
                {
                    search.Add(item);
                }
            }
            return search;
        }

    }
}
