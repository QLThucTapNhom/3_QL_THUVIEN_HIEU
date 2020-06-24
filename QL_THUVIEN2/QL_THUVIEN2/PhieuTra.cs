using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_THUVIEN2
{
    public partial class PhieuTra : Form
    {
        int k=0;
        public PhieuTra()
        {
            InitializeComponent();
        }
        clsDatabase cls = new QL_THUVIEN2.clsDatabase();
     
        private void Form7_Load(object sender, EventArgs e)
        {
            pnmasach.Enabled = false;
            pnmanv.Enabled = false;
            pnmaphieu.Enabled = false;
            // ketnoi();
            cls.KetNoi();
            cls.LoadData2DataGridView(dgvpn1, "select *from TRASACH");
            //  i = 1;
            //    HienThi();
           
            
        }
        private void update_TS()
        {
            string s = pnngaytra.Value.Year + "/" + pnngaytra.Value.Month + "/" + pnngaytra.Value.Day;
            string sql = "update TRASACH set NgayTra=convert(smalldatetime,'" + s.ToString() + "'),PhatQuaHan='" + pnphat.Text + "' where MaPM='" + pnmaphieu.Text + "' and MaSach='" + pnmasach.Text + "' ";

            cls.ThucThiSQLTheoKetNoi(sql);
        }
        private void insert()
        {

            string s = pnngaytra.Value.Year + "/" + pnngaytra.Value.Month + "/" + pnngaytra.Value.Day;
            string sql = "insert into TRASACH (MaPM,MaSach,TaiKhoan,NgayTra,PhatQuaHan) values('" + pnmaphieu.Text + "','" + pnmasach.Text + "','" + pnmanv.Text + "',convert(smalldatetime,'" + s.ToString() + "'),'" + pnphat.Text + "')";

            cls.ThucThiSQLTheoKetNoi(sql);
        }
        private void delete()
        {
            string sql = "delete from TRASACH where MaPM='" + pnmaphieu.Text + "' and MaSach='" + pnmasach.Text + "'";

            cls.ThucThiSQLTheoKetNoi(sql);
        }
        private void delete_mp()
        {

            string cmd = "delete from MAPHIEU where MaPM='" + pnmaphieu.Text + "'";

            cls.ThucThiSQLTheoKetNoi(cmd);
            string cmd1 = "delete from QL_PHIEUMUON where MaPM='" + pnmaphieu.Text + "'";

            cls.ThucThiSQLTheoKetNoi(cmd1);
        }
        private void combobox()
        {

            cls.KetNoi();

            cls.LoadCombo(pnmaphieu, "select MaPM from PHIEUMUON");

            cls.LoadCombo(pnmasach, "select MaSach from SACH ");

            cls.LoadCombo(pnmanv, "select MaNV from NHANVIEN");

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvpn1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void bttqlnvxoa_Click(object sender, EventArgs e)
        {
            string cmd = "update SACH set TinhTrang=0 where MaSach='" + pnmasach.Text + "'";
            //  cmd.ExecuteNonQuery();
            cls.ThucThiSQLTheoKetNoi(cmd);
            string cmd1 = "delete from QL_PHIEUMUON where MaPM='" + pnmaphieu.Text + "' and MaSach='" + pnmasach.Text + "'";
            //  cmd1.ExecuteNonQuery();
            cls.ThucThiSQLTheoKetNoi(cmd1);
            delete();
            //HienThi();
            cls.LoadData2DataGridView(dgvpn1, "select*from TRASACH");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            update_TS();
            // HienThi();
            cls.LoadData2DataGridView(dgvpn1, "select*from TRASACH");
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            cls.LoadData2DataGridView(dgvpn1, "select * from TRASACH where mapm='" + textBox1.Text + "'");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cls.LoadData2DataGridView(dgvpn1, "select*from TRASACH");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (k == 1 && pnphat.Text == "0")
            {
                MessageBox.Show("Fine isn't update!");
            }
            else if (pnphat.Text == "")
            {
                MessageBox.Show("Please choose book will be returned!");
            }
            else
            {
                string cmd = "update SACH set SoLuong = SoLuong +(select soluongSm from ql_phieumuon where MaSach='" + pnmasach.Text + "' and Mapm='" + pnmaphieu.Text + "') from sach where MaSach='" + pnmasach.Text + "'";
                cls.ThucThiSQLTheoKetNoi(cmd);
                string cmd1 = "delete from QL_PHIEUMUON where MaPM='" + pnmaphieu.Text + "' and MaSach='" + pnmasach.Text + "'";
                cls.ThucThiSQLTheoKetNoi(cmd1);
                delete();
                MessageBox.Show("Trả sách thành công!");
                pnphat.Text = "";
                pnmaphieu.Text = "";
                pnmasach.Text = "";
                pnmanv.Text = "";
                k = 0;
                cls.LoadData2DataGridView(dgvpn1, "select*from dbo.TRASACH");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pnmanv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvpn1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            try
            {
                pnmaphieu.Text = dgvpn1.Rows[i].Cells[0].Value.ToString().Trim();
                pnmasach.Text = dgvpn1.Rows[i].Cells[1].Value.ToString().Trim();
                pnmanv.Text = dgvpn1.Rows[i].Cells[2].Value.ToString().Trim();
                DateTime dt = Convert.ToDateTime(dgvpn1.Rows[i].Cells[3].Value.ToString());
                pnngaytra.Value = dt;
                pnphat.Text = dgvpn1.Rows[i].Cells[4].Value.ToString().Trim();

                DateTime y = DateTime.Now;
                if ((y.Month - pnngaytra.Value.Month > 0) || ((y.Day - pnngaytra.Value.Day > 0) && (y.Month == pnngaytra.Value.Month) && pnphat.Text == "0"))

                {
                    MessageBox.Show("Borrow-card " + pnmaphieu.Text + " borrow book " + pnmasach.Text + " out of date! ");
                    k = 1;
                    return;

                }
                k = 0;
            }
            catch (Exception) { }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void pnmaphieu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvpn1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnngaytra_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
