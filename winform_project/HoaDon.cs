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
    public class HoaDon
    {
        [Key]
        [DisplayName("Mã hóa đơn")]
        public int Id { set; get; }
        [DisplayName("Ngày bán")]
        public DateTime NgayBan { set; get; }
        [DisplayName("Tên bàn")]
        public string TenBan { set; get; }
        [DisplayName("Tổng tiền thanh toán")]
        public decimal tongTien { set; get; }
    }
}
