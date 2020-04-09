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
using System.Text.RegularExpressions;
using System.Globalization;

namespace QuanLiCuaHang
{
    public partial class NgươiQuanLy : Form
    {
        ThuvienDataContext db;
        public NgươiQuanLy()
        {
            InitializeComponent();
            db = new ThuvienDataContext();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            GiaoDienChinh f1 = new GiaoDienChinh();
            this.Hide();
            f1.ShowDialog();
            
        }

        private void NgươiQuanLy_Load(object sender, EventArgs e)
        {
            LoadNguoiQuanLy();
            SetControl(false);
        }
        private void SetControl(bool an)
        {

        }
        private void LoadNguoiQuanLy()
        {
            this.tableNguoiQuanLy.DataSource = db.NGUOIQUANLies.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private bool kiemtra()
        {
            if (string.IsNullOrEmpty(this.comboBox1.Text))
            {
                MessageBox.Show(" Vui lòng nhập vào mã người quản lý");
                return false;
            }
            if (string.IsNullOrEmpty(this.textBox1.Text))
            {
                MessageBox.Show(" Vui lòng nhập vào tên người quản lý");
                    return false;
            }
            if(string.IsNullOrEmpty(this.comboBox2.Text))
            {
                MessageBox.Show("Vui lòng nhập vào giới tính");
                    return false;
            }
            if(string.IsNullOrEmpty(this.dateTimePicker1.Text))
            {
                MessageBox.Show(" Vui lòng nhập vào ngày sinh");
                return false;
            }
            if(string.IsNullOrEmpty(this.comboBox3.Text))
            {
                MessageBox.Show(" Vui lòng nhập vào chức vụ");
                return false;
            }
            if(string.IsNullOrEmpty(this.textBox3.Text))
            {
                MessageBox.Show(" Vui lòng nhập vào số điện thoại");
                return false;
            }
            if(string.IsNullOrEmpty(this.comboBox4.Text))
            {
                MessageBox.Show("Vui lòng nhập vào địa chỉ");
                return false;
            }
            if(string.IsNullOrEmpty(this.textBox5.Text))
            {
                MessageBox.Show(" VUi lòng nhập vào Email");
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //code thêm mới người quản lý
            //kiểm tra thông tin nhập vào
            if( kiemtra() )
            {
                try
                {
                    //Tao mơi doi tương nguoi quan ly
                    NGUOIQUANLY NQL = new NGUOIQUANLY();
                    NQL.MaNQL = this.comboBox1.Text;
                    NQL.TenNQL = this.textBox1.Text;
                    NQL.GioiTinh = this.comboBox2.Text;
                    NQL.NgaySinh = this.dateTimePicker1.Value.Date;
                    NQL.ChucVu=this.comboBox3.Text;
                    NQL.SoDT = this.textBox3.Text;
                    NQL.DiaChi = this.comboBox4.Text;
                    NQL.Email = this.textBox5.Text;

                    //lưu lại vào db
                    db.NGUOIQUANLies.InsertOnSubmit(NQL);
                    db.SubmitChanges();
                    MessageBox.Show(" Thêm vào danh sách thành công","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // xoa thông tin người khi nhập'
                    XoaNhap();
                    LoadNguoiQuanLy();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(" Có lỗi trong quá trình thêm mới người quản lý", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void XoaNhap()
        {
            this.comboBox1.Text = "";
            this.textBox1.Text = "";
            this.comboBox2.Text= "";
            this.dateTimePicker1.Text = "";
            this.comboBox3.Text = "";
            this.textBox3.Text = "";
            this.comboBox4.Text = "";
            this.textBox5.Text = "";
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void tableNguoiQuanLy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // xư lý sự kiện khi danh sách người quản lý được chọn
            int chon = tableNguoiQuanLy.SelectedCells[0].RowIndex;
            DataGridViewRow chonRow = tableNguoiQuanLy.Rows[chon];

            this.comboBox1.Text = chonRow.Cells[0].Value.ToString();
            this.textBox1.Text = chonRow.Cells[1].Value.ToString();
            this.comboBox2.Text = chonRow.Cells[2].ValueType.ToString();
            this.dateTimePicker1.Text = chonRow.Cells[3].Value.ToString();
            this.comboBox3.Text = chonRow.Cells[4].Value.ToString();
            this.textBox3.Text = chonRow.Cells[5].Value.ToString();
            this.comboBox4.Text = chonRow.Cells[6].Value.ToString();
            this.textBox5.Text = chonRow.Cells[7].Value.ToString();

            SetControl(true);
            this.comboBox1.Enabled = false;
        }
        private void button2_Click (object sender, EventArgs e)
        {
           NGUOIQUANLY NQL = db.NGUOIQUANLies.FirstOrDefault(s => s.MaNQL == this.comboBox1.Text);
           NQL.MaNQL = this.comboBox1.Text;
           NQL.TenNQL = this.textBox1.Text;
           NQL.GioiTinh = this.comboBox2.Text;
           NQL.NgaySinh = this.dateTimePicker1.Value.Date;
           NQL.ChucVu = this.comboBox3.Text;
           NQL.SoDT = this.textBox3.Text;
           NQL.DiaChi = this.comboBox4.Text;
           NQL.Email = this.textBox5.Text;



            db.SubmitChanges();
            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            XoaNhap();
            LoadNguoiQuanLy();
            SetControl(true);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ThuvienDataContext db = new ThuvienDataContext();
            var query = from book in db.NGUOIQUANLies
                        where book.MaNQL.Contains(textBox6.Text) || book.TenNQL.Contains(textBox6.Text)                       
                        select new { MANQL = book.MaNQL, TenNQL = book.TenNQL, GioiTinh = book.GioiTinh, NgaySinh = book.NgaySinh, ChucVu = book.ChucVu, SoDT = book.SoDT, DiaChi = book.DiaChi, Email = book.Email };
            tableNguoiQuanLy.DataSource = query.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NGUOIQUANLY NQL = db.NGUOIQUANLies.FirstOrDefault(s => s.MaNQL== this.comboBox1.Text);
            db.NGUOIQUANLies.DeleteOnSubmit(NQL);

            db.SubmitChanges();

            XoaNhap();
            LoadNguoiQuanLy();
            SetControl(true);
            this.button5.Enabled = false;
        }
    }
}