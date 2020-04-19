using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_THUVIEN2
{
    public partial class TTTaiKhoan : Form
    {
        private string _message;
        private string _manv;
        private string _mk;
        public TTTaiKhoan()
        {
            InitializeComponent();
        }
        clsDatabase cls = new QL_THUVIEN2.clsDatabase();
       
        public string MK
        {
            get { return _mk; }
            set { _mk = value; }
        }
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }
        public string MaNV
        {
            get { return _manv; }
            set { _manv = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtmkcu.Text == _mk)
            {
                if (txtmkmoi.Text == txtmklai.Text)
                {
                    try
                    {
                        string sql = "update NHANVIEN set MatKhau='" + txtmkmoi.Text + "' where TaiKhoan='" + lbltaikhoan.Text + "' ";
                        //SqlCommand cmd = new SqlCommand(sql, cnn);
                        // cmd.ExecuteNonQuery();
                        cls.ThucThiSQLTheoKetNoi(sql);
                        MessageBox.Show("Change account successfully!");
                    }
                    catch (Exception) { MessageBox.Show("Error!"); }
                }
                else
                {
                    MessageBox.Show("Password doesn't match!");
                    txtmkmoi.Focus();
                }
            }
            else
            {
                MessageBox.Show("Password is incorrect!");
                txtmkcu.Focus();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtmkcu.PasswordChar = '\0';
                txtmklai.PasswordChar = '\0';
                txtmkmoi.PasswordChar = '\0';
            }
            if (checkBox1.Checked == false)
            {
                txtmkcu.PasswordChar = '*';
                txtmkmoi.PasswordChar = '*';
                txtmklai.PasswordChar = '*';
            }
        }

        private void TTTaiKhoan_Load(object sender, EventArgs e)
        {
            lbltaikhoan.Text = _message;

            cls.KetNoi();
            if (_message != null)
            {
                panel1.Visible = true;
                // panel2.Hide();
            }
            if (_manv != null)
            {
                panel1.Hide();
                //    panel2.Visible = true;
            }
        }
    }
}
