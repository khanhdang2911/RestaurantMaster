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
    public partial class Login_form : Form
    {
        private readonly AppDbContext _context = new AppDbContext();
        public Login_form()
        {
            InitializeComponent();
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username=txt_userName.Text;
            string password = txt_password.Text;

            var user = _context.nguoiDungs.FirstOrDefault(c => c.Username == username);

            if (user != null && HashPasswordByBC.VerifyPassword(password, user.Password))
            {
                //Hop he
                this.Hide();
                Form1 f1 = new Form1(user);
                f1.FormBorderStyle = FormBorderStyle.FixedToolWindow;
                f1.Show();
            }

            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_form_Load(object sender, EventArgs e)
        {

        }
    }
}
