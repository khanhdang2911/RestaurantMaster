using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace winform_project
{
    [Table("Role")]
    public class Role
    {
        [Key]
        public int Id { set; get; }
        [DisplayName("Tên role")]
        public string TenRole { set; get; }
    }
}
