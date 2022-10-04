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
    public partial class frm_DanhSachSinhVien : Form
    {
        public frm_DanhSachSinhVien()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string chuoikn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\source\repos\BAITAP_CSDL\BAITAP_CSDL\CSDL.mdf;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(chuoikn);
            string cmd = "UPDATE SINHVIEN SET HOTEN=N'"+txt_hoten.Text+"',DIACHI = N'"+txt_diachi.Text+"',NGAYSING=N'"+dtp_ngaysinh.Value.Date+"',TENKHOA = N'"+cmb_khoa.SelectedItem+"',LOP=N'"+txt_lop.Text+ "' WHERE MASV = N'" + txt_masv.Text + "'";
            SqlCommand comm = new SqlCommand(cmd, cnn);
            cnn.Open();
            int kq = comm.ExecuteNonQuery();
            cnn.Close();
            if(kq >= 1)
            {
                MessageBox.Show("Update thành công");
            }
            else
            {
                MessageBox.Show("Update thất bại");
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string chuoikn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\source\repos\BAITAP_CSDL\BAITAP_CSDL\CSDL.mdf;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(chuoikn);
            string cmd = "INSERT INTO SINHVIEN VALUES(N'"+txt_masv.Text+"',N'"+txt_hoten.Text+ "',N'" + txt_diachi.Text + "',N'" + dtp_ngaysinh.Value.Date + "',N'" + cmb_khoa.SelectedItem+"',N'"+txt_lop.Text+"')";
            SqlCommand comm = new SqlCommand(cmd, cnn);
            cnn.Open();
            int kq = comm.ExecuteNonQuery();
            cnn.Close();
            if (kq >= 1)
            {
                MessageBox.Show("Thêm Thành Công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void frm_DanhSachSinhVien_Load(object sender, EventArgs e)
        {
            string chuoikn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\source\repos\BAITAP_CSDL\BAITAP_CSDL\CSDL.mdf;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(chuoikn);
            string cmd = "SELECT TENKHOA FROM KHOA";
            SqlCommand comm = new SqlCommand(cmd, cnn);
            cnn.Open();
            SqlDataReader doc = comm.ExecuteReader();
            while (doc.Read())
            {
                cmb_khoa.Items.Add(doc["TENKHOA"]);
            }
            cnn.Close();

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string chuoikn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asus\source\repos\BAITAP_CSDL\BAITAP_CSDL\CSDL.mdf;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(chuoikn);
            string cmd = "DELETE SINHVIEN FROM MASV = N'"+txt_masv.Text+"'";
            SqlCommand comm = new SqlCommand(cmd, cnn);
            cnn.Open();
            int kq = comm.ExecuteNonQuery();
            cnn.Close();
            if(kq >=1)
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có thật sự muốn thoát?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dialog == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
