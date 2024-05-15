
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using winform_project.DTOs;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace winform_project
{
    public partial class Form1 : Form
    {
       
        private readonly AppDbContext _context;
        private QuanLiBan_form quanliban_Form;
        private QuanLiNhanVien_form quanLiNhanVien_Form;
        private QuanLiDoAn_form quanLiDoAn_Form;
        private QuanLiDanhMuc quanLiDanhMuc_Form;
        private ThayDoiThongTin_form thayDoiThongTin_Form;
        private QuanLiHoaDon_form quanlHoaDon_Form;

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
            if (quanLiNhanVien_Form == null)
            {
                quanLiNhanVien_Form = new QuanLiNhanVien_form();
                quanLiNhanVien_Form.FormBorderStyle = FormBorderStyle.Sizable;
                quanLiNhanVien_Form.FormClosed += QuanLiNhanVien_Form_FormClosed; 
                quanLiNhanVien_Form.Show();
            }
        }
        private void QuanLiNhanVien_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            quanLiNhanVien_Form = null; 
        }

        private void btn_quanliDoAn_Click(object sender, EventArgs e)
        {
            if (quanLiDoAn_Form == null)
            {
                quanLiDoAn_Form = new QuanLiDoAn_form();
                quanLiDoAn_Form.FormBorderStyle = FormBorderStyle.Sizable;
                quanLiDoAn_Form.FormClosed += QuanLiDoAn_Form_FormClosed; 
                quanLiDoAn_Form.Show();
            }
        }
        private void QuanLiDoAn_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            quanLiDoAn_Form = null; 
        }

        private void btn_quanliDanhMuc_Click_1(object sender, EventArgs e)
        {
            if (quanLiDanhMuc_Form == null)
            {
                quanLiDanhMuc_Form = new QuanLiDanhMuc();
                quanLiDanhMuc_Form.FormBorderStyle = FormBorderStyle.Sizable;
                quanLiDanhMuc_Form.FormClosed += QuanLiDanhMuc_Form_FormClosed; 
                quanLiDanhMuc_Form.Show();
            }
        }
        private void QuanLiDanhMuc_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            quanLiDanhMuc_Form = null; 
        }
        private void btn_thaydoiThongTin_Click_1(object sender, EventArgs e)
        {
            if (thayDoiThongTin_Form == null)
            {
                User = _context.nguoiDungs.Find(User.Id);
                thayDoiThongTin_Form = new ThayDoiThongTin_form(User);
                thayDoiThongTin_Form.FormBorderStyle = FormBorderStyle.Sizable;
                thayDoiThongTin_Form.FormClosed += ThayDoiThongTin_Form_FormClosed; 
                thayDoiThongTin_Form.Show();
            }
        }
        private void ThayDoiThongTin_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            thayDoiThongTin_Form = null; 
        }

        private void btn_dangxuat_Click_1(object sender, EventArgs e)
        {
            // Danh sách các form
            List<Form> openForms = new List<Form>();

            // Thêm các form vào danh sách
            foreach (Form f in Application.OpenForms)
            {
                openForms.Add(f);
            }

            // Đóng các form đã thêm vào danh sách
            foreach (Form f in openForms)
            {
                if (f.Name != "Login_form")
                {
                    f.Close();
                }
            }
            Login_form loginform = new Login_form();
            loginform.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            User = _context.nguoiDungs.Find(User.Id);

            dtg_danhsachban.DataSource = _context.bans.ToList();
            var currentBan = dtg_danhsachban.CurrentRow.Cells[0].Value.ToString();
            loadDuLieuChoListOrder(int.Parse(currentBan));


            var IdroleNhanVien = _context.roles.Where(c => c.TenRole == "Nhanvien").FirstOrDefault();
            if (User.RoleId == IdroleNhanVien.Id)
            {
                btn_quanliHoaDon.Hide();
                btn_quanliNhanVien.Hide();

                btn_quanliban.Location = new Point(29, 170);
                btn_quanliDoAn.Location = new Point(29, 221);
                btn_quanliDanhMuc.Location = new Point(29, 271);
                btn_thaydoiThongTin.Location = new Point(29, 320);
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
                ExportToPDF(hoadon);
            }

        }

        private void lbl_yourName_Click(object sender, EventArgs e)
        {

        }

        private void btn_quanliban_Click(object sender, EventArgs e)
        {
            if (quanliban_Form == null)
            {
                quanliban_Form = new QuanLiBan_form();
                quanliban_Form.FormBorderStyle = FormBorderStyle.Sizable;
                quanliban_Form.FormClosed += Quanliban_Form_FormClosed; 
                quanliban_Form.Show();
            }

        }
        private void Quanliban_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            quanliban_Form = null; 
        }

        private void lbl_table_Click(object sender, EventArgs e)
        {
            dtg_danhsachban.DataSource = _context.bans.ToList();
        }

        private void btn_quanliHoaDon_Click(object sender, EventArgs e)
        {
            if (quanlHoaDon_Form == null)
            {
                quanlHoaDon_Form = new QuanLiHoaDon_form();
                quanlHoaDon_Form.FormBorderStyle = FormBorderStyle.Sizable;
                quanlHoaDon_Form.FormClosed += QuanlHoaDon_Form_FormClosed;
                quanlHoaDon_Form.Show();
            }
        }
        private void QuanlHoaDon_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            quanlHoaDon_Form = null; 
        }


       
        private void ExportToPDF(HoaDon hoadon)
        {
            PdfDocument document = new PdfDocument();
            PdfPage page = document.AddPage();
            page.Width = XUnit.FromMillimeter(130);
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Arial", 13, XFontStyle.Regular);

        
            XFont fontBold = new XFont("Arial", 13, XFontStyle.Bold);

            int yPosition = 40; 



            int lineHeight =font.Height;

            gfx.DrawString("Khanh's Coffee", fontBold, XBrushes.Black, new XRect(0, yPosition, page.Width, page.Height), XStringFormats.TopCenter);
            yPosition += lineHeight + 10; 

            gfx.DrawString("Địa chỉ: Trường đại học Bach Khoa, Đà Nẵng, Việt Nam", fontBold, XBrushes.Black, new XRect(0, yPosition, page.Width, page.Height), XStringFormats.TopCenter);
            yPosition += lineHeight + 20; 

            gfx.DrawString("Hóa đơn thanh toán", fontBold, XBrushes.Black, new XRect(0, yPosition, page.Width, page.Height), XStringFormats.TopCenter);
            yPosition += lineHeight + 10; 

            gfx.DrawString("----------------------------", fontBold, XBrushes.Black, new XRect(0, yPosition, page.Width, page.Height), XStringFormats.TopCenter);
            yPosition += lineHeight + 10; 

            gfx.DrawString($"Ngày thanh toán: {hoadon.NgayBan}", font, XBrushes.Black, new XRect(0, yPosition, page.Width, page.Height), XStringFormats.TopCenter);
            yPosition += lineHeight + 10; 

            gfx.DrawString($"Ngồi bàn: {hoadon.TenBan}", font, XBrushes.Black, new XRect(0, yPosition, page.Width, page.Height), XStringFormats.TopCenter);
            yPosition += lineHeight + 10; 

            gfx.DrawString($"Tổng thành tiền: {hoadon.tongTien} VNĐ", font, XBrushes.Black, new XRect(0, yPosition, page.Width, page.Height), XStringFormats.TopCenter);
            yPosition += lineHeight + 10; 

            gfx.DrawString("Quý khách vui lòng kiểm tra kĩ hóa đơn trước khi thanh toán", font, XBrushes.Black, new XRect(0, yPosition, page.Width, page.Height), XStringFormats.TopCenter);
            yPosition += lineHeight + 10;

            gfx.DrawString("Xin cảm ơn quý khách", font, XBrushes.Black, new XRect(0, yPosition, page.Width, page.Height), XStringFormats.TopCenter);



            string filePath = "HoaDon.pdf";
            document.Save(filePath);

            System.Diagnostics.Process.Start(filePath);
        }






    }
}
