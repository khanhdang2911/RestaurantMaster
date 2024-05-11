using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace winform_project.DTOs
{
    public class SanPhamOrderDTO
    {
        [Key]
        [DisplayName("Mã sản phẩm")]
        public int Id { set; get; }
        [DisplayName("Tên sản phẩm")]
        public string TenSanPham { set; get; }
        [DisplayName("Số lượng")]
        public int soluong { set; get; }
        [DisplayName("Giá tiền")]
        public decimal GiaSanPham { set; get; }
        

    }
}
