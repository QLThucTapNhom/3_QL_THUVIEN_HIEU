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
    public partial class DocGia : Form
    {
        ThuvienDataContext db;
        public DocGia()
        {
            InitializeComponent();
            db = new ThuvienDataContext();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            LoadDocGia();
            SetControl(false);
        }

        private void SetControl(bool an)
        {
           
        }

        private void LoadDocGia()
        {
            this.tableDocGia.DataSource = db.DOCGIAs.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //code them moi docgia
            //kiem tra thong tin nhap
     
            if (kiemtra() && CkeckEmail() && ckeckSDT())
            {
                try
                {
                    //tao moi doi tuong sinh vien
                    DOCGIA docgia = new DOCGIA();
                    docgia.MASV = this.textBox1.Text;
                    docgia.TenSV = Chuanhoa(this.textBox2.Text);
                    docgia.GioiTinh = this.comboBox1.Text;
                    docgia.NgaySinh = this.dateTimePicker1.Value.Date;
                    docgia.MaLop = this.textBox4.Text;
                    docgia.TenLop = this.comboBox2.Text;
                    docgia.SoDT = this.textBox5.Text;
                    docgia.Email = this.textBox6.Text;
                    docgia.DiaChi = this.comboBox3.Text;

                    //luu lai vao db
                    db.DOCGIAs.InsertOnSubmit(docgia);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm vào sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //xoa thong tin nguoi khi nhap xong
                    XoaNhap();
                    LoadDocGia();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra trong quá trình thêm sách" + ex.Message);
                }
            }
        }

       /* private bool ngoaile()
        {
            if ((this.textBox1.Text).Length == 4)
            {
                
            }
            else
            {
                MessageBox.Show("Nhập sai! Mã sinh viên chỉ gồm 4 kí tự!");
                this.textBox1.Text = "";
                textBox1.Focus();
                return false;
            }

            if ((this.textBox4.Text).Length == 5)
            {

            }
            else
            {
                MessageBox.Show("Nhập sai! Mã lớp chỉ gồm 6 kí tự!");
                this.textBox4.Text = "";
                textBox1.Focus();
                return false;
            }
            return true;
            
        }*/

        public bool CkeckEmail()
        {
            string pattern = @"^[-a-zA-Z0-9][-.a-zA-Z0-9]*@[-.a-zA-Z0-9]+(\.[-.a-zA-Z0-9]+)*\.
             (com|edu|info|gov|int|mil|net|org|biz|name|museum|coop|aero|pro|tv|[a-zA-Z]{2})$";

            Regex check = new Regex(pattern, RegexOptions.IgnorePatternWhitespace);

            bool valid = false;
            if (string.IsNullOrEmpty(this.textBox6.Text))
            {
                valid = false;
  
            }
            
                if(valid = check.IsMatch(this.textBox6.Text))
                {
                    valid = true;
                }
                else
                {
                    MessageBox.Show("Nhập không đúng Email");
                    valid = false;
                    this.textBox6.Text = "";
                    textBox6.Focus();
                }
            
            return valid;
        }

        public static string Chuanhoa(string str)
        {
            CultureInfo cultureInfo = new CultureInfo("vi-VN");
            TextInfo textInfo = cultureInfo.TextInfo;
            str = textInfo.ToLower(str);
            // Replace multiple white space to 1 white  space
            str = System.Text.RegularExpressions.Regex.Replace(str, @"\s{2,}", " ");
            //Upcase like Title
            return textInfo.ToTitleCase(str);
        }

        public bool ckeckSDT()
        {
            Regex regex = new Regex(@"^\d{10,11}$");
            bool valid = false;
            if (valid = regex.IsMatch(this.textBox5.Text))
            {
                valid = true;
            }
            else
            {
                MessageBox.Show("Nhập không đúng số điện thoại");
                valid = false;
                this.textBox5.Text = "";
                textBox5.Focus();
            }
            return valid;
        }
        

        private bool kiemtra()
        {
            if (string.IsNullOrEmpty(this.textBox1.Text))
            {
                MessageBox.Show("Vui lòng nhập vào mã sinh viên");
                return false;
            }
            if (string.IsNullOrEmpty(this.textBox2.Text))
            {
                MessageBox.Show("Vui lòng nhập vào tên sinh viên");
                return false;
            }
            if (string.IsNullOrEmpty(this.comboBox1.Text))
            {
                MessageBox.Show("Vui lòng nhập vào giới tính");
                return false;
            }
            if (string.IsNullOrEmpty(this.dateTimePicker1.Text))
            {
                MessageBox.Show("Vui lòng nhập vào ngày sinh");
                return false;
            }
            if (string.IsNullOrEmpty(this.textBox4.Text))
            {
                MessageBox.Show("Vui lòng nhập vào mã lớp");
                return false;
            }
            if (string.IsNullOrEmpty(this.comboBox2.Text))
            {
                MessageBox.Show("Vui lòng nhập vào tên lớp");
                return false;
            }
            if (string.IsNullOrEmpty(this.textBox5.Text))
            {
                MessageBox.Show("Vui lòng nhập vào số điện thoại");
                return false;
            }
            if (string.IsNullOrEmpty(this.textBox6.Text))
            {
                MessageBox.Show("Vui lòng nhập vào email");
                return false;
            }
            if (string.IsNullOrEmpty(this.comboBox3.Text))
            {
                MessageBox.Show("Vui lòng nhập vào địa chỉ");
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
            this.dateTimePicker1.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "";
            this.textBox6.Text = "";
            this.comboBox3.Text = "";

        }
  
        private void tableDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //xu ly su kien khi danh sach sinh vien duoc chon
            int chon = tableDocGia.SelectedCells[0].RowIndex;
            DataGridViewRow chonRow = tableDocGia.Rows[chon];

            this.textBox1.Text = chonRow.Cells[0].Value.ToString();
            this.textBox2.Text = chonRow.Cells[1].Value.ToString();
            this.comboBox1.Text = chonRow.Cells[2].Value.ToString();
            this.dateTimePicker1.Text = chonRow.Cells[3].Value.ToString();
            this.textBox4.Text = chonRow.Cells[4].Value.ToString();
            this.comboBox2.Text = chonRow.Cells[5].Value.ToString();
            this.textBox5.Text = chonRow.Cells[6].Value.ToString();
            this.textBox6.Text = chonRow.Cells[7].Value.ToString();
            this.comboBox3.Text = chonRow.Cells[8].Value.ToString();

            SetControl(true);
            this.textBox1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //sua thong tin nhan vien
            //lay tong tin nhan vien
            DOCGIA docgia = db.DOCGIAs.FirstOrDefault(s => s.MASV == this.textBox1.Text);
            docgia.MASV = this.textBox1.Text;
            docgia.TenSV = this.textBox2.Text;
            docgia.GioiTinh = this.comboBox1.Text;
            docgia.NgaySinh = this.dateTimePicker1.Value.Date;
            docgia.MaLop = this.textBox4.Text;
            docgia.TenLop = this.comboBox2.Text;
            docgia.SoDT = this.textBox5.Text;
            docgia.Email = this.textBox6.Text;
            docgia.DiaChi = this.comboBox3.Text;



            db.SubmitChanges();
            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            XoaNhap();
            LoadDocGia();
            SetControl(true);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DOCGIA docgia = db.DOCGIAs.FirstOrDefault(s => s.MASV == this.textBox1.Text);
            db.DOCGIAs.DeleteOnSubmit(docgia);

            db.SubmitChanges();

            XoaNhap();
            LoadDocGia();
            SetControl(true);
            this.button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThuvienDataContext db = new ThuvienDataContext();
            var query = from book in db.DOCGIAs
                        where book.MASV.Contains(textBox8.Text) || book.TenSV.Contains(textBox8.Text) || book.GioiTinh.Contains(textBox8.Text) || book.MaLop.Contains(textBox8.Text) || book.TenLop.Contains(textBox8.Text) || book.DiaChi.Contains(textBox8.Text) || book.Email.Contains(textBox8.Text) || book.SoDT.Contains(textBox8.Text)
                        select new { MaSV = book.MASV, TenSV = book.TenSV, GioiTinh = book.GioiTinh, NgaySinh = book.NgaySinh, MaLop = book.MaLop, TenLop = book.TenLop, SoDT = book.SoDT, Email = book.Email, DiaChi = book.DiaChi };
            tableDocGia.DataSource = query.ToList();

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
            if (dateTimePicker1.Value > DateTime.Now)
            {
                MessageBox.Show("Vượt quá thời gian hiện tại");
                dateTimePicker1.Value = DateTime.Now.AddDays(-1);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Chuanhoa(this.textBox2.Text);
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
