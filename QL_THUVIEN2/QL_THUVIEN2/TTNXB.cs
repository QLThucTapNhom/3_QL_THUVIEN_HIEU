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
    public partial class TTNXB : Form
    {
       
        clsDatabase cls = new QL_THUVIEN2.clsDatabase();
        public TTNXB()
        {
            InitializeComponent();
        }
    
        private void HienThi()
        {
       
            cls.LoadData2DataGridView(dgvnxb, "select*from NXB");
            
        }


        private void insert()
       {

            string sql="insert into NXB values('"+txtma.Text+"',N'"+txtten.Text+"',N'"+txtdiachi.Text+"','"+txtsdt.Text+"')";
            cls.ThucThiSQLTheoKetNoi(sql);
       }
        private void delete()
        {
            string sql = "delete from NXB where MaNXB='" + txtma.Text + "'";
            //   SqlCommand cmd = new SqlCommand(sql, cnn);
            // cmd.ExecuteNonQuery();
            cls.ThucThiSQLTheoKetNoi(sql);
        }
        private void update()
        {
            string cmd= "update NXB set TenNXB=N'" + txtten.Text + "',DiaChi=N'" + txtdiachi.Text + "',SDT_EMAIL='" + txtsdt.Text + "' where MaNXB='" + txtma.Text + "'";
            //cmd.ExecuteNonQuery();
            cls.ThucThiSQLTheoKetNoi(cmd);
        }
        private void dgvnxb_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            try
            {
                txtma.Text = dgvnxb.Rows[i].Cells[0].Value.ToString().Trim();
                txtten.Text = dgvnxb.Rows[i].Cells[1].Value.ToString().Trim();
                txtdiachi.Text = dgvnxb.Rows[i].Cells[2].Value.ToString().Trim();
                txtsdt.Text = dgvnxb.Rows[i].Cells[3].Value.ToString().Trim();
            }
            catch (Exception a) { MessageBox.Show(a.Message); }
        }
        
        private void bttttcnluu_Click(object sender, EventArgs e)
        {
           
            if (bttthem.Text == "Add")
            {
                txtma.Enabled = true;
                txtdiachi.Clear();
                txtma.Clear();
                txtsdt.Clear();
                txtten.Clear();
                button1.Enabled = false;
                bttqlnvxoa.Enabled = false;
                bttthem.Text = "OK";
            }
            else
            {
                bttthem.Text = "Add";
                button1.Enabled = true;
                bttqlnvxoa.Enabled = true;
                txtma.Enabled = false;
                int slg = cls.CheckID("select COUNT(manxb) from NXB WHERE maNXB='" + txtma.Text + "'");
                //(int)sl.ExecuteScalar();
                if (slg > 0) MessageBox.Show("Mã NXB đã tồn tại!");
                else if(txtma.Text=="")
                   { MessageBox.Show("Mã NXB trống!"); }
                else if (txtten.Text=="")
                    {
                    MessageBox.Show("Tên NXB trống");
                }
                else
                {
                    insert();
                    MessageBox.Show(" Thêm thành công!");
                }
                HienThi();
            }
        }

 
        private void bttqlnvxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete?(Y/N)", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                delete();
                HienThi();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            update();
            MessageBox.Show("Sửa thành công!");
            HienThi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            txtma.Enabled = false;
            //   ketnoi();
            cls.KetNoi();
            HienThi();
        }

        private void paneldg_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dgvnxb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int a;
            a = dgvnxb.CurrentRow.Index;
            txtma.Text = dgvnxb.Rows[a].Cells[0].Value.ToString();
            txtten.Text = dgvnxb.Rows[a].Cells[1].Value.ToString();
            txtdiachi.Text = dgvnxb.Rows[a].Cells[2].Value.ToString();
            txtsdt.Text = dgvnxb.Rows[a].Cells[3].Value.ToString();
         
        }
    }
}
