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

namespace BAITAP_CSDL
{
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }
        int count = 0;
        private void btn_login_Click(object sender, EventArgs e)
        {
            string chuoikn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\source\repos\BAITAP_CSDL\BAITAP_CSDL\CSDL.mdf;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(chuoikn);
            string sql = "Select COUNT (*) FROM THONGTINTAIKHOAN where TAIKHOAN = '"+txt_username.Text+"' and MATKHAU = '"+txt_password.Text+"'";
            SqlCommand comm = new SqlCommand(sql, cnn);
            cnn.Open();
            int kq = (int)comm.ExecuteScalar();
            cnn.Close();
            if (kq >= 1)
            {
                if (Application.OpenForms["frm_Main"] == null)
                {
                    frm_Main main = new frm_Main();
                    main.Show();
              
                }
                else
                {
                    Application.OpenForms["frm_Main"].Activate();
                }

            }
            else
            {
                MessageBox.Show($"Bạn nhập sai tên đăng nhập hoặc mật khẩu {count + 1} lần.Nếu sai 3 lần sẽ thoát!");
                count++;
                if (count == 3)
                {
                    Application.Exit();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có thật sự muốn thoát?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dialog == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
