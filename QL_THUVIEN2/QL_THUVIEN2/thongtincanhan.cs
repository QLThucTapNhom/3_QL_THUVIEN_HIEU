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
    public partial class thongtincanhan : Form
    {
        public thongtincanhan()
        {
            InitializeComponent();
        }
        clsDatabase cls = new QL_THUVIEN2.clsDatabase();
        //private void ketnoi()
        //{
        //    string ketnoi = @"Data Source=LAPTOP88-PC\SQLEXPRESS;Initial Catalog=DA_QLTV;Integrated Security=True";
        //    cnn = new SqlConnection(ketnoi);
        //    cnn.Open();
        //}
     //   SqlConnection cnn;
        private void HienThi()
        {
           
            cls.LoadData2DataGridView(dataGridView1, "select TaiKhoan, TenNV, GioiTinh, DiaChi, SDT_EMAIL, NgaySinh from NHANVIEN where TAIKHOAN = '" + Form1.tendn + "'");
        }

        private void thongtincanhan_Load(object sender, EventArgs e)
        {
            cls.KetNoi();
           // ketnoi();
            HienThi();
        }

      

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtSoDienThoai.Text.Length - 1 <= 0)
                MessageBox.Show("Phone number cannot be smaller than 0!");
           else if (txtSoDienThoai.Text.ToString().Trim().Length - 1 >=12)
            {
                MessageBox.Show("Phone number cannot be bigger than 12 ");

            }
            else
            {

                string s = txtns.Value.Year + "/" + txtns.Value.Month + "/" + txtns.Value.Day;
                string cmd ="update NHANVIEN set TenNV=N'" + textBox1.Text + "',GioiTinh=N'" + txtGIOITINH.Text + "',DiaChi=N'" + txtDiaChi.Text + "',NgaySinh=N'" + s + "',SDT_EMAIL=N'" + txtSoDienThoai.Text  + "' where TAIKHOAN='" + Form1.tendn + "'";
                //    cmd.ExecuteNonQuery();
                cls.ThucThiSQLTheoKetNoi(cmd);
                HienThi();
                MessageBox.Show("Edit staff successfully!");
            }
        }


        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //int i = e.RowIndex;
            ////    bttqltk.Visible = true;
           
            //textBox1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            //txtDiaChi.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            //txtSoDienThoai.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            //DateTime dt1 = Convert.ToDateTime(dataGridView1.Rows[i].Cells[5].Value.ToString());
            //txtns.Value = dt1;
            ////txtns.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            //txtGIOITINH.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int a;
            a = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[a].Cells[1].Value.ToString();
            txtGIOITINH.Text = dataGridView1.Rows[a].Cells[2].Value.ToString();
            txtDiaChi.Text = dataGridView1.Rows[a].Cells[3].Value.ToString();
            txtSoDienThoai.Text = dataGridView1.Rows[a].Cells[4].Value.ToString();
            DateTime dt1 = Convert.ToDateTime(dataGridView1.Rows[a].Cells[5].Value.ToString());
            txtns.Value = dt1;
            
           
        }
        

    }
}
