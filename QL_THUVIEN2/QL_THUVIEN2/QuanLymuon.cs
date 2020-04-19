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
    public partial class QuanLymuon : Form
    {
        public QuanLymuon()
        {
            InitializeComponent();
        }
      
        clsDatabase cls = new QL_THUVIEN2.clsDatabase();
      
        private void HienThi_PM()
        {
            
          
            cls.LoadData2DataGridView(dgvpn1, "select * from PHIEUMUON");

        }
        private void HienThi_QL()
        {
            
            cls.LoadData2DataGridView(dgvpn2, "select * from QL_PHIEUMUON WHERE MAPM='" + pn1mapm.Text + "'");
        }
        private void insert_PM()
        {
           
            //else { 
            string s1 = pn1ngaymuon.Value.Year + "/" + pn1ngaymuon.Value.Month + "/" + pn1ngaymuon.Value.Day;
            string sql = "insert into PHIEUMUON (MaPM,MaDG,TaiKhoan, NgayMuon) values('" + pn1mapm.Text + "','" + pn1madg.Text + "','" + pn1manv.Text + "',convert(smalldatetime,'" + s1.ToString() + "')) ";
           
            cls.ThucThiSQLTheoKetNoi(sql);
        }
        

        private void update_PM()
        {
            string s1 = pn1ngaymuon.Value.Year + "/" + pn1ngaymuon.Value.Month + "/" + pn1ngaymuon.Value.Day;
            string cmd = "update PHIEUMUON set MaDG='" + pn1madg.Text + "',NgayMuon=convert(smalldatetime,'" + s1.ToString() + "'),TaiKhoan='" + pn1manv.Text + "' where MaPM='" + pn2mapm.Text + "'";
          
            cls.ThucThiSQLTheoKetNoi(cmd);
        }
        private void update_QL()
        {
           
            string s2 = pn2hantra.Value.Year + "/" + pn2hantra.Value.Month + "/" + pn2hantra.Value.Day;
            string cmd = "update QL_PHIEUMUON set MaSach='" + pn2masach.Text + "',HanTra=convert(smalldatetime,'" + s2.ToString() + "'), SoLuongSM='"+ txtsdsachmuon.Text+"' where MaPM='" + pn1mapm.Text + "' and MaSach='" + pn2masach.Text + "'";
         
            cls.ThucThiSQLTheoKetNoi(cmd);
        }

        private void delete_PT()
        {
            string s2 = pn2hantra.Value.Year + "/" + pn2hantra.Value.Month + "/" + pn2hantra.Value.Day;

            string cmd ="delete from TRASACH where MaPM='" + pn1mapm.Text + "'and MaSach='" + pn2masach.Text + "'";
         
            cls.ThucThiSQLTheoKetNoi(cmd);

        }
        private void insert_PT()
        {
            string s1 = pn2hantra.Value.Year + "/" + pn2hantra.Value.Month + "/" + pn2hantra.Value.Day;
            string sql = "insert into TRASACH (MaPM,MaSach,TaiKhoan,NgayTra,PhatQuaHan) values ('" + pn1mapm.Text + "','" + pn2masach.Text + "','" + pn1manv.Text + "',convert(smalldatetime,'" + s1.ToString() + "'),'0')";
            
            cls.ThucThiSQLTheoKetNoi(sql);
        }

 
        private void Form6_Load(object sender, EventArgs e)
        {
            pn1mapm.Enabled = false;
            pn2mapm.Enabled = false;
            // ketnoi();
            

            cls.KetNoi();
            HienThi_PM();
            HienThi_QL();
          
            cls.LoadCombo(pn2masach, "select masach from Sach");
            cls.LoadCombo(pn1madg, "select MaDG from DOCGIA");


            cls.LoadCombo(pn1manv, "select TaiKhoan from NHANVIEN");
           
        }

        private void insert_QL()
        {
           
            string s2 = pn2hantra.Value.Year + "/" + pn2hantra.Value.Month + "/" + pn2hantra.Value.Day;
            string cmd = "insert into QL_PHIEUMUON (MaPM,MaSach,HanTra,SoLuongSM) values('" + pn2mapm.Text + "','" + pn2masach.Text + "',convert(smalldatetime,'" + s2.ToString() + "'),'" + txtsdsachmuon.Text + "')";
         
            cls.ThucThiSQLTheoKetNoi(cmd);
        }
        private void delete_PM()
        {

            string cmd= "delete from PHIEUMUON where MaPM='" + pn1mapm.Text + "'";
 
            cls.ThucThiSQLTheoKetNoi(cmd);


        }
        private void delete_QL()

        {
           
            string s2 = pn2hantra.Value.Year + "/" + pn2hantra.Value.Month + "/" + pn2hantra.Value.Day;
            string cmd= "delete from QL_PHIEUMUON where  MaSach='" + pn2masach.Text + "'and mapm='"+ pn2mapm.Text+ "'";
    
            cls.ThucThiSQLTheoKetNoi(cmd);

        }
        private void bttthemmoi_Click(object sender, EventArgs e)
        {


            if (bttthemmoi.Text == "Add")
            {

                pn2mapm.Enabled = false;
                pn1mapm.Enabled = true;
                pn1madg.Text = "";
                pn1manv.Text = "";
                pn1mapm.Clear();
                pn2mapm.Clear();
                pn2masach.Text = "";
                pn1mapm.Focus();
                button1.Enabled = false;
                bttthemmoi.Text = "OK";
                return;
            }
            else
            {

                button1.Enabled = true;
                pn1mapm.Enabled = false;
                pn2mapm.Enabled = false;
                string mapm = "select COUNT(mapm) from PHIEUMUON WHERE MAPM='" + pn1mapm.Text + "'";
              
                int slg = cls.CheckID(mapm);
                if (slg > 0) MessageBox.Show("Borrow-card adrealy exists!");
                else if (pn1mapm.Text == "")
                {
                    MessageBox.Show("Borrow-card is empty!");
                }
                else if(pn1madg.Text=="")
                {
                    MessageBox.Show("Reader ID is empty!");
                }
                else
                // if()

                {
                    string s1 = pn1ngaymuon.Value.Year + "/" + pn1ngaymuon.Value.Month + "/" + pn1ngaymuon.Value.Day;
                    string tm = "select count(mapm) from phieumuon where madg='" + pn1madg.Text + "'and NgayMuon= convert(smalldatetime,'" + s1.ToString() + "')";
              
                    int slt = cls.CheckID(tm);
                    if (slt > 0) MessageBox.Show("Mỗi độc giả chỉ đăng ký một thẻ mượn mỗi ngày!");
                    else
                    {
                        insert_PM();
                        HienThi_PM();
                        MessageBox.Show("Hoàn tất!");
                    }


                }
                bttthemmoi.Text = "Add";
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button22_Click(object sender, EventArgs e)
        {
            if ((pn1mapm.Text == "") || (pn1madg.Text == "") || (pn1manv.Text == ""))
            {
                MessageBox.Show("Bạn cần điền đầy đủ thông tin hoặc thông tin không chính xác");
            }
            else
            {
                insert_PM();
                HienThi_PM();
            }
        }

        private void bttqlnvxoa_Click(object sender, EventArgs e)
        {
            delete_PM();
            HienThi_PM();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            update_PM();
            MessageBox.Show("Sửa hoàn tất!");
            HienThi_PM();
        }

        private void dgvpn1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            try
            {
                pn1mapm.Text = dgvpn1.Rows[i].Cells[0].Value.ToString().Trim();
                pn1madg.Text = dgvpn1.Rows[i].Cells[1].Value.ToString().Trim();
                pn1manv.Text = dgvpn1.Rows[i].Cells[2].Value.ToString().Trim();
                DateTime dt = Convert.ToDateTime(dgvpn1.Rows[i].Cells[3].Value.ToString());
                pn1ngaymuon.Value = dt;

          
                cls.LoadData2DataGridView(dgvpn2, "select * from QL_PHIEUMUON WHERE MAPM='" + pn1mapm.Text + "'");            
               cls.LoadData2DataGridView(dataGridView1, "select * from DOCGIA WHERE MADG='" + pn1madg.Text + "'");
            }
            catch (Exception) {
                
            }
        }
        private void pn1maphieu_TextChanged(object sender, EventArgs e)
        {
            pn2mapm.Text = pn1mapm.Text.ToString();
        }
        private void dgvpn2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            try
            {

                pn1mapm.Text = dgvpn2.Rows[i].Cells[0].Value.ToString().Trim();
                pn2masach.Text = dgvpn2.Rows[i].Cells[1].Value.ToString().Trim();
               
                DateTime dt1 = Convert.ToDateTime(dgvpn2.Rows[i].Cells[2].Value.ToString());
                pn2hantra.Value = dt1;
                txtsdsachmuon.Text = dgvpn2.Rows[i].Cells[3].Value.ToString().Trim();
                pn2mapm.Text = pn1mapm.Text.ToString().Trim();
             
                cls.LoadData2DataGridView(dataGridView2, "select * from SACH where masach='" + pn2masach.Text + "'");
               
            }
            catch (Exception) { }
        }

       private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete?(Y/N)", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string cmd1 = "update SACH set SoLuong = SoLuong +(select soluongSm from ql_phieumuon where MaSach='" + pn2masach.Text + "' and Mapm='" + pn2mapm.Text + "') from sach where MaSach='" + pn2masach.Text + "'";

                cls.ThucThiSQLTheoKetNoi(cmd1);
                delete_QL();
                delete_PT();
                
               
            }
            HienThi_QL();
          //  textBox2.Clear();
            txtsdsachmuon.Clear();
           
        }
 
        private void button4_Click(object sender, EventArgs e)
        {
          
       
            if (txtsdsachmuon.Text == "")
                    {
                        MessageBox.Show("Số lượng đang trống!");
                    }
            else
                {
                        string s1 = "select SoSachHong from SACH where masach='" + pn2masach.Text + "'";
                        string s2 = "select SoLuong from sach where masach='" + pn2masach.Text + "'";

                        int S1 = Int32.Parse(txtsdsachmuon.Text);
                if (S1 > 5)
                {
                    MessageBox.Show("Không thể mượn hơn 5 cuốn sách cho mỗi loại sách!");
                }

                else
                        {
                            int S3 = cls.account(s1);

                            int S2 = cls.account(s2);
                    if (S1 > S2 - S3) MessageBox.Show("Số lượng sách mượn lớn hơn số lượng sách có sẵn!");
                    else
                    {
                        update_QL();
                        string masach = "select count(masach) from QL_PHIEUMUON where mapm='" + pn1mapm.Text + "' and masach='" + pn2masach.Text + "'";

                        int sl = cls.CheckID(masach);
                        if (sl > 0) MessageBox.Show("Cuốn sách này đã được mượn từ thẻ mượn hiện tại, vui lòng cập nhật số lượng nếu bạn muốn mượn thêm sách!");
                        else
                        {
                            insert_QL();
                         
                            string tongsachmuon = "select isnull(sum(soluongSM),0) from PHIEUMUON, QL_PHIEUMUON where PHIEUMUON.MaPM= QL_PHIEUMUON.MaPM and madg='" + pn1madg.Text + "'";
                            int tongmuon = cls.account(tongsachmuon);
                            if (tongmuon > 20)
                            { MessageBox.Show("Mỗi độc giả chỉ có thể mượn tối đa 20 cuốn sách!");
                                delete_QL();
                            }
                            else
                            {
                                string cmd = "update SACH set SoLuong = SoLuong -(select soluongSm from ql_phieumuon where MaSach='" + pn2masach.Text + "' and Mapm='" + pn2mapm.Text + "') from sach where MaSach='" + pn2masach.Text + "' ";

                                cls.ThucThiSQLTheoKetNoi(cmd);

                                insert_PT();

                                HienThi_QL();
                                MessageBox.Show("Hoàn tất!");
                            }

                        }
                    }
                            }
                        }
                   
              

           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            cls.LoadData2DataGridView(dgvpn1, "select * from PHIEUMUON where maDG='" + textBox1.Text + "'");

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            cls.LoadData2DataGridView(dgvpn1, "select * from PHIEUMUON");

        }

     
        private void button8_Click(object sender, EventArgs e)
        {
            update_QL();
            string masach = "select count(masach) from QL_PHIEUMUON where mapm='" + pn1mapm.Text + "' and masach='" + pn2masach.Text + "'";

            int sl = cls.CheckID(masach);
            if (sl == 0)
            {
                MessageBox.Show("Cuốn sách này không có sẵn trên thẻ mượn, vui lòng chọn mục 'Mượn sách' để mượn!");

            }
            else
            {
         
                string cmd1 = "update SACH set SoLuong = SoLuong +(select soluongSm from ql_phieumuon where MaSach='" + pn2masach.Text + "' and Mapm='" + pn2mapm.Text + "') from sach where MaSach='" + pn2masach.Text + "'";
                cls.ThucThiSQLTheoKetNoi(cmd1);
                update_QL();
                MessageBox.Show("Update successfully!");

                string cmd = "update SACH set SoLuong = SoLuong -(select soluongSm from ql_phieumuon where MaSach='" + pn2masach.Text + "' and Mapm='" + pn2mapm.Text + "') from sach where MaSach='" + pn2masach.Text + "' ";
                cls.ThucThiSQLTheoKetNoi(cmd);
       
                insert_PT();

                HienThi_QL();
            }

        }

       

        private void button9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete?(Y/N)", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string delete1 = "DELETE TRASACH WHERE MAPM='" + pn1mapm.Text + "'";
                cls.ThucThiSQLTheoKetNoi(delete1);
                string delete2 = "DELETE QL_PHIEUMUON WHERE MAPM='" + pn1mapm.Text + "'";
                cls.ThucThiSQLTheoKetNoi(delete2);
                string delete = "delete from phieumuon where Mapm='" + pn1mapm.Text + "'";
                cls.ThucThiSQLTheoKetNoi(delete);
            }
            cls.LoadData2DataGridView(dgvpn1, "select *from phieumuon");
        }
    }
}
