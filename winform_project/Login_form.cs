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
            var user = _context.nguoiDungs.Where(c => c.Username == username && password == password).FirstOrDefault();
            if (user==null)
            {
                MessageBox.Show("Sai tên người dùng hoặc mặt khẩu.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                this.Hide();
                Form1 f1 = new Form1(user);
                f1.Show();
            }
        }
    }
}
