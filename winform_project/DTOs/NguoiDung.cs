using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform_project
{
    [Table("NguoiDung")]
    public class NguoiDung
    {
        [Key]
        public int Id { set; get; }
        public string Username { set; get; }
        [DisplayName("Họ và tên")]
        public string HoTen { set; get; }
        public string Phone { set; get; }
        public string Password { set; get; }
        public int RoleId { set; get; }
        [ForeignKey("RoleId")]
        public Role Role { set; get; }

    }
}
