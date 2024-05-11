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
    [Table("Ban")]
    public class Ban
    {
        [Key]
        [DisplayName("Mã bàn")]
        public int Id { get; set; }
        [DisplayName("Tên bàn")]
        public string TenBan { set; get; }
        [DisplayName("Tình trạng")]
        public bool TinhTrang { set; get; }

        public List<SanPhamBan> sanPhamBans { get; set; }

    }
}
