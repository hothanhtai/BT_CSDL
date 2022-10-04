using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAITAP_CSDL
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void hồSơKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_Khoa"] == null)
            {
                frm_Khoa khoa = new frm_Khoa();
                khoa.MdiParent = this;
                khoa.Show();
            }
            else
            {
                Application.OpenForms["frm_Khoa"].Activate();
            }
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_DanhSachNhanVien"] == null)
            {
                frm_DanhSachSinhVien nv = new frm_DanhSachSinhVien();
                nv.MdiParent = this;
                nv.Show();
            }
            else
            {
                Application.OpenForms["frm_DanhSachNhanVien"].Activate();
            }
        }
    }
}
