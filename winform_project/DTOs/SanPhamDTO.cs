using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace winform_project.DTOs
{
    public class SanPhamDTO
    {
        [Key]
        [DisplayName("Mã sản phẩm")]
        public int Id { set; get; }
        [DisplayName("Tên sản phẩm")]
        public string TenSanPham { set; get; }
        [DisplayName("Giá tiền")]
        public decimal GiaSanPham { set; get; }
        [DisplayName("Tình trạng")]
        public bool TinhTrang { set; get; }
        [DisplayName("Danh mục")]
        public string DanhMuc { set; get; }
    }
}
