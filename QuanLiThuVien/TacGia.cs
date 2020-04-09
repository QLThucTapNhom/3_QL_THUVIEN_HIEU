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
    public partial class TacGia : Form
    {
        ThuvienDataContext db;
        public TacGia()
        {
            InitializeComponent();
            db = new ThuvienDataContext();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadTacGia();
            SetControl(false);
        }

        private void SetControl(bool an)
        {
            this.button2.Enabled = !an;
            this.button3.Enabled = an;
            this.button1.Enabled = an;
        }

        private void LoadTacGia()
        {
            this.tableTG.DataSource = db.TACGIAs.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
      
            //code them moi docgia
            //kiem tra thong tin nhap
            if (kiemtra() && ngoaile())
            {
                try
                {
                    //tao moi doi tuong sinh vien
                    TACGIA tacgia = new TACGIA();
                    tacgia.MaTG = this.textBox1.Text;
                    tacgia.TenTG = this.comboBox1.Text;
                    tacgia.TenSach = this.comboBox2.Text;
                    tacgia.NgayXB = this.dateTimePicker1.Value.Date;

                    //luu lai vao db
                    db.TACGIAs.InsertOnSubmit(tacgia);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm vào tác giả thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //xoa thong tin nguoi khi nhap xong
                    XoaNhap();
                    LoadTacGia();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra trong quá trình thêm tác giả" + ex.Message);
                }
            }
        }


        private bool ngoaile()
        {

            if ((this.textBox1.Text).Length == 2)
            {
                MessageBox.Show("Nhập đúng mã tác giả");
            }
            else
            {
                MessageBox.Show("Nhập sai! Mã tác giả chỉ gồm 2 kí tự!");
                this.textBox1.Text = "";
                textBox1.Focus();
                return false;
            }
            return true;
        }

        private void XoaNhap()
        {
            this.textBox1.Text = "";
            this.comboBox1.Text = "";
            this.comboBox2.Text = "";
            this.dateTimePicker1.Text = "";
        }

        private bool kiemtra()
        {
            if (string.IsNullOrEmpty(this.textBox1.Text))
            {
                MessageBox.Show("Vui lòng nhập vào mã tác giả");
                return false;
            }
           
            if (string.IsNullOrEmpty(this.comboBox1.Text))
            {
                MessageBox.Show("Vui lòng nhập vào tên tác giả");
                return false;
            }
            if (string.IsNullOrEmpty(this.comboBox2.Text))
            {
                MessageBox.Show("Vui lòng nhập vào tên sách");
                return false;
            }
            if (string.IsNullOrEmpty(this.dateTimePicker1.Text))
            {
                MessageBox.Show("Vui lòng nhập vào ngày xuất bản");
                return false;
            }
            return true;
        }

        private void tableTG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //xu ly su kien khi danh sach sinh vien duoc chon
            int chon = tableTG.SelectedCells[0].RowIndex;
            DataGridViewRow chonRow = tableTG.Rows[chon];

            this.textBox1.Text = chonRow.Cells[0].Value.ToString();
            this.comboBox1.Text = chonRow.Cells[1].Value.ToString();
            this.comboBox2.Text = chonRow.Cells[2].Value.ToString();
            this.dateTimePicker1.Text = chonRow.Cells[3].Value.ToString();

            SetControl(true);
            this.textBox1.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //sua thong tin nhan vien
            //lay tong tin nhan vien
            TACGIA tacgia = db.TACGIAs.FirstOrDefault(s => s.MaTG == this.textBox1.Text);
            tacgia.TenTG = this.comboBox1.Text;
            tacgia.TenSach = this.comboBox2.Text;
            tacgia.NgayXB = this.dateTimePicker1.Value.Date;

            db.SubmitChanges();
            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            XoaNhap();
            LoadTacGia();
            SetControl(true);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TACGIA tacgia = db.TACGIAs.FirstOrDefault(s => s.MaTG == this.textBox1.Text);
            db.TACGIAs.DeleteOnSubmit(tacgia);

            db.SubmitChanges();

            XoaNhap();
            LoadTacGia();
            SetControl(true);
            this.button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThuvienDataContext db = new ThuvienDataContext();
            var query = from book in db.TACGIAs
                        where book.MaTG.Contains(textBox2.Text) || book.TenTG.Contains(textBox2.Text) || book.TenSach.Contains(textBox2.Text)
                        select new { MaTG = book.MaTG, TenTG = book.TenTG, TenSach = book.TenSach, NgayXB = book.NgayXB };
            tableTG.DataSource = query.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GiaoDienChinh f1 = new GiaoDienChinh();
            this.Hide();
            f1.ShowDialog();
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Now;
            if(dateTimePicker1.Value > DateTime.Now)
            {
                MessageBox.Show("Vượt quá thời gian hiện tại");
                dateTimePicker1.Value = DateTime.Now.AddDays(-1);
            }
        }

       
    }
}
