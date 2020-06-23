using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_THUVIEN2
{
    class clsDatabase
    {
//<<<<<<< HEAD
        string strConnect = @"Data Source=DESKTOP-FKTOQAI\SQLEXPRESS01;Initial Catalog=TTN_QLTV;Integrated Security=True";
//=======
        //string strConnect = @"Data Source=WIN10PRO\SQLEXPRESS;Initial Catalog=TTN_QLTV;Integrated Security=True";
//>>>>>>> caee2b1158c86f4558be9c1b97af909ec66fa4d4
        SqlConnection sqlCon;
        SqlCommand sqlCom;
    //    SqlDataReader sqlRea;
        SqlDataAdapter sqlAdap;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
       // Phương thức kết nối tới CSDL SQL Server
        public void KetNoi()
        {
            sqlCon = new SqlConnection(strConnect);
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
        }

     //   Phương thức đóng kết nối tới CSDL
        private void NgatKetNoi()
        {
            if (sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }
        public void ThucThiSQLTheoKetNoi(string strSql)
        {
            KetNoi();

            sqlCom = new SqlCommand(strSql, sqlCon);
            sqlCom.ExecuteNonQuery();

            NgatKetNoi();
        }
        public void LoadData2DataGridView(DataGridView dg, string strSelect)
        {
     
            dt = new DataTable();
            
            sqlAdap = new SqlDataAdapter(strSelect, sqlCon);
            sqlAdap.Fill(dt);
          

            dg.DataSource = dt;

        }
        public Object layGiaTri(string sql) //lay gia tri cua  cot dau tien trong bang 
        {
            sqlCom= new SqlCommand();
            sqlCom.CommandText = sql;
            sqlCom.CommandType = CommandType.Text;
            sqlCom.Connection = sqlCon;

            //  CHi can lay ve gia tri cua mot truong thoi thi dung pt nao ? -ExecuteScalar
            Object obj = sqlCom.ExecuteScalar(); //neu co loi thi phai xem lai cua lenh SQL o ben kia
            return obj;
            //   Ket qua de dau ? -de trong obj
        }

        public void LoadCombo(ComboBox combo, string strSelect)
        {
           
              dt = new DataTable();
          //  dt.Clear();
            //   Fill vào DataTable
            sqlAdap = new SqlDataAdapter(strSelect, strConnect);
            sqlAdap.Fill(dt);
            //dg.DataSource = dt;
            //dt = ds.Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
                combo.Items.Add(dt.Rows[i][0].ToString());

        }
      
        public void Load1Combo(ComboBox combo, string select)
        {
            //KetNoi();
            dt = new DataTable();
            //   Fill vào DataTable
            sqlAdap = new SqlDataAdapter(select, sqlCon);
            sqlAdap.Fill(dt);
            // NgatKetNoi();
            //     dt= ds.Tables[0];

            combo.DataSource = dt;

        }
       
        public int CheckID(string strSelect)
        {
           KetNoi();
          //  string tm = "select count(mapm) from phieumuon where madg='" + pn1madg.Text + "'and NgayMuon= convert(smalldatetime,'" + s1.ToString() + "')";
            sqlCom = new SqlCommand(strSelect, sqlCon);
            int slt = (int)sqlCom.ExecuteScalar();
            if (slt > 0)
            {
                return 1;

            }
            else return 0;
        }
        public int account(string select)
        {
            KetNoi();
            sqlCom = new SqlCommand(select, sqlCon);
            int slt = (int)sqlCom.ExecuteScalar();
            return slt;
            
        }
    
    }
        }

