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
    public partial class QuanLiHoaDon_form : Form
    {
        private readonly AppDbContext _context;
        public QuanLiHoaDon_form()
        {
            InitializeComponent();
            _context = DependencyContainer.Resolve<AppDbContext>();
        }
        public void LoadData()
        {
            dtg_listHoaDon.DataSource = _context.HoaDon.ToList();
            var currentRow = dtg_listHoaDon.CurrentRow;
            if(currentRow!=null)
            {
                txt_ngayban.Text = currentRow.Cells[1].Value.ToString();
                txt_tenban.Text = currentRow.Cells[2].Value.ToString();
                txt_tongtien.Text= currentRow.Cells[3].Value.ToString();
            }
            
        }
        private void QuanLiHoaDon_form_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_xoaNhanVien_Click(object sender, EventArgs e)
        {
            var currentRow = dtg_listHoaDon.CurrentRow;
            if (currentRow != null)
            {
                int idHoaDon = int.Parse(currentRow.Cells[0].Value.ToString());
                var hoaDon = _context.HoaDon.Find(idHoaDon);
                _context.HoaDon.Remove(hoaDon);
                _context.SaveChanges();
                MessageBox.Show("Xóa thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtg_listHoaDon.DataSource = null;
                LoadData();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn cần xóa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtg_listHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var currentRow = dtg_listHoaDon.CurrentRow;
            if (currentRow != null)
            {
                txt_ngayban.Text = currentRow.Cells[1].Value.ToString();
                txt_tenban.Text = currentRow.Cells[2].Value.ToString();
                txt_tongtien.Text = currentRow.Cells[3].Value.ToString();
            }
        }
    }
}
