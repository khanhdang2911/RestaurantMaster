using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace winform_project.DTOs
{
    public class NguoiDungDTO
    {
        [Key]
        [DisplayName("Mã user")]
        public int Id { set; get; }
        [DisplayName("Tên người dùng")]
        public string Username { set; get; }
        [DisplayName("Số điện thoại")]
        public string Phone { set; get; }
        [DisplayName("Họ tên")]
        public string HoTen { set; get; }
        public string Password { set; get; } = "********";
        [DisplayName("Vai trò")]
        public string TenRole { set; get; }
    }
}
