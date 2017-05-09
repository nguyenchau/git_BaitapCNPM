using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phần_mềm_QLĐ
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnthoathethong_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn thật sự muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnsinhvien_Click(object sender, EventArgs e)
        {
            frmSinhvien frm = new frmSinhvien();
            frm.ShowDialog();
        }

        private void btnlops_Click(object sender, EventArgs e)
        {
            frmLops frm = new frmLops();
            frm.ShowDialog();
        }

        private void btntimsv_Click(object sender, EventArgs e)
        {
            frmtimthongtinsv frm = new frmtimthongtinsv();
            frm.ShowDialog();
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            HK_HP frm = new HK_HP();
            frm.ShowDialog();
        }

        private void buttonItem5_Click(object sender, EventArgs e)
        {
            Bangdiemtonghop frm = new Bangdiemtonghop();
            frm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
