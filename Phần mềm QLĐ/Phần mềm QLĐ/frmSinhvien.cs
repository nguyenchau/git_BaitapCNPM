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
    public partial class frmSinhvien : Form
    {
        public frmSinhvien()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }
        Boolean adSV = false;
        private void btnthemsinhvien_Click(object sender, EventArgs e)
        {
            txtmasinhvien.Text = "";
            txttensinhvien.Text = "";
            txtgioitinhsv.Text = "";
            datetimengaysinh.Text = "";
            txtdantocsv.Text = "";
            txtdiachisv.Text = "";
            txtnoisinhsv.Text = "";
            txtemailsv.Text = "";
            txtsodtsv.Text = "";
            txtmasinhvien.Enabled = true;
            txtmasinhvien.Focus();
            adSV = true;
           
        }
        QLDDataContext dt = new QLDDataContext();
        private void frmSinhvien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDDataSet3.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter1.Fill(this.qLDDataSet3.SinhVien);
            cbolop.DisplayMember = "TenLop";
            cbolop.ValueMember = "MaLop";
            cbolop.DataSource = dt.Lops_SelectAll();
            txtmalop.DataBindings.Clear();
            txtmalop.DataBindings.Add("Text", cbolop.DataSource, "MaLop");
            txttenlop.DataBindings.Clear();
            txttenlop.DataBindings.Add("Text", cbolop.DataSource, "TenLop");


        }

       private void cbolop_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgsinhvien.DataSource = dt.SinhVien_selectMalop(txtmalop.Text);
            txtmasinhvien.DataBindings.Clear();
            txtmasinhvien.DataBindings.Add("Text", dtgsinhvien.DataSource, "MaSV");
            txttensinhvien.DataBindings.Clear();
            txttensinhvien.DataBindings.Add("Text", dtgsinhvien.DataSource, "HoTen");
            datetimengaysinh.DataBindings.Clear();
            datetimengaysinh.DataBindings.Add("Text", dtgsinhvien.DataSource, "NgaySinh");
            txtgioitinhsv.DataBindings.Clear();
            txtgioitinhsv.DataBindings.Add("Text", dtgsinhvien.DataSource, "GioiTinh");
            txtdantocsv.DataBindings.Clear();
            txtdantocsv.DataBindings.Add("Text", dtgsinhvien.DataSource, "DanToc");
            txtnoisinhsv.DataBindings.Clear();
            txtnoisinhsv.DataBindings.Add("Text", dtgsinhvien.DataSource, "NoiSinh");
            txtdiachisv.DataBindings.Clear();
            txtdiachisv.DataBindings.Add("Text", dtgsinhvien.DataSource, "DiaChi");
            txtsodtsv.DataBindings.Clear();
            txtsodtsv.DataBindings.Add("Text", dtgsinhvien.DataSource, "Sdt");
            txtemailsv.DataBindings.Clear();
            txtemailsv.DataBindings.Add("Text", dtgsinhvien.DataSource, "Email");
            txtdantocsv.DataBindings.Clear();
            txtdantocsv.DataBindings.Add("Text", dtgsinhvien.DataSource, "DanToc");
            dtgsinhvien.Enabled = true;
       



        }

        private void btnluusinhvien_Click(object sender, EventArgs e)
        {
            if(adSV)
            {  
                dt.Sinhvien_Insertsss(txtmasinhvien.Text, txttensinhvien.Text, datetimengaysinh.Value
                    , Convert.ToInt32(txtgioitinhsv.Text), txtdantocsv.Text, txtnoisinhsv.Text,txtmalop.Text,
                    txtemailsv.Text, txtsodtsv.Text, txtdiachisv.Text);
                adSV = false;
                txtmasinhvien.Enabled = false;
                cbolop_SelectedIndexChanged(sender, e);
            }
            else
            {
                dt.Sinhvien_Updatenew(txtmasinhvien.Text, txttensinhvien.Text, datetimengaysinh.Value
                    , Convert.ToInt32(txtgioitinhsv.Text), txtdantocsv.Text, txtnoisinhsv.Text,
                    txtemailsv.Text, txtsodtsv.Text, txtdiachisv.Text);
cbolop_SelectedIndexChanged(sender, e);
            }
        }

        private void btnxoasinhvien_Click(object sender, EventArgs e)
        {
            dt.Sinhvien_Deletes(txtmasinhvien.Text);
           cbolop_SelectedIndexChanged(sender, e);
        }
    }
}
