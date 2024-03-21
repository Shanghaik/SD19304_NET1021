using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace DocGhiObjXml
{
    public class Services
    {
        // Cần 1 List để lưu danh sách các đối tượng đọc được từ file xml
        List<Human> list;
        // Cần 1 đường dẫn đến file
        string path = @"C:\Users\Acer\source\repos\SD19304_NET1021\DocGhiObjXml\human.xml";
        internal List<Human> List { get => list; set => list = value; }

        // Constructor để thực hiện khởi tạo Services
        public Services()
        {
            List = new List<Human>();
        }
        // Các phương thức để thực hiện các việc đó
        public bool WriteToXML(string name, DateTime doB, bool gioitinh) // Ghi vào file
        {
            // Tạo ra 1 đối tượng mới từ dữ liệu nhập vào trên form và truyền vào phương thức
            Human hm = new Human() { Ten = name, NamSinh = doB, GioiTinh = gioitinh };
            // Thêm đối tượng đó vào danh sách
            List.Add(hm);
            if (File.Exists(path)) // Kiểm tra đường dẫn có tồn tại hay không
            {
                try
                {
                    // Ghi lại danh sách đó vào file xml
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Human>)); // typeof để nhận biết kiểu dữ liệu
                    using (TextWriter writer = new StreamWriter(path))
                    {
                        serializer.Serialize(writer, List); // chuyển đổi từ list về dạng dữ liệu XML
                    }
                    return true; // trả về khi ghi thành công
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message); // Hiển thị ra lối nếu có
                    return false;
                }
            }
            else return false;  // khi file không tồn tại        
        }
        public bool ReadFromXML() // Đọc từ file
        {
            try // try tab tab
            {
                // từ đường dẫn có sẵn ta đọc dữ liệu từ file xml sang dạng list đối tượng
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Human>));
                using (XmlReader reader = new XmlTextReader(path))
                {
                    List = (List<Human>)xmlSerializer.Deserialize(reader);
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public List<Human> SearchByName(string name)
        {
            // Cú pháp linq để thực hiện việc lấy ra danh sách các Human mà tên có chứa chuỗi truyền vào
            return List.Where(p => p.Ten.Contains(name)).ToList();
        }
    }
}
