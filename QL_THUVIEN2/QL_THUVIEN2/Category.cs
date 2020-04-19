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
            ma.Enabled = false;
            //  ketnoi();
            // HienThi();
            cls.KetNoi();
            cls.LoadData2DataGridView(dgv, "select *from THELOAI");
        }

        private void bttthemmoi_Click(object sender, EventArgs e)
        {
            bttqlnvxoa.Enabled = false;
            button1.Enabled = false;
            if(bttthemmoi.Text=="Add")
            {
                ma.Clear();
                ten.Clear();
                bttthemmoi.Text = "OK";
                ma.Focus();
                ma.Enabled = true;
                
                return;
            }
            if (bttthemmoi.Text=="OK")
            {
                
               //     string matl = "select COUNT(matl) from theloai WHERE matl='" + ma.Text + "'";
                    //  SqlCommand sl = new SqlCommand(matl, cnn);
                    //  cls.ThucThiSQLTheoKetNoi(mapm);
                    int slg = cls.CheckID("select COUNT(matl) from theloai WHERE matl='" + ma.Text + "'");
                        //(int)sl.ExecuteScalar();
                    if (slg > 0) MessageBox.Show("Category ID already exists!");
                    else if(ma.Text=="")
                {
                    MessageBox.Show("Category ID is empty!");
                }
                    else if(ten.Text=="")
                {
                    MessageBox.Show("Category's name is empty!");
                }
                    
                    else
                    {
                        string sql = "insert into THELOAI values('" + ma.Text + "',N'" + ten.Text + "')";
                        //  SqlCommand cmd = new SqlCommand(sql, cnn);
                        //  cmd.ExecuteNonQuery();
                        cls.ThucThiSQLTheoKetNoi(sql);
                        MessageBox.Show("Add category successfully!");
                        //   HienThi();
                        cls.LoadData2DataGridView(dgv, "select *from THELOAI");
                    }
                    ma.Enabled = false;
                    bttthemmoi.Text = "Add";
                    bttqlnvxoa.Enabled = true;
                    button1.Enabled = true;
                    return;
               

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttqlnvxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete?(Y/N)", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string cmd = "delete from THELOAI where MaTL='" + ma.Text + "'";
                cls.ThucThiSQLTheoKetNoi(cmd);
                //   cmd.ExecuteNonQuery();
                MessageBox.Show("Delete category successfully!");
            }
            //  HienThi();
            cls.LoadData2DataGridView(dgv, "select *from THELOAI");
        }

        private void dgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            try
            {
                ma.Text = dgv.Rows[i].Cells[0].Value.ToString().Trim();
                ten.Text = dgv.Rows[i].Cells[1].Value.ToString().Trim();
            }
            catch (Exception) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cmd= "update THELOAI set  TenTL=N'" + ten.Text + "' where MaTL='" + ma.Text + "' ";
            //  cmd.ExecuteNonQuery();
            cls.ThucThiSQLTheoKetNoi(cmd);
            MessageBox.Show("Edit category successfully!");
            // HienThi();
            cls.LoadData2DataGridView(dgv, "select *from THELOAI");
        }


    }
}
