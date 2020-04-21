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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        clsDatabase cls = new clsDatabase();
        string tk;  
  
        private void HienThi()
        {
            cls.LoadData2DataGridView(dgvnvdanhsach, "select TaiKhoan,TenNV,GioiTinh,DiaChi,SDT_EMAIL,NgaySinh from NHANVIEN");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            paneldangnhap.Hide();
            paneldsnv.Enabled = false;
            panelqlphieu.Enabled = false;
            panelqldocgia.Enabled = false;
            panelbaocao.Enabled = false;
            panelqlnhanvien.Enabled = false;
            panelbaocao.Enabled = false;
            //     panelqldocgia.Enabled = false;
            panelqlsach.Enabled = false;
            cls.KetNoi();
            ttcnma.Enabled = false;
           
           
            
        }
        private void update()
        {           
            string s = ttcnngaysinh.Value.Year + "/" + ttcnngaysinh.Value.Month + "/" + ttcnngaysinh.Value.Day;
           string cmd = "update NHANVIEN set TenNV=N'" + ttcnten.Text + "',GioiTinh=N'" + ttcngioitinh.Text + "',DiaChi=N'" + ttcndiachi.Text + "',SDT_EMAIL='" + ttcnsdt.Text + "',NgaySinh=convert(smalldatetime,'" + s.ToString() + "') where Taikhoan='"+ttcnma.Text+"'";
            //  cmd.ExecuteNonQuery();
            cls.ThucThiSQLTheoKetNoi(cmd);

        }
        private void delete()
        {
           
                string sql = "delete from NHANVIEN where TaiKhoan='" + ttcnma.Text + "'";
                cls.ThucThiSQLTheoKetNoi(sql);
            
        }
        private void insert()
        {
           
             
            string tk = "select COUNT(TaiKhoan) from NHANVIEN WHERE TaiKhoan='" + ttcnma.Text + "'";
                int slg = cls.CheckID(tk);
                //(int)sl.ExecuteScalar();
                if (slg > 0) MessageBox.Show("Tài khoản này đã tồn tại");
                else
                {
                    string s = ttcnngaysinh.Value.Year + "/" + ttcnngaysinh.Value.Month + "/" + ttcnngaysinh.Value.Day;
                    string sql =
                        "insert into NHANVIEN(TaiKhoan,TenNV,GioiTinh,DiaChi,SDT_EMAIL,NgaySinh) values('" + ttcnma.Text + "',N'" + ttcnten.Text + "',N'" + ttcngioitinh.Text + "',N'" + ttcndiachi.Text + "','" + ttcnsdt.Text + "'," + s + ")";

                    
                    cls.ThucThiSQLTheoKetNoi(sql);
                }
            
         
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                paneldangnhap.Hide();
                paneldsnv.Visible = false;
                panelqlphieu.Enabled = false;
                panelqldocgia.Enabled = false;
                panelbaocao.Enabled = false;
                panelqlnhanvien.Enabled = false;
                bttdangnhap.Enabled = true;
                MessageBox.Show("Bạn đã đăng xuất!");
                lbThongBao.Show();
            } 
            //panel6.Visible=true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Reader rd = new Reader();

            rd.ShowDialog();
        }


        private void button8_Click(object sender, EventArgs e)
        {
            
            TTTaiKhoan frm= new TTTaiKhoan();
            frm.Message = txtdntaikhoan.Text;
            frm.MK = txtdnmatkhau.Text;
            frm.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ThongTinSach frm4 = new ThongTinSach();

            frm4.ShowDialog();
        }


        private void button16_Click(object sender, EventArgs e)
        {
            new QuanLymuon().ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        // mat khau//
        public static string tendn, matkhau, quyen;
    //    SqlCommand sqlCommand;

     
        private void button22_Click(object sender, EventArgs e)
        {
            
            cls.KetNoi();
            tendn = txtdntaikhoan.Text;
            matkhau = txtdnmatkhau.Text;
            if (tendn != "")
            {
                object Q = cls.layGiaTri("select Quyenhan from NHANVIEN where TaiKhoan = '" + tendn + "' and MatKhau = '" + matkhau + "'");
                if (Q == null)
                {
                    MessageBox.Show("Tài khoản mật khẩu không đúng!","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    txtdntaikhoan.Clear();
                    txtdnmatkhau.Clear();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thành công!","",MessageBoxButtons.OK);
                    quyen = Convert.ToString(Q);
                    if (quyen == "admin")
                    {
                        paneldsnv.Enabled = true;
                        panelqlphieu.Enabled = true;
                        panelqldocgia.Enabled = true;
                        panelbaocao.Enabled = true;
                        panelqlnhanvien.Enabled = true;
                        button7.Enabled = true;
                        paneldangnhap.Hide();
                        panelbaocao.Enabled = true;
                        panelqlnhanvien.Enabled = true;
                        panelqlsach.Enabled = true;

                    }
                    if (quyen == "user")
                    {
                      
                        panelqlphieu.Enabled = true;
                        panelqldocgia.Enabled = true;
                        panelbaocao.Enabled = true;
                        panelqlnhanvien.Enabled = true;
                        button7.Enabled = false;
                        panelbaocao.Enabled = true;
                        panelqlnhanvien.Enabled = true;
                        //  button8.Enabled = false;
                        paneldangnhap.Hide();
                        panelqlsach.Enabled = true;
                    }
                }

            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            paneldangnhap.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbThongBao.Hide();
            txtdnmatkhau.Clear();
            txtdntaikhoan.Clear();
            paneldangnhap.Visible = true;
            txtdntaikhoan.Focus();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            paneldsnv.Visible = true;
            HienThi();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            cls.KetNoi();
            paneldsnv.Visible = true;
            HienThi();

        }

       
        private void bttttcnluu_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        
            update();
            MessageBox.Show("Edit staff successfully!");
            HienThi();
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            //  bttqltk.Hide();
            if (MessageBox.Show("Do you want to delete?(Y/N)", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                delete();
                HienThi();
            }
        }

   
        private void button11_Click(object sender, EventArgs e)
        {
            TTNXB frm5 = new TTNXB();
            frm5.ShowDialog();
        }
        private void button15_Click(object sender, EventArgs e)
        {
            new PhieuTra().ShowDialog();
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Category().ShowDialog();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            TimKiemSach frm = new TimKiemSach();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            thongtincanhan frm = new thongtincanhan();

            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormTaoTaiKhoan frm = new FormTaoTaiKhoan();
            frm.ShowDialog();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Rules frm = new Rules();
            frm.ShowDialog();
        }

        private void paneldsnv_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvnvdanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ttcnsdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dgvnvdanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int a;
            a = dgvnvdanhsach.CurrentRow.Index;
            ttcnma.Text = dgvnvdanhsach.Rows[a].Cells[0].Value.ToString();
            ttcnten.Text = dgvnvdanhsach.Rows[a].Cells[1].Value.ToString();
            ttcngioitinh.Text = dgvnvdanhsach.Rows[a].Cells[2].Value.ToString();
            ttcndiachi.Text = dgvnvdanhsach.Rows[a].Cells[3].Value.ToString();
            ttcnsdt.Text = dgvnvdanhsach.Rows[a].Cells[4].Value.ToString();
            DateTime dt1 = Convert.ToDateTime(dgvnvdanhsach.Rows[a].Cells[5].Value.ToString());
            ttcnngaysinh.Value = dt1;
        }

        private void txtdntaikhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
