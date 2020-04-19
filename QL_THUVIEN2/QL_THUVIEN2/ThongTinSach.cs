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
    public partial class ThongTinSach : Form
    {
        public ThongTinSach()
        {
            InitializeComponent();
        }
        clsDatabase cls = new QL_THUVIEN2.clsDatabase();
        
        string matl,manxb;
        private void HienThi()
        {        
            cls.LoadData2DataGridView(dgvsach, "select *from sach");
        }
      
        private void loadmanxb()
        {          
            cls.Load1Combo(txtnxb, "select * from NXB");
            txtnxb.DisplayMember = "TenNXB";
            txtnxb.ValueMember = "MaNXB";
        }
        private void loadtl()
        {
            cls.Load1Combo(txttheloai, "select*from theloai");
            txttheloai.DisplayMember = "TenTL";
            txttheloai.ValueMember = "MaTL";
        }
      
        private void Form4_Load(object sender, EventArgs e)
        {
            cls.KetNoi();
            HienThi();
            loadmanxb();

            loadtl();
            
            txtnxb_SelectedIndexChanged(sender, e);
            txttheloai_SelectedIndexChanged(sender, e);
        }
        private void update()
        {


         string cmd = "update SACH set TenSach=N'" + txtten.Text + "',Gia=" + txtgia.Text + ",MaNXB='" + manxb + "',MaTL=N'" + matl + "',SoLuong=" + txtSoluong.Text + ",SoTrang="+txtSotrang.Text+",SoSachHong="+txthong.Text+" where MaSach='" + txtma.Text + "'";
 
            cls.ThucThiSQLTheoKetNoi(cmd);
        }
        private void insert()
        {
         
               
                string sql = "insert into SACH values('" + txtma.Text + "',N'" + txtten.Text + "','" + txtgia.Text + "','" + manxb + "','"+matl+"','"+(txtSoluong.Text)+"','"+txtSotrang.Text+"','"+txthong.Text+"')";
               
                cls.ThucThiSQLTheoKetNoi(sql);
           
           
        }
        private void delete()
        {
            string sql = "delete from SACH where MaSach='" + txtma.Text + "'";
            cls.ThucThiSQLTheoKetNoi(sql);
        }

        private void bttttcnluu_Click(object sender, EventArgs e)
        {

            if (bttttcnluu.Text == "Thêm")
            {
                txttheloai.Text = "";
                txtgia.Clear();
                txtma.Clear();
                txthong.Clear();
                txtSoluong.Clear();
                txtSotrang.Clear();
                txtnxb.Text = "";
                txtten.Clear();
                txtma.Focus();
                txtma.Enabled = true;
                bttttcnluu.Text = "OK";
           
            }
            else
            {
                int slg = cls.CheckID("select COUNT(masach) from sach WHERE masach='" + txtma.Text + "'");
                //(int)sl.ExecuteScalar();
                if (slg > 0) MessageBox.Show("Mã sách đã tồn tại!");
                else if(txtma.Text=="")
                {
                    MessageBox.Show("Mã sách trống!");
                }
                else  if(txtten.Text=="")
                {
                    MessageBox.Show("Tên sách trống!");
                }
                txtma.Enabled = false;
                insert();
                MessageBox.Show("Add book successully!");
                HienThi();
                bttttcnluu.Text = "Thêm";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            update();
            MessageBox.Show("Edit book successfully!");
            HienThi();
        }

        private void bttqlnvxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete?(Y/N)", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string delete1 = "DELETE TRASACH WHERE MASACH='" + txtma.Text + "'";
                cls.ThucThiSQLTheoKetNoi(delete1);
                string delete2 = "DELETE QL_PHIEUMUON WHERE MASACH='"+ txtma.Text + "'";
                cls.ThucThiSQLTheoKetNoi(delete2);
             //   string delete3 = "delete from phieumuon where MaDG='" + txtma.Text + "'";
              //  cls.ThucThiSQLTheoKetNoi(delete3);
                delete();
                HienThi();
            }
        }

        private void dgvsach_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            int i = e.RowIndex;
            try {

                txtma.Text = dgvsach.Rows[i].Cells[0].Value.ToString().Trim();
                txtten.Text = dgvsach.Rows[i].Cells[1].Value.ToString().Trim();
                txtgia.Text = dgvsach.Rows[i].Cells[2].Value.ToString().Trim();
                txtnxb.SelectedValue = dgvsach.Rows[i].Cells[3].Value.ToString().Trim();
                txttheloai.SelectedValue = dgvsach.Rows[i].Cells[4].Value.ToString().Trim();
             
                txtSoluong.Text = dgvsach.Rows[i].Cells[5].Value.ToString().Trim();
                txtSotrang.Text = dgvsach.Rows[i].Cells[6].Value.ToString().Trim();
                txthong.Text = dgvsach.Rows[i].Cells[7].Value.ToString().Trim();

            }
            catch (Exception ) {  }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtnxb_SelectedIndexChanged(object sender, EventArgs e)
        {
            manxb = txtnxb.SelectedValue.ToString();

        }

        private void txttheloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            matl = txttheloai.SelectedValue.ToString();

        }

    }
}
