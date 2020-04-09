using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiCuaHang.DataContext;

namespace QuanLiCuaHang
{
    public partial class DangNhap : Form
    {
        ThuvienDataContext db;
        public DangNhap()
        {
            InitializeComponent();
            db = new ThuvienDataContext();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            if (kiemtra(textBox1.Text, textBox2.Text))
            {
                GiaoDienChinh f1 = new GiaoDienChinh();
                MessageBox.Show("Đăng nhập thành công","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                f1.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                this.textBox1.Text = "";
                this.textBox2.Text = "";
                textBox1.Focus();
            }
        }

        private bool kiemtra(string p1, string p2)
        {
            ThuvienDataContext context = new ThuvienDataContext();
            if (string.IsNullOrEmpty(this.textBox1.Text))
            {
                MessageBox.Show("Vui lòng nhập vào tài khoản");
                return false;
            }
            if (string.IsNullOrEmpty(this.textBox2.Text))
            {
                MessageBox.Show("Vui lòng nhập vào Mật khẩu");
                return false;
            }

            var q = from p in context.ACOUNTs
                    where p.UserName == textBox1.Text
                    && p.Passwords == textBox2.Text
                    select p;
 
            if (q.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
             DialogResult tb = MessageBox.Show("Bạn có muốn thoát hay không?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            if(tb==DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

     
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
    

