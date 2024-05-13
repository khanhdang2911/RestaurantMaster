using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winform_project.DTOs;

namespace winform_project
{
    public partial class QuanLiDoAn_form : Form
    {
        private readonly AppDbContext _context;

        public QuanLiDoAn_form()
        {
            _context = DependencyContainer.Resolve<AppDbContext>();
            InitializeComponent();
            


        }


        private async Task LoadDataAsync()
        {

            var data = await _context.sanPhams.Select(c => new SanPhamDTO
            {
                Id = c.Id,
                TenSanPham = c.TenSanPham,
                GiaSanPham = c.GiaSanPham,
                TinhTrang = c.TinhTrang,
                DanhMuc = _context.danhMucs.Where(p => p.Id == c.DanhMucId).Select(p => p.TenDanhMuc).FirstOrDefault()
            })
            .ToListAsync();

            bunifuDataGridView1.DataSource = data;


            //Load vao danh muc o combobox
            cbb_danhmuc.DataSource = _context.danhMucs.ToList();
            cbb_danhmuc.DisplayMember = "TenDanhMuc"; // Hiển thị tên danh mục
            cbb_danhmuc.ValueMember = "Id"; // Lưu trữ Id của danh mục

            //

            var currenRow = bunifuDataGridView1.CurrentRow;

            if(currenRow!=null)
            {
                int Id = int.Parse(currenRow.Cells[0].Value.ToString());
                var sanpham = _context.sanPhams.Where(c => c.Id == Id).FirstOrDefault();
                txt_tenmon.Text = sanpham.TenSanPham;
                txt_giatien.Text = sanpham.GiaSanPham.ToString();
                cbb_danhmuc.SelectedItem = _context.danhMucs.Where(c => c.Id == sanpham.DanhMucId).FirstOrDefault();
                checkbox_tinhtrang.Checked = sanpham.TinhTrang;
            }



        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_luong_TextChanged(object sender, EventArgs e)
        {
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            

            var currenRow = bunifuDataGridView1.CurrentRow;

            int Id = int.Parse(currenRow.Cells[0].Value.ToString());
            var sanpham = _context.sanPhams.Where(c => c.Id == Id).FirstOrDefault();
            txt_tenmon.Text = sanpham.TenSanPham;
            txt_giatien.Text = sanpham.GiaSanPham.ToString();
            cbb_danhmuc.SelectedItem = _context.danhMucs.Where(c => c.Id == sanpham.DanhMucId).FirstOrDefault();
            checkbox_tinhtrang.Checked = sanpham.TinhTrang;

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btn_themMon_Click(object sender, EventArgs e)
        {
            string tensp = txt_tenmon.Text.ToString();
            string giasp = txt_giatien.Text.ToString();
            string danhmuc = cbb_danhmuc.SelectedItem.ToString();
            bool tinhtrang = checkbox_tinhtrang.Checked;
            var DanhMucDuocChon = cbb_danhmuc.SelectedValue;

            bool check = true;
            if(string.IsNullOrEmpty(tensp))
            {
                check = false;
            }
            if(string.IsNullOrEmpty(giasp))
            {
                check = false;
            }
            if(string.IsNullOrEmpty(danhmuc))
            {
                check = false;
            }
            if(DanhMucDuocChon==null)
            {
                check = false;
            }

            if (check==true)
            {
                int DanhMucId = Convert.ToInt32(DanhMucDuocChon);


                SanPham sanphamMoi = new SanPham();
                sanphamMoi.TenSanPham = tensp;
                sanphamMoi.GiaSanPham = decimal.Parse(giasp);
                sanphamMoi.DanhMucId = DanhMucId;
                sanphamMoi.TinhTrang = tinhtrang;
                _context.sanPhams.Add(sanphamMoi);
                _context.SaveChanges();
                bunifuDataGridView1.DataSource = null;
                LoadDataAsync();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin.", "Cảnh báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_xoamon_Click(object sender, EventArgs e)
        {
            var currenRow = bunifuDataGridView1.CurrentRow;

            if(currenRow==null)
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm muốn xóa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                int Id = int.Parse(currenRow.Cells[0].Value.ToString());
                //Kiem tra xem co ai order hay khong, neu co thi khong cho xoa
                if(_context.sanPhamBans.Any(c=>c.SanPhamId==Id))
                {
                    MessageBox.Show("Sản phẩm này đang có người order, nếu muốn xóa thì hãy thanh toán xog các bàn có món đó.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                

                else
                {
                    var sanpham = _context.sanPhams.Find(Id);
                    
                    _context.sanPhams.Remove(sanpham);
                    _context.SaveChanges();
                    bunifuDataGridView1.DataSource = null;
                    LoadDataAsync();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void QuanLiDoAn_form_Load(object sender, EventArgs e)
        {
            LoadDataAsync();
            cbb_danhmuc.KeyPress += cbb_danhmuc_KeyPress;
        }

        private void btn_suamon_Click(object sender, EventArgs e)
        {
            var currenRow = bunifuDataGridView1.CurrentRow;

            if (currenRow == null)
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm muốn sửa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                int Id = int.Parse(currenRow.Cells[0].Value.ToString());

                //Lay thong tin san phamhien tai
                string tensp = txt_tenmon.Text.ToString();
                string giasp = txt_giatien.Text.ToString();
                string danhmuc = cbb_danhmuc.SelectedItem.ToString();
                bool tinhtrang = checkbox_tinhtrang.Checked;
                var DanhMucDuocChon = cbb_danhmuc.SelectedValue;

                var sanpham = _context.sanPhams.Find(Id);
                if(sanpham.TenSanPham!=tensp || sanpham.GiaSanPham.ToString()!=giasp || sanpham.DanhMucId.ToString()!=DanhMucDuocChon.ToString() || sanpham.TinhTrang!=tinhtrang)
                {
                    _context.SaveChanges();
                    sanpham.TenSanPham = tensp;
                    sanpham.GiaSanPham = decimal.Parse(giasp);
                    sanpham.DanhMucId = int.Parse(DanhMucDuocChon.ToString());
                    sanpham.TinhTrang = tinhtrang;


                    _context.SaveChanges();
                    bunifuDataGridView1.DataSource = null;
                    LoadDataAsync();
                    MessageBox.Show("Sửa đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
              
            }
        }

        private void cbb_danhmuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
