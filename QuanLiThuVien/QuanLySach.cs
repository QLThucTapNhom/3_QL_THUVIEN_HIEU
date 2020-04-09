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
namespace QuanLiCuaHang
{
    public partial class QuanLySach : Form
    {
        ThuvienDataContext db;
        public QuanLySach()
        {
            InitializeComponent();
            db = new ThuvienDataContext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ThuvienDataContext db = new ThuvienDataContext();
            var query = from book in db.SACHes
                        where book.MaSach.Contains(textBox4.Text) || book.TenSach.Contains(textBox4.Text) || book.TacGia.Contains(textBox4.Text) || book.NhaXB.Contains(textBox4.Text) || book.TheLoai.Contains(textBox4.Text) 
                        select new { MaSach = book.MaSach, TenSach = book.TenSach, TacGia = book.TacGia, NhaXB = book.NhaXB, TheLoai = book.TheLoai, SoTrang = book.SoTrang, GiaTien = book.GiaTien, TinhTrang = book.TinhTrang };
            dataGridView1.DataSource = query.ToList();


           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadSach();
            SetControl(false);
        }

        private void SetControl(bool an)
        {
            this.button2.Enabled = an;
            this.button3.Enabled = an;
            this.button1.Enabled = !an;
        }

        private void LoadSach()
        {
            this.dataGridView1.DataSource = db.SACHes.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //code them moi sach
            //kiem tra thong tin nhap
            if (kiemtra() && ngoaile() && ckeckgia())
            {
                try
                {
                    //tao moi doi tuong sinh vien
                    SACH sach = new SACH();
                    sach.MaSach = this.textBox1.Text;
                    sach.TenSach = this.textBox2.Text;
                    sach.TacGia = this.comboBox1.Text;
                    sach.NhaXB = this.comboBox2.Text;
                    sach.TheLoai = this.comboBox4.Text;
                    sach.SoTrang = int.Parse(textBox6.Text);
                    sach.GiaTien = int.Parse(textBox3.Text);
                    sach.TinhTrang = this.comboBox5.Text;

                    //luu lai vao db
                    db.SACHes.InsertOnSubmit(sach);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm vào sách thành công");
                    //xoa thong tin nguoi khi nhap xong
                    XoaNhap();
                    LoadSach();   

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra trong quá trình thêm sách" + ex.Message);
                }
            }
        }

        public bool ckeckgia()
        {
            Regex regex = new Regex(@"^\d{5,6}$");
            bool valid = false;
            if (valid = regex.IsMatch(this.textBox3.Text))
            {
                valid = true;
            }
            else
            {
                MessageBox.Show("Nhập quá giá tiền cho phép");
                valid = false;
                this.textBox3.Text = "";
                textBox3.Focus();
            }
            return valid;
        }

        private bool ngoaile()
        {
           
            if((this.textBox1.Text).Length==2)
            {
            
            }
            else
            {
                MessageBox.Show("Nhập sai! Mã sách chỉ gồm 2 kí tự!");
                this.textBox1.Text = "";
                textBox1.Focus();
                return false;
            }
            return true;
            
        }


        private void XoaNhap()
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.comboBox1.Text = "";
            this.comboBox2.Text = "";
            this.comboBox4.Text = "";
            this.comboBox5.Text = "";
            this.textBox3.Text = "";
            this.textBox6.Text = "";
        }
        
        private bool kiemtra()
        {
            if(string.IsNullOrEmpty(this.textBox1.Text))
            {
                MessageBox.Show("Vui lòng nhập vào mã sách");
                return false;
            }
            if (string.IsNullOrEmpty(this.textBox2.Text))
            {
                MessageBox.Show("Vui lòng nhập vào tên sách");
                return false;
            }
            if (string.IsNullOrEmpty(this.comboBox1.Text))
            {
                MessageBox.Show("Vui lòng nhập vào tác giả");
                return false;
            }
            if (string.IsNullOrEmpty(this.comboBox2.Text))
            {
                MessageBox.Show("Vui lòng nhập vào nhà xuất bản");
                return false;
            }
            if (string.IsNullOrEmpty(this.comboBox4.Text))
            {
                MessageBox.Show("Vui lòng nhập vào thể loại");
                return false;
            }
            if(string.IsNullOrEmpty(this.textBox6.Text))
            {
                MessageBox.Show("Vui lòng nhập vào số trang");
                return false;
            }
            if(string.IsNullOrEmpty(this.textBox3.Text))
            {
                MessageBox.Show("Vui lòng nhập vào giá tiền");
                return false;
            }
            if (string.IsNullOrEmpty(this.comboBox5.Text))
            {
                MessageBox.Show("Vui lòng nhập vào tình trạng sách");
                return false;
            }
   
            return true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //xu ly su kien khi danh sach sinh vien duoc chon
            int chon = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow chonRow = dataGridView1.Rows[chon];

            this.textBox1.Text = chonRow.Cells[0].Value.ToString();
            this.textBox2.Text = chonRow.Cells[1].Value.ToString();
            this.comboBox1.Text = chonRow.Cells[2].Value.ToString();
            this.comboBox2.Text = chonRow.Cells[3].Value.ToString();
            this.comboBox4.Text = chonRow.Cells[4].Value.ToString();
            this.textBox6.Text = chonRow.Cells[5].Value.ToString();
            this.textBox3.Text = chonRow.Cells[6].Value.ToString();
            this.comboBox5.Text = chonRow.Cells[7].Value.ToString();

            SetControl(true);
            this.textBox1.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //sua thong tin nhan vien
            //lay tong tin nhan vien
            SACH sach = db.SACHes.FirstOrDefault(s => s.MaSach == this.textBox1.Text);
            sach.TenSach = this.textBox2.Text;
            sach.TacGia = this.comboBox1.Text;
            sach.NhaXB = this.comboBox2.Text;
            sach.TheLoai = this.comboBox4.Text;
            sach.SoTrang = int.Parse(textBox6.Text);
            sach.GiaTien = int.Parse(textBox3.Text);
            sach.TinhTrang = this.comboBox5.Text;

            

            db.SubmitChanges();
            MessageBox.Show("Sửa thành công");
            XoaNhap();
            LoadSach();
            SetControl(true);

        }

        private void button3_Click(object sender, EventArgs e)
        {

         SACH sach = db.SACHes.FirstOrDefault(s => s.MaSach == this.textBox1.Text);
         db.SACHes.DeleteOnSubmit(sach);

         db.SubmitChanges();

         XoaNhap();
         LoadSach();
         SetControl(true);
         this.button1.Enabled = false;
        }
        
        private void button4_Click_1(object sender, EventArgs e)
        {
            GiaoDienChinh f1 = new GiaoDienChinh();
            this.Hide();
            f1.ShowDialog();
        }

        public long sotrang { get; set; }

        public long maSV { get; set; }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
