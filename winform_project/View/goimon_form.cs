using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winform_project.DTOs;

namespace winform_project
{
    public partial class goimon_form : Form
    {
        private readonly AppDbContext _context;
        public int BanID;
        public List<SanPhamDTO> sanPhams = new List<SanPhamDTO>();
        public goimon_form(int BanId)
        {
            InitializeComponent();
            _context = DependencyContainer.Resolve<AppDbContext>();
            this.BanID = BanId;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtg_danhsachmonOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_soluong.Text = "";
            var currentSanPham = dtg_danhsachmonOrder.CurrentRow.Cells[1].Value.ToString();



            txt_tenmon.Text = currentSanPham;

        }

        private void goimon_form_Load(object sender, EventArgs e)
        {
            dtg_danhsachmonOrder.DataSource = _context.sanPhams.Select(c => new SanPhamDTO
            {
                Id = c.Id,
                TenSanPham = c.TenSanPham,
                GiaSanPham = c.GiaSanPham,
                TinhTrang = c.TinhTrang,
                DanhMuc = _context.danhMucs.Where(p => p.Id == c.DanhMucId).Select(p => p.TenDanhMuc).FirstOrDefault()
            })
            .ToList();

            //Load ten ban
            lbl_TenBan.Text = _context.bans.Where(c => c.Id == BanID).Select(c => c.TenBan).FirstOrDefault();
            //

        }

        private void btn_themNhanVien_Click(object sender, EventArgs e)
        {

            if (txt_soluong.Text.ToString() == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    var currentSanPham = dtg_danhsachmonOrder.CurrentRow.Cells[0].Value.ToString();
                    int IdSP = int.Parse(currentSanPham);
                    var sanpham = _context.sanPhams.Find(IdSP);
                    //Kiem tra tinh trang neu het hang thi khong cho chon mon
                    if(sanpham.TinhTrang==false)
                    {
                        MessageBox.Show("Sản phẩm này đã hết hàng, hãy chọn món khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //Neu co roi thi sua
                        if (_context.sanPhamBans.Any(c => c.SanPhamId == IdSP && c.BanId == BanID))
                        {
                            var sanphamBanEdit = _context.sanPhamBans.Where(c => c.SanPhamId == IdSP && c.BanId == BanID).FirstOrDefault();
                            _context.Entry(sanphamBanEdit).State = System.Data.Entity.EntityState.Modified;
                            sanphamBanEdit.Soluong = int.Parse(txt_soluong.Text.ToString());
                            _context.SaveChanges();
                            MessageBox.Show("Sửa order thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);



                        }
                        else//Chua co thi them
                        {
                            SanPhamBan sanPhamBan = new SanPhamBan();
                            sanPhamBan.Soluong = int.Parse(txt_soluong.Text.ToString());
                            sanPhamBan.BanId = BanID;
                            sanPhamBan.SanPhamId = sanpham.Id;
                            _context.sanPhamBans.Add(sanPhamBan);
                            _context.SaveChanges();
                            MessageBox.Show("Order thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        txt_soluong.Text = "";
                        var ban = _context.bans.Find(BanID);
                        //Sua lai tinh trang ban
                        if (ban.TinhTrang == false)
                        {
                            _context.Entry(ban).State = System.Data.Entity.EntityState.Modified;
                            ban.TinhTrang = true;
                            _context.SaveChanges();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Bạn nhập không đúng định dạng số.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_xoaNhanVien_Click(object sender, EventArgs e)
        {
                if(txt_soluong.Text.ToString()!="")
                {
                    MessageBox.Show("Khi hủy món vui lòng không nhập số lượng.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var currentSanPham = dtg_danhsachmonOrder.CurrentRow.Cells[0].Value.ToString();
                    int IdSP = int.Parse(currentSanPham);
                    var sanphamBanDelete = _context.sanPhamBans.Where(c => c.SanPhamId == IdSP && c.BanId == BanID).FirstOrDefault();
                    if (sanphamBanDelete!=null)
                    {
                        
                        _context.sanPhamBans.Remove(sanphamBanDelete);
                        _context.SaveChanges();
                        MessageBox.Show("Hủy món thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if(_context.sanPhamBans.Any(c=> c.BanId == BanID)==false)
                        {
                            var ban= _context.bans.Find(BanID);
                            _context.Entry(ban).State=System.Data.Entity.EntityState.Modified;
                            ban.TinhTrang = false;
                        }
                    }
                    else
                    {
                         MessageBox.Show("Bạn chưa order món này nên không thể hủy.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                
            
           
        }
    }
    }

