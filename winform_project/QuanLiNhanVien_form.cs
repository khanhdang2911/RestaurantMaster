using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_project
{
    public partial class QuanLiNhanVien_form : Form
    {
        private readonly AppDbContext _context;

        public QuanLiNhanVien_form()
        {
            InitializeComponent();
            _context= DependencyContainer.Resolve<AppDbContext>();
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {

        }

        private void list_nhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }
    }
}
