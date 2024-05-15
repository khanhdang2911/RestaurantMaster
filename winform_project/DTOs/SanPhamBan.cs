using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform_project
{
    public class SanPhamBan
    {
        public int BanId { set; get; }
        public int SanPhamId { set; get; }
        [DisplayName("Số luọng")]
        public int Soluong { set; get; }
        public Ban Ban { set; get; }
        public SanPham SanPham { set; get; }
    }
}
