using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_THUVIEN2
{
    public partial class FormTaoTaiKhoan : Form
    {
        public FormTaoTaiKhoan()
        {
            InitializeComponent();
        }
        
       clsDatabase cls = new QL_THUVIEN2.clsDatabase();
     

        private void FormTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            // ketnoi();
            cls.KetNoi();
        }

      
        private void button3_Click(object sender, EventArgs e)

        {
       
            string mapm = "select COUNT(TaiKhoan) from NHANVIEN WHERE TaiKhoan='" + textBox1.Text + "'";
            int slg = cls.CheckID(mapm);
                //(int)sl.ExecuteScalar();
            if (slg > 0) MessageBox.Show("Tài Khoản đã tồn tại!");
            else
            if (textBox1.Text.Length - 1 < 5)
                MessageBox.Show(" Username is too short!");
            else
                 if (textBox1.Text.Length - 1 > 30)
                MessageBox.Show("Username is too long!");
            else
                 if (textBox2.Text.Length - 1 < 5)
                MessageBox.Show("Password is too short!");
            else
                 if (textBox3.Text.Length - 1 > 30)
                MessageBox.Show("Password is too long");
            else
                if (textBox2.Text != textBox3.Text)
                MessageBox.Show("Password don't match!");
            else
            { string sql="insert into NHANVIEN(TaiKhoan, MatKhau, Quyenhan)values('" + textBox1.Text + "', '" + textBox2.Text + "', 'user')";
                // SqlCommand cmd = new SqlCommand(sql, cnn);
                //  cmd.ExecuteNonQuery();
                cls.ThucThiSQLTheoKetNoi(sql);
             //   cls.ThucThiSQLTheoKetNoi(sql);
                MessageBox.Show("Đăng kí thàn công!Hãy cập nhật thông tin trong phần thông tin cá nhân");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
                textBox3.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
                textBox3.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
