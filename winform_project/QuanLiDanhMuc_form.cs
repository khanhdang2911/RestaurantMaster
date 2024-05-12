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
    public partial class QuanLiDanhMuc : Form
    {
        private readonly AppDbContext _context;
        public QuanLiDanhMuc()
        {
            InitializeComponent();
            _context = DependencyContainer.Resolve<AppDbContext>();
        }

        private void QuanLiDanhMuc_form_Load(object sender, EventArgs e)
        {
            LoadDataAsync();
        }
        private async Task LoadDataAsync()
        {

            var data = await _context.danhMucs.Select(c => new DanhMucDTO
            {
                Id = c.Id,
                TenDanhMuc = c.TenDanhMuc
               
            })
            .ToListAsync();

            list_danhmuc.DataSource = data;


            

            //

            var currenRow = list_danhmuc.CurrentRow;

            if (currenRow != null)
            {
                int Id = int.Parse(currenRow.Cells[0].Value.ToString());
                var danhMuc = _context.danhMucs.Where(c => c.Id == Id).FirstOrDefault();
                txt_tenDanhMuc.Text = danhMuc.TenDanhMuc;
            }



        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void list_danhmuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var currenRow = list_danhmuc.CurrentRow;

            if (currenRow != null)
            {
                int Id = int.Parse(currenRow.Cells[0].Value.ToString());
                
                txt_tenDanhMuc.Text = currenRow.Cells[1].Value.ToString();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_tenDanhMuc.Text = "";
        }

        private void btn_xoaNhanVien_Click(object sender, EventArgs e)
        {
            
            var currenRow = list_danhmuc.CurrentRow;
            if (currenRow == null)
            {
                MessageBox.Show("Bạn chưa chọn danh mục muốn xóa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else
            {
                int Id = int.Parse(currenRow.Cells[0].Value.ToString());
                var danhMuc = _context.danhMucs.Where(c => c.Id == Id).FirstOrDefault();
                txt_tenDanhMuc.Text = danhMuc.TenDanhMuc;
                //Kiem tra xem san pham cua danh muc nay co dc order hay khong
                var sanphamHienTaiTrongBan = _context.sanPhamBans.Include(c => c.SanPham).Select(c=>c.SanPham).ToList();
                if(sanphamHienTaiTrongBan.Any(c=>c.DanhMucId==Id))
                {
                    MessageBox.Show("Không thể xóa danh mục này, sản phẩm của danh mục này đang được order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Xoa
                    _context.danhMucs.Remove(danhMuc);
                    _context.SaveChanges();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    list_danhmuc.DataSource = null;
                    LoadDataAsync();
                }

            }
        }

        private void btn_themDanhMuc_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txt_tenDanhMuc.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên danh mục muốn thêm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DanhMuc danhMuc = new DanhMuc();
                danhMuc.TenDanhMuc = txt_tenDanhMuc.Text;
                _context.danhMucs.Add(danhMuc);
                _context.SaveChanges();
                
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                list_danhmuc.DataSource = null;
                LoadDataAsync();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var currenRow = list_danhmuc.CurrentRow;
            if (currenRow == null)
            {
                MessageBox.Show("Bạn chưa chọn danh mục muốn xóa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int Id = int.Parse(currenRow.Cells[0].Value.ToString());
                var danhMuc = _context.danhMucs.Where(c => c.Id == Id).FirstOrDefault();
                _context.Entry(danhMuc).State = EntityState.Modified;
                danhMuc.TenDanhMuc = txt_tenDanhMuc.Text;
                _context.SaveChanges();

                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                list_danhmuc.DataSource = null;
                LoadDataAsync();
            }
        }
    }
}
