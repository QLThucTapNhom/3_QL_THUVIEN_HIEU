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
    public partial class GiaoDienChinh : Form
    {
        ThuvienDataContext db;
        public GiaoDienChinh()
        {
            InitializeComponent();
            db = new ThuvienDataContext();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            DangNhap f2 = new DangNhap();
            this.Hide();
            f2.ShowDialog();
        }

        private void đăngNhậpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DangNhap f2 = new DangNhap();
            this.Hide();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TacGia f4 = new TacGia();
            this.Hide();
            f4.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DocGia f5 = new DocGia();
            this.Hide();
            f5.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSach();
        }

        private void LoadSach()
        {
            this.tatcasach.DataSource = db.SACHes.ToList();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ThuvienDataContext db = new ThuvienDataContext();
            var query = from book in db.SACHes
                        where book.MaSach.Contains(textBox1.Text) || book.TenSach.Contains(textBox1.Text) || book.TacGia.Contains(textBox1.Text) || book.NhaXB.Contains(textBox1.Text) || book.TheLoai.Contains(textBox1.Text)
                        select new { MaSach = book.MaSach, TenSach = book.TenSach, TacGia = book.TacGia, NhaXB = book.NhaXB, TheLoai = book.TheLoai, SoTrang = book.SoTrang, GiaTien = book.GiaTien, TinhTrang = book.TinhTrang};
            tatcasach.DataSource = query.ToList();
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NXB f6 = new NXB();
            f6.ShowDialog();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NgươiQuanLy f7 = new NgươiQuanLy();
            f7.ShowDialog();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            QuanLySach f3 = new QuanLySach();
            this.Hide();
            f3.ShowDialog();
        }


      
    }
}
