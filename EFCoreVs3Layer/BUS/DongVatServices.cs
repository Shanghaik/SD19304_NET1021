using EFCoreVs3Layer.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreVs3Layer.BUS
{
    public class DongVatServices
    {
        EFCoreDemoContext _demoContext; // Khai báo
        public DongVatServices()
        {
            _demoContext = new EFCoreDemoContext(); // Khỏi tạo trong constructor
        }
        public List<Dongvat> GetAllDV()
        {
            return _demoContext.Dongvats.ToList(); // Trỏ tới DbSet<DongVat>
            // Phương thức ToList sẽ trả về 1 danh sách chứa tất cả các bản ghi trong bảng Dongvat
        }
        // Tìm kiếm động vật theo tên
        public List<Dongvat> GetDVbyName(string name)
        {
            // Sử dụng truy vấn LinQ để trả về danh sách các động vật tên có chứa chuỗi name
            return _demoContext.Dongvats.Where(p => p.TenDv.Contains(name)).ToList();
        }
    }
}
