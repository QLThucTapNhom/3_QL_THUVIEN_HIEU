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
using System.Data.SqlClient;

namespace QuanLiCuaHang
{
    public partial class NXB : Form
    {
        ThuvienDataContext db;
        public NXB()
        {
            InitializeComponent();
            db = new ThuvienDataContext();
        }
            
        private void SetControl (bool an)
        {
            this.button1.Enabled = !an;
            this.btnSua.Enabled = an;
            this.button5.Enabled = an;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            GiaoDienChinh f1 = new GiaoDienChinh();
            this.Hide();
            f1.ShowDialog();
        }

        private void NXB_Load(object sender, EventArgs e)
        {
            LoadNXB();
            SetControl(false);
        }
        private void LoadNXB()
        {
            this.tableNhaXuatBan.DataSource = db.NHAXBs.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         // code thêm mới nhà  xuất bản
            if (kiemtra() && ngoaile())
            {
                try
                {
                    //tao mơi dối tượng nhà xuất bản\
                    NHAXB nxb = new NHAXB();
                    nxb.MaNXB = this.textBox2.Text;
                    nxb.TenNXB = this.comboBox2.Text;
                    nxb.Email = this.textBox3.Text;
                    nxb.SoDT = this.textBox1.Text;
                    nxb.DiaChi = this.comboBox3.Text;
                    // lưu lại vào db
                    db.NHAXBs.InsertOnSubmit(nxb);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm vào nhà xuất bản thành công","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //xoa thong tin nguoi khi nhap xong
                    XoaNhap();
                    LoadNXB();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra trong quá trình thêm nhà xuất bản" + ex.Message);
                }
            }
        }

         private bool ngoaile()
        {

            if ((this.textBox2.Text).Length == 2)
            {
                MessageBox.Show("Nhập đúng mã nhà xuất bản");
            }
            else
            {
                MessageBox.Show("Nhập sai! Mã nhà xuất chỉ gồm 2 kí tự!");
                this.textBox2.Text = "";
                textBox2.Focus();
                return false;
            }
            return true;
        }
        private bool kiemtra()
        {
            if (string.IsNullOrEmpty(this.textBox2.Text))
            {
                MessageBox.Show("Vui lòng nhập vào mã nhà xuất bản");
                return false;
            }
           
            if (string.IsNullOrEmpty(this.comboBox2.Text))
            {
                MessageBox.Show("Vui lòng nhập vào tên nhà xuất bản");
                return false;
            }
            if (string.IsNullOrEmpty(this.textBox3.Text))
            {
                MessageBox.Show("Vui lòng nhập vào Email");
                return false;
            }
            if (string.IsNullOrEmpty(this.textBox1.Text))
            {
                MessageBox.Show("Vui lòng nhập vào số điện thoại");
                return false;
            }
            if (string.IsNullOrEmpty(this.comboBox3.Text))
            {
                MessageBox.Show("Vui lòng nhập vào địa chỉ");
                return false;
            }

            return true;
        }
        private void dataGridView1_CellContentClick(object sender, EventArgs e)
        {

        }
        private void XoaNhap()
        {
            this.textBox2.Text = "";
            this.comboBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox1.Text = "";
            this.comboBox3.Text = "";
        }
   
        private void tableNhaXuatBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //xu ly su kien khi danh sach nha xuat ban duoc chon
            int chon = tableNhaXuatBan.SelectedCells[0].RowIndex;
            DataGridViewRow chonRow = tableNhaXuatBan.Rows[chon];

            this.textBox2.Text = chonRow.Cells[0].Value.ToString();
            this.comboBox2.Text = chonRow.Cells[1].Value.ToString();
            this.textBox3.Text = chonRow.Cells[2].Value.ToString();
            this.comboBox3.Text = chonRow.Cells[3].Value.ToString();
            this.textBox1.Text = chonRow.Cells[4].Value.ToString();

            SetControl(true);
            this.textBox2.Enabled = false;

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            // code sửa thông tin nhà xuất bản
            //lây thông tin nhà xuất bản
            NHAXB nxb = db.NHAXBs.FirstOrDefault(s => s.MaNXB == this.textBox2.Text);
            nxb.TenNXB = this.comboBox2.Text;
            nxb.Email = this.textBox3.Text;
            nxb.SoDT = this.textBox1.Text;
            nxb.DiaChi = this.comboBox3.Text;

            db.SubmitChanges();
            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            XoaNhap();
            LoadNXB();
            SetControl(true);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            ThuvienDataContext db = new ThuvienDataContext();
            var query = from book in db.NHAXBs
                        where book.MaNXB.Contains(textBox4.Text) || book.TenNXB.Contains(textBox4.Text)
                        select new { MaNXB = book.MaNXB, TenNXB = book.TenNXB, Email = book.Email, SoDT = book.SoDT, DiaChi = book.DiaChi };
            tableNhaXuatBan.DataSource = query.ToList();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NHAXB nxb = db.NHAXBs.FirstOrDefault(s => s.MaNXB == this.textBox2.Text);
            db.NHAXBs.DeleteOnSubmit(nxb);

            db.SubmitChanges();

            XoaNhap();
            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadNXB();
            SetControl(true);
            this.button5.Enabled = false;
        }
   }
}
        

