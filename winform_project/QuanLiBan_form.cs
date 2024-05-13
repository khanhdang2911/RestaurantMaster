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
    public partial class QuanLiBan_form : Form
    {
        private readonly AppDbContext _context;
        public QuanLiBan_form()
        {
            InitializeComponent();
            _context = DependencyContainer.Resolve<AppDbContext>();
        }
        public void LoadData()
        {
            dtg_danhsachBan.DataSource = _context.bans.ToList();
        }
        private void QuanLiBan_form_Load(object sender, EventArgs e)
        {
            
            LoadData();

            var currentRow = dtg_danhsachBan.CurrentRow;
            if (currentRow != null)
            {
                txt_tenBan.Text = currentRow.Cells[1].Value.ToString();
            }
        }

        private void dtg_danhsachBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var currentRow = dtg_danhsachBan.CurrentRow;
            if (currentRow != null)
            {
                txt_tenBan.Text = currentRow.Cells[1].Value.ToString();
            }
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_tenBan.Text = "";
        }

        private void btn_themBan_Click(object sender, EventArgs e)
        {
            string tenbanMoi = txt_tenBan.Text;
            if(string.IsNullOrWhiteSpace(tenbanMoi))
            {
                MessageBox.Show("Bạn chưa nhập tên bàn cần thêm.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Ban ban = new Ban();
                ban.TenBan = tenbanMoi;
                ban.TinhTrang = false;
                _context.bans.Add(ban);
                _context.SaveChanges();
                MessageBox.Show("Thêm bàn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtg_danhsachBan.DataSource = null;
                LoadData();
            }
        }

        private void btn_xoaBan_Click(object sender, EventArgs e)
        {
            var currentRow = dtg_danhsachBan.CurrentRow;
            if (currentRow != null)
            {
                //Kiem tra xem ban nay dang duoc order hay chua, neu dang dc order thi ko dc xoa 
                int BanId = int.Parse(currentRow.Cells[0].Value.ToString());
                var ban = _context.bans.Find(BanId);
                if(ban.TinhTrang==true)
                {
                    MessageBox.Show("Không thể xóa vì bàn này đang có người dùng.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _context.bans.Remove(ban);
                    _context.SaveChanges();
                    MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtg_danhsachBan.DataSource = null;
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn bàn cần xóa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_suaBan_Click(object sender, EventArgs e)
        {
            var currentRow = dtg_danhsachBan.CurrentRow;
            if (currentRow != null)
            {
                //Kiem tra xem ban nay dang duoc order hay chua, neu dang dc order thi ko dc xoa 
                int BanId = int.Parse(currentRow.Cells[0].Value.ToString());
                var ban = _context.bans.Find(BanId);
                if (ban.TinhTrang == true)
                {
                    MessageBox.Show("Không thể sửa vì bàn này đang có người dùng.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _context.Entry(ban).State=System.Data.Entity.EntityState.Modified;
                   
                    //Kiem tra ten ban hien tai co trung voi ten ban cu khong, neu trung thi ko cho sua
                    if(ban.TenBan==txt_tenBan.Text)
                    {
                        MessageBox.Show("Tên bàn mới không được trùng tên bàn cũ.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        ban.TenBan = txt_tenBan.Text;
                        _context.SaveChanges();
                        MessageBox.Show("Sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtg_danhsachBan.DataSource = null;
                        LoadData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn bàn cần sửa thông tin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
