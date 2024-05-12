using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform_project.DTOs
{
    public class DanhMucDTO
    {
        [Key]
        [DisplayName("Mã danh mục")]
        public int Id { set; get; }
        [DisplayName("Tên danh mục")]
        public string TenDanhMuc { set; get; }
    }
}
