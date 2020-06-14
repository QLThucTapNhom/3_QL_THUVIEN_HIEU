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
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }
        clsDatabase cls = new QL_THUVIEN2.clsDatabase();
       
     
        private void Form9_Load(object sender, EventArgs e)
        {
           
            cls.KetNoi();
            cls.LoadData2DataGridView(dgv, "select *from THELOAI");
           
        }

        private void bttthemmoi_Click(object sender, EventArgs e)
        {
            string matl = txtma.Text.Trim();
            string tentl = txtten.Text.Trim();

            if(matl.Length != 0 && tentl.Length != 0)
            {
                int temp = cls.CheckID("select COUNT(matl) from theloai WHERE matl='" +matl + "'");
                if (temp > 0)
                {
                    MessageBox.Show("Mã thể loại đã tồn tại!");
                }
                else
                {
                    string insert = "insert into THELOAI values('" + matl + "',N'" + tentl + "')";
                    cls.ThucThiSQLTheoKetNoi(insert);
                    MessageBox.Show("Thêm thành công!");
                    cls.LoadData2DataGridView(dgv, "select *from THELOAI");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin để hoàn tất!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttqlnvxoa_Click(object sender, EventArgs e)
        {
            string matl = txtma.Text.Trim();
            if (MessageBox.Show("Do you want to delete?(Y/N)", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string del = "delete THELOAI where MaTL = '" + matl + "'";
                cls.ThucThiSQLTheoKetNoi(del);
                MessageBox.Show("Xóa Thành công!");
            }
            cls.LoadData2DataGridView(dgv, "select *from THELOAI");
        }

        private void dgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            try
            {
                txtma.Text = dgv.Rows[i].Cells[0].Value.ToString().Trim();
                txtten.Text = dgv.Rows[i].Cells[1].Value.ToString().Trim();
            }
            catch (Exception) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string matl = txtma.Text.Trim();
            string tentl = txtten.Text.Trim();
            if (matl.Length != 0 && tentl.Length != 0)
            {
                int temp = cls.CheckID("select COUNT(matl) from theloai WHERE matl='" + matl + "'");
                if (temp > 0)
                {
                    if (MessageBox.Show("Do you want to update?(Y/N)", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string update = "update THELOAI set  TenTL=N'" + txtten.Text + "' where MaTL='" + txtma.Text + "' ";
                        cls.ThucThiSQLTheoKetNoi(update);
                        MessageBox.Show("Edit category successfully!");
                        cls.LoadData2DataGridView(dgv, "select *from THELOAI");
                    }
                }
                else
                {
                    MessageBox.Show("Mã thể loại chưa tồn tại! Không thể sửa");
                }

            }
        }

    }
}
