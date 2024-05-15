using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform_project
{
    [Table("SanPham")]
    public class SanPham
    {
        [Key]
        public int Id { set; get; }
        [DisplayName("Tên sản phẩm")]
        public string TenSanPham { set; get; }
        [DisplayName("Giá tiền")]
        public decimal GiaSanPham { set; get; }
        [DisplayName("Tình trạng")]
        public bool TinhTrang { set; get; }
        public int DanhMucId { set; get; }
        [ForeignKey("DanhMucId")]
        
        public DanhMuc DanhMuc { set; get; }

        public List<SanPhamBan> sanPhamBans { get; set; }
    }
}
