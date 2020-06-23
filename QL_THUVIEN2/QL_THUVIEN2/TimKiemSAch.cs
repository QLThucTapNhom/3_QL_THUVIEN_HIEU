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
    public partial class TimKiemSach : Form
    {
        public TimKiemSach()
        {
            InitializeComponent();
        }
        clsDatabase cls = new QL_THUVIEN2.clsDatabase();

        private void TimKiemSach_Load(object sender, EventArgs e)
        {
            cls.KetNoi();
            cls.LoadData2DataGridView(dataGridView1, "select * from SACH");
            cls.LoadData2DataGridView(dataGridView2, "select * from DOCGIA");


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label8.Text = comboBox1.Text ;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (label8.Text == "Mã Sách")
            cls.LoadData2DataGridView(dataGridView1, "select*from Sach where masach like'%" + textBox1.Text + "%'");
            else if (label8.Text == "Tên Sách") cls.LoadData2DataGridView(dataGridView1, "select*from Sach where Tensach like'%" + textBox1.Text + "%'");
            else if (label8.Text == "Mã NXB") cls.LoadData2DataGridView(dataGridView1, "select*from Sach where manxb like'%" + textBox1.Text + "%'");
            else if (label8.Text == "Mã Thể Loại") cls.LoadData2DataGridView(dataGridView1, "select*from Sach where matl like'%" + textBox1.Text + "%'");
            else if (label8.Text == "Số Lượng") cls.LoadData2DataGridView(dataGridView1, "select*from Sach where soluong like'%" + textBox1.Text + "%'");
            else if (label8.Text == "Số Trang") cls.LoadData2DataGridView(dataGridView1, "select*from Sach where sotrang like'%" + textBox1.Text + "%'");
            else if (label8.Text == "SL Sách Hỏng") cls.LoadData2DataGridView(dataGridView1, "select*from Sach where sosachhong like'%" + textBox1.Text + "%'");
            else if (label8.Text == "Giá Sách") cls.LoadData2DataGridView(dataGridView1, "select*from Sach where gia like'%" + textBox1.Text + "%'");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            //  cls.LoadData2DataGridView(dataGridView2, "select*from docgia where Masach like'%" + textBox2.Text + "%'");
            if (label9.Text == "Mã ĐG")
            cls.LoadData2DataGridView(dataGridView2, "select*from docgia where MaDG like'%" + textBox2.Text + "%'");
            else if (label9.Text == "SĐT") cls.LoadData2DataGridView(dataGridView2, "select*from docgia where SDT_EMAIL like'%" + textBox2.Text + "%'");
            else if (label9.Text == "Tên ĐG") cls.LoadData2DataGridView(dataGridView2, "select*from docgia where TenDG like'%" + textBox2.Text + "%'");
            else if (label9.Text == "Giới Tính") cls.LoadData2DataGridView(dataGridView2, "select*from docgia where GioiTinh like'%" + textBox2.Text + "%'");
            else if (label9.Text == "Địa Chỉ") cls.LoadData2DataGridView(dataGridView2, "select*from docgia where DiaChi like'%" + textBox2.Text + "%'");
            else if (label9.Text == "Ngày Sinh") cls.LoadData2DataGridView(dataGridView2, "select*from docgia where NgaySinh like'%" + textBox2.Text + "%'");
        
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label9.Text = comboBox2.Text ;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
