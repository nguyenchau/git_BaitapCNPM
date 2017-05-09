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
    public partial class HK_HP : Form
    {
        public HK_HP()
        {
            InitializeComponent();
        }
        QLDDataContext dt = new QLDDataContext();
        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbomonhp_SelectedIndexChanged(sender, e);
        }

        private void cbomonhp_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgDiem.DataSource = dt.BangdiemHP(cboLop.SelectedValue.ToString(), txtMamon.Text);
        }

        private void HK_HP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDDataSet5.DiemHP' table. You can move, or remove it, as needed.
            this.diemHPTableAdapter.Fill(this.qLDDataSet5.DiemHP);
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
            cboLop.DataSource = dt.Lops_SelectAll();
            cboHK.DataSource = dt.HocKy_SelectAll();
            cboHK.ValueMember = "MaHocKy";
            cboHK.DisplayMember = "TenHocKy";
            txtMaHK.DataBindings.Clear();
            txtMaHK.DataBindings.Add("Text", cboHK.DataSource, "MaHocKy");
            txtTenHK.DataBindings.Clear();
            txtTenHK.DataBindings.Add("Text", cboHK.DataSource, "TenHocKy");
            txtMaHK.Enabled = false;
        }
        Boolean adHK = false;

        private void btnThemhk_Click(object sender, EventArgs e)
        {
            txtMaHK.Text = "";
            txtTenHK.Text = "";
            txtMaHK.Enabled = true;
            txtMaHK.Focus();
            adHK = true;
        }

        private void btnLuuhk_Click(object sender, EventArgs e)
        {
            if (adHK)
            {
                dt.HocKy_Insert(txtMaHK.Text, txtTenHK.Text);
                txtMaHK.Enabled = true;
                adHK = false;
                HK_HP_Load(sender, e);
            }
            else
            {
                dt.HocKy_Update(txtTenHK.Text, txtMaHK.Text);
                HK_HP_Load(sender, e);
            }
        }

        private void btnXoahk_Click(object sender, EventArgs e)
        {
            dt.HocKy_Delete(txtMaHK.Text);
            HK_HP_Load(sender, e);
        }

        private void btnThoatHK_Click(object sender, EventArgs e)
        {
            DialogResult dialg = MessageBox.Show("Bạn thật sự muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cboHK_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbomonhp.ValueMember = "MaHP";
            cbomonhp.DisplayMember = "TenHP";
            cbomonhp.DataSource = dt.MonHP_SelectMaHocKy(cboHK.SelectedValue.ToString());
            txtMamon.DataBindings.Clear();
            txtMamon.DataBindings.Add("Text", cbomonhp.DataSource, "MaHP");
            txtTenmon.DataBindings.Clear();
            txtTenmon.DataBindings.Add("Text", cbomonhp.DataSource, "TenHP");
            txtSoTC.DataBindings.Clear();
            txtSoTC.DataBindings.Add("Text", cbomonhp.DataSource, "SoTinChi");
            txtMamon.Enabled = false;
        }
        Boolean adMon = false;

        private void btnThemmon_Click(object sender, EventArgs e)
        {
            txtMamon.Text = "";
            txtTenmon.Text = "";
            txtSoTC.Text = "";
            txtMamon.Enabled = true;
            adMon = true;
        }

        private void btnLuumon_Click(object sender, EventArgs e)
        {
            if (adMon)
            {
                dt.MonHP_Insert(txtMamon.Text, txtTenmon.Text, Convert.ToInt16(txtSoTC.Text), txtMaHK.Text);
                adMon = false;
                cboHK_SelectedIndexChanged(sender, e);
            }
            else
            {
                dt.MonHP_Update(txtMamon.Text, txtTenmon.Text, Convert.ToInt16(txtSoTC.Text));
                cboHK_SelectedIndexChanged(sender, e);
            }
        }

        private void btnXoamon_Click(object sender, EventArgs e)
        {
            dt.MonHP_Delete(txtMamon.Text);
            cboHK_SelectedIndexChanged(sender, e);
        }

        private void btnCapnhatdulieu1_Click(object sender, EventArgs e)
        {
            foreach (var m in dt.MonHP_SelectAll())
            {
                foreach (var s in dt.SinhVien_SelectAll())
                {
                    if (dt.DiemHP_Search(m.MaHP, s.MaSV).Count() == 0)
                    {
                        dt.DiemHP_Insert(m.MaHP, s.MaSV);
                    }
                }
            }
            MessageBox.Show("Cập nhật thành công cơ sở dữ liệu Học Phần", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtgDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgDiem_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgDiem.CurrentCell.RowIndex;
            if (!String.IsNullOrEmpty(dtgDiem.Rows[i].Cells[3].Value.ToString()))
            {
                dt.DiemHP_UpdateLan1(Convert.ToDouble(dtgDiem.Rows[i].Cells[3].Value),
                    txtMamon.Text, dtgDiem.Rows[i].Cells["MaSV"].Value.ToString());
            }
            if (!String.IsNullOrEmpty(dtgDiem.Rows[i].Cells[4].Value.ToString()))
            {
                dt.DiemHP_UpdateLan2(Convert.ToDouble(dtgDiem.Rows[i].Cells[4].Value),
                    txtMamon.Text, dtgDiem.Rows[i].Cells["MaSV"].Value.ToString());
            }
            if (!String.IsNullOrEmpty(dtgDiem.Rows[i].Cells[5].Value.ToString()))
            {
                dt.DiemHP_UpdateLan3(Convert.ToDouble(dtgDiem.Rows[i].Cells[5].Value),
                    txtMamon.Text, dtgDiem.Rows[i].Cells["MaSV"].Value.ToString());
            }
        }
    }


    }

