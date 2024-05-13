using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace winform_project
{
    [Table("DanhMuc")]
    public class DanhMuc
    {
        [Key]
        public int Id { set; get; }
        [DisplayName("Tên danh mục")]
        public string TenDanhMuc { set; get; }
        public List<SanPham> SanPhams { set; get; }

        public override string ToString()
        {
            return TenDanhMuc;
        }
    }
}
