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
    public partial class Form1 : Form
    {
       
        private readonly AppDbContext _context;
        public NguoiDung User;
        public Form1(NguoiDung _User)
        {
            InitializeComponent();
            _context = DependencyContainer.Resolve<AppDbContext>();
            User= _User;


        }

      

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel_quanliban_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {

        }

        private void btn_ban10_Click(object sender, EventArgs e)
        {
            
        }

        

        private void btn_quanliNhanVien_Click_1(object sender, EventArgs e)
        {
            QuanLiNhanVien_form quanLiNhanVien_form = new QuanLiNhanVien_form();
            quanLiNhanVien_form.FormBorderStyle = FormBorderStyle.Sizable;
            quanLiNhanVien_form.Show();
        }

        private void btn_quanliDoAn_Click(object sender, EventArgs e)
        {
            QuanLiDoAn_form QuanLiDoAn_form = new QuanLiDoAn_form();
            QuanLiDoAn_form.FormBorderStyle = FormBorderStyle.Sizable;
            QuanLiDoAn_form.Show();
        }

        private void btn_quanliDanhMuc_Click_1(object sender, EventArgs e)
        {
            QuanLiDanhMuc quanliDanhMuc = new QuanLiDanhMuc();
            quanliDanhMuc.FormBorderStyle = FormBorderStyle.Sizable;
            quanliDanhMuc.Show();
        }

        private void btn_thaydoiThongTin_Click_1(object sender, EventArgs e)
        {
            ThayDoiThongTin_form thayDoiThongTin_Form = new ThayDoiThongTin_form(User);
            thayDoiThongTin_Form.FormBorderStyle= FormBorderStyle.Sizable;
            thayDoiThongTin_Form.Show();
        }

        private void btn_dangxuat_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Login_form loginform = new Login_form();
            loginform.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //
            User = _context.nguoiDungs.Find(User.Id);

            dtg_danhsachban.DataSource = _context.bans.ToList();
            var currentBan = dtg_danhsachban.CurrentRow.Cells[0].Value.ToString();
            loadDuLieuChoListOrder(int.Parse(currentBan));


            // Kiem tra chuc nang cho nhanvien
            var IdroleNhanVien = _context.roles.Where(c => c.TenRole == "Nhanvien").FirstOrDefault();
            if (User.RoleId == IdroleNhanVien.Id)
            {
                btn_quanliban.Hide();
                btn_quanliNhanVien.Hide();

            }



        }
        public void loadDuLieuChoListOrder(int BanId)
        {
            var data = _context.sanPhamBans.Where(c=>c.BanId==BanId).Select(p => new SanPhamOrderDTO
            {
                Id=p.SanPhamId,
                TenSanPham = _context.sanPhams.Where(c => c.Id == p.SanPhamId).Select(c=>c.TenSanPham).FirstOrDefault(),
                GiaSanPham=p.Soluong * _context.sanPhams.Where(c => c.Id == p.SanPhamId).Select(c => c.GiaSanPham).FirstOrDefault(),
                soluong=p.Soluong
            }).ToList() ;
            list_order.DataSource=data;
            decimal tongTien = 0;
            foreach(var item in data)
            {
                tongTien += item.GiaSanPham;
            }
            txt_thanhtien.Text=tongTien.ToString();
        }
        private void dtg_danhsachban_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var currentBan = dtg_danhsachban.CurrentRow.Cells[0].Value.ToString();
            loadDuLieuChoListOrder(int.Parse(currentBan));

            
            
        }

        private void list_order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_ChonMon_Click(object sender, EventArgs e)
        {
            var currentBan = dtg_danhsachban.CurrentRow;
            if (currentBan == null )
            {
                MessageBox.Show("Chưa chọn bàn, hãy chọn bàn rồi mới chọn món.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //else if(currentBan.Cells[2].Value.ToString() == "True")
            //{
            //    MessageBox.Show("Bàn này đã có người chọn rồi, hãy chọn bàn khác.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            else
            {
                

                goimon_form goimon_Form = new goimon_form(int.Parse(currentBan.Cells[0].Value.ToString()));
                goimon_Form.FormBorderStyle = FormBorderStyle.Sizable;
                goimon_Form.Show();
                
               
            }

               
        }

        private void btn_thanhToan_Click(object sender, EventArgs e)
        {
            string tenBanHienTai = dtg_danhsachban.CurrentRow.Cells[1].Value.ToString();
            if(string.IsNullOrEmpty(tenBanHienTai))
            {
                MessageBox.Show("Chưa chọn bàn muốn thanh toán, hãy chọn bàn rồi mới thanh toán.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                HoaDon hoadon = new HoaDon();
                hoadon.TenBan = tenBanHienTai;
                hoadon.NgayBan = DateTime.Now;
                hoadon.tongTien=decimal.Parse(txt_thanhtien.Text.ToString());
                _context.HoaDon.Add(hoadon);

                //Luu xong thi xoa cac don hang con lai di
                int IdBanHienTai = int.Parse(dtg_danhsachban.CurrentRow.Cells[0].Value.ToString());
                var deleteBans = _context.sanPhamBans.Where(c => c.BanId == IdBanHienTai).ToList();
                _context.sanPhamBans.RemoveRange(deleteBans);

                //Cap nhat trang thai cua ban sau khi thanh toan
                var banHienTai = _context.bans.Find (IdBanHienTai);
                _context.Entry(banHienTai).State = EntityState.Modified;
                banHienTai.TinhTrang = false;
                _context.SaveChanges();
                //Hien thong bao len
                MessageBox.Show("Thanh toán thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void lbl_yourName_Click(object sender, EventArgs e)
        {

        }

        private void btn_quanliban_Click(object sender, EventArgs e)
        {
            QuanLiBan_form quanliban_Form = new QuanLiBan_form();
            quanliban_Form.FormBorderStyle = FormBorderStyle.Sizable;
            quanliban_Form.Show();
            
        }

        private void lbl_table_Click(object sender, EventArgs e)
        {
            dtg_danhsachban.DataSource = _context.bans.ToList();
        }

        private void btn_quanliHoaDon_Click(object sender, EventArgs e)
        {
            QuanLiHoaDon_form quanlHoaDon_Form = new QuanLiHoaDon_form();
            quanlHoaDon_Form.FormBorderStyle = FormBorderStyle.Sizable;
            quanlHoaDon_Form.Show();
        }
    }
}
