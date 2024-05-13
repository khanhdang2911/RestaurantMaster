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
    public partial class DoiMatKhau_form : Form
    {
        private readonly AppDbContext _context;
        private NguoiDung User;
            
        public DoiMatKhau_form(NguoiDung uSer)
        {
            InitializeComponent();
            _context = DependencyContainer.Resolve<AppDbContext>();
            User = uSer;
        }

        private void txt_matkhaucu_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void DoiMatKhau_form_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_luuMatKhau_Click(object sender, EventArgs e)
        {
            
            string passwordCu = txt_matkhaucu.Text;
            string passwordMoi = txt_matkhaumoi.Text;
            string passwordXacNhan = txt_xacnhanlaimatkhau.Text;
            bool check = true;
            if (string.IsNullOrWhiteSpace(passwordCu))
            {
                check = false;
            }

            if (string.IsNullOrWhiteSpace(passwordMoi))
            {
                check = false;
            }

            if (string.IsNullOrWhiteSpace(passwordXacNhan))
            {
                check = false;
            }

            if (check == false)
            {
                MessageBox.Show("Bạn nhập chưa đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Check xem mat khau cu co trung voi mat khau trong db
                if (HashPasswordByBC.VerifyPassword(txt_matkhaucu.Text, User.Password)==false)
                {
                    MessageBox.Show("Mật khẩu cũ không chính xác:"+User.Password+ HashPasswordByBC.VerifyPassword(txt_matkhaucu.Text.ToString(), User.Password));
                }
                else
                {
                    if (txt_matkhaumoi.Text != txt_xacnhanlaimatkhau.Text)
                    {
                        MessageBox.Show("Nhập lại mật khẩu không chính xác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        _context.Entry(User).State = System.Data.Entity.EntityState.Modified;
                        User.Password = HashPasswordByBC.HashPassword(txt_matkhaumoi.Text);
                        _context.SaveChanges();
                        MessageBox.Show("Đổi mật khẩu thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        this.Close();
                    }
                }
            }
        }
    }
}
