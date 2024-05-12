using Bunifu.UI.WinForms;
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
    public partial class QuanLiNhanVien_form : Form
    {
        private readonly AppDbContext _context;

        public QuanLiNhanVien_form()
        {
            InitializeComponent();
            _context= DependencyContainer.Resolve<AppDbContext>();
        }
        private async Task LoadDataAsync()
        {

            var data = await _context.nguoiDungs.Select(c => new NguoiDungDTO
            {
                Id = c.Id,
                Username = c.Username,
                HoTen=c.HoTen,
                Phone = c.Phone,
                TenRole = _context.roles.Where(p => p.Id == c.RoleId).Select(p => p.TenRole).FirstOrDefault()
            })
            .ToListAsync();

            list_nhanvien.DataSource = data;


            //Load vao danh muc o combobox
            cbb_role.DataSource = _context.roles.ToList();
            cbb_role.DisplayMember = "TenRole"; // Hiển thị tên danh mục
            cbb_role.ValueMember = "Id"; // Lưu trữ Id của danh mục

            //

            var currenRow = list_nhanvien.CurrentRow;

            if(currenRow!=null)
            {
                int Id = int.Parse(currenRow.Cells[0].Value.ToString());
                var nhanvien = _context.nguoiDungs.Where(c => c.Id == Id).FirstOrDefault();
                txt_hoten.Text = nhanvien.HoTen;
                txt_phone.Text = nhanvien.Phone;
                txt_password.Text = "***********";
                txt_userName.Text = nhanvien.Username;
                cbb_role.SelectedItem = _context.roles.Find(nhanvien.RoleId);
            }



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

        private void QuanLiNhanVien_form_Load(object sender, EventArgs e)
        {
            LoadDataAsync();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_hoten.Text = "";
            txt_phone.Text = "";
            txt_password.Text = "";
            txt_userName.Text = "";
        }

        private void btn_themNhanVien_Click(object sender, EventArgs e)
        {
            bool check = true;
            if(string.IsNullOrWhiteSpace(txt_hoten.Text))
            {
                check = false;
            }
            if (string.IsNullOrWhiteSpace(txt_phone.Text))
            {
                check = false;
            }
            if (string.IsNullOrWhiteSpace(txt_password.Text))
            {
                check = false;
            }
            if (string.IsNullOrWhiteSpace(txt_userName.Text))
            {
                check = false;
            }



            if(check==false)
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                string hoten = txt_hoten.Text.ToString();
                string phone = txt_phone.Text.ToString();
                string passwordHash = HashPasswordByBC.HashPassword(txt_password.Text.ToString());
                string username = txt_userName.Text.ToString();
                //Kiem tra xem phone da ton tai hay chua
                if (_context.nguoiDungs.Any(c=>c.Phone==phone))
                {
                    MessageBox.Show("Số điện thoại này đã tồn tại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(_context.nguoiDungs.Any(c => c.Username == username))
                {
                    MessageBox.Show("Tên người dùng đã tồn tại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    
                    int roleId = int.Parse(cbb_role.SelectedValue.ToString());
                    NguoiDung nguoidung = new NguoiDung();
                    nguoidung.HoTen = hoten;
                    nguoidung.Phone = phone;
                    nguoidung.Password = passwordHash;
                    nguoidung.Username = username;
                    nguoidung.RoleId = roleId;
                    _context.nguoiDungs.Add(nguoidung);
                    _context.SaveChanges();
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    list_nhanvien.DataSource = null;
                    LoadDataAsync();
                }

            }



         
            


        }

        private void btn_xoaNhanVien_Click(object sender, EventArgs e)
        {
            var currenRow = list_nhanvien.CurrentRow;

            if (currenRow != null)
            {
                int Id = int.Parse(currenRow.Cells[0].Value.ToString());
                var nhanvien = _context.nguoiDungs.Where(c => c.Id == Id).FirstOrDefault();
                _context.nguoiDungs.Remove(nhanvien);
                _context.SaveChanges();
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                list_nhanvien.DataSource = null;
                LoadDataAsync();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn tài khoản muốn xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //Check xem nhap du thong tin hay chua
            bool check = true;
            if (string.IsNullOrWhiteSpace(txt_hoten.Text))
            {
                check = false;
            }
            if (string.IsNullOrWhiteSpace(txt_phone.Text))
            {
                check = false;
            }
            if (string.IsNullOrWhiteSpace(txt_password.Text))
            {
                check = false;
            }
            if (string.IsNullOrWhiteSpace(txt_userName.Text))
            {
                check = false;
            }



            if (check == false)
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            var currenRow = list_nhanvien.CurrentRow;

            if (currenRow != null)
            {
                int Id = int.Parse(currenRow.Cells[0].Value.ToString());
                var nhanvien = _context.nguoiDungs.Where(c => c.Id == Id).FirstOrDefault();
                _context.Entry(nhanvien).State = EntityState.Modified;
                nhanvien.HoTen = txt_hoten.Text.ToString();
                nhanvien.RoleId = int.Parse(cbb_role.SelectedValue.ToString());
                nhanvien.Password = HashPasswordByBC.HashPassword(txt_password.ToString());
                nhanvien.Username=txt_userName.Text.ToString();
                nhanvien.Phone = txt_phone.Text.ToString();

           
                _context.SaveChanges();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                list_nhanvien.DataSource = null;
                LoadDataAsync();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn tài khoản muốn sửa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
