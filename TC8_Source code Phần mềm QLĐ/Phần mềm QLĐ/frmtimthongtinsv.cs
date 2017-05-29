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
    public partial class frmtimthongtinsv : Form
    {
        public frmtimthongtinsv()
        {
            InitializeComponent();
        }
        QLDDataContext dt = new QLDDataContext();
        private void frmtimthongtinsv_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDDataSet4.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.qLDDataSet4.SinhVien);

        }

        private void txttimsv_TextChanged(object sender, EventArgs e)
        {
            dtgsinhvien.DataSource = dt.SinhViens.Where(x => x.HoTen.Contains(txttimsv.Text)).ToList();
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
            txtemailsv.DataBindings.Clear();
            txtemailsv.DataBindings.Add("Text", dtgsinhvien.DataSource, "Email");
            txtsodtsv.DataBindings.Clear();
            txtsodtsv.DataBindings.Add("Text", dtgsinhvien.DataSource, "Sdt");
            txtdiachisv.DataBindings.Clear();
            txtdiachisv.DataBindings.Add("Text", dtgsinhvien.DataSource, "DiaChi");
            
            
        }

        private void txtdantocsv_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
