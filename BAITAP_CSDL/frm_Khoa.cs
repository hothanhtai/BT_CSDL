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
    public partial class frm_Khoa : Form
    {
        public frm_Khoa()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có thật sự muốn thoát?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dialog == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string chuoikn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\source\repos\BAITAP_CSDL\BAITAP_CSDL\CSDL.mdf;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(chuoikn);
            string cmd = "INSERT INTO KHOA VALUES(N'" + txt_makhoa.Text + "',N'"+txt_tenkhoa.Text+"',N'"+txt_ghichu.Text+"')";
            SqlCommand comm = new SqlCommand(cmd, cnn);
            cnn.Open();
            int kq = comm.ExecuteNonQuery();
            cnn.Close();
            if (kq >= 1)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string chuoikn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\source\repos\BAITAP_CSDL\BAITAP_CSDL\CSDL.mdf;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(chuoikn);
            string cmd = "UPDATE KHOA SET TENKHOA= N'"+txt_tenkhoa.Text+"',GHICHU=N'"+txt_ghichu.Text+ "' WHERE MAKHOA= N'" + txt_makhoa.Text + "'";
            SqlCommand comm = new SqlCommand(cmd, cnn);
            cnn.Open();
            int kq = comm.ExecuteNonQuery();
            cnn.Close();
            if (kq >= 1)
            {
                MessageBox.Show("Update thành công");
            }
            else
            {
                MessageBox.Show("Update thất bại");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string chuoikn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\source\repos\BAITAP_CSDL\BAITAP_CSDL\CSDL.mdf;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(chuoikn);
            string cmd = "DELETE FROM KHOA WHERE MAKHOA=(N'"+txt_makhoa.Text+"')";
            SqlCommand comm = new SqlCommand(cmd, cnn);
            cnn.Open();
            int kq = comm.ExecuteNonQuery();
            cnn.Close();
            if (kq >= 1)
            {
                MessageBox.Show("Xóa Thành Công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }
    }
}
