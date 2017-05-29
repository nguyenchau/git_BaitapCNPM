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

namespace Phần_mềm_QLĐ
{
    public partial class frmLops : Form
    {
        SqlDataAdapter adapter;
        public frmLops()
        {
            InitializeComponent();
            dtglop.DataSource = getSuppliers();
        }
        QLDDataContext dt = new QLDDataContext();
        private void frmLops_Load(object sender, EventArgs e)
        {
            cbolop.DisplayMember = "TenLop";
            cbolop.ValueMember = "MaLop";
            cbolop.DataSource = dt.Lops_SelectAll();
            txtmalop.DataBindings.Clear();
            txtmalop.DataBindings.Add("Text", cbolop.DataSource, "MaLop");
            txttenlop.DataBindings.Clear();
            txttenlop.DataBindings.Add("Text", cbolop.DataSource, "TenLop");
            txtgiaoviencn.DataBindings.Clear();
            txtgiaoviencn.DataBindings.Add("Text", cbolop.DataSource, "GiaoVienChuNhiem");
            txttenkhoa.DataBindings.Clear();
            txttenkhoa.DataBindings.Add("Text", cbolop.DataSource, "Khoa");
            bingding();

        }
        private DataTable getSuppliers()
        {
            DataSet ds = new DataSet();
            string conn = @"Data Source=DESKTOP-B0VGDDV\SQLEXPRESS;Initial Catalog=QLD;Integrated Security=True";
            string sql = "Select * from Lops";
            adapter = new SqlDataAdapter(sql, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Fill(ds, "Lops");
            DataTable tbl = ds.Tables[0];
            return tbl;
        }
        Boolean adLop = false;
        private void btnthemsinhvien_Click(object sender, EventArgs e)
        {
            txtmalop.Text = "";
            txttenlop.Text = "";
            txtmalop.Enabled = true;
            txtgiaoviencn.Text = "";
            txttenkhoa.Text = "";
            txtmalop.Focus();
            adLop = true;
        }

        private void btnluulop_Click(object sender, EventArgs e)
        {
           
            if(adLop)
            {
                dt.Lops_Insert(txtmalop.Text, txttenlop.Text, txtgiaoviencn.Text, txttenkhoa.Text);
                txtmalop.Enabled = false;
                adLop = false;
            }
            else
            {
                dt.Lop_Update(txtmalop.Text, txttenlop.Text,txtgiaoviencn.Text,txttenkhoa.Text);
            }
            frmLops_Load(sender, e);
            
        }

        private void btnxoalop_Click(object sender, EventArgs e)
        {
            dt.Lops_Delete(cbolop.SelectedValue.ToString());
            frmLops_Load(sender, e);
         
        }

        private void cbolop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtglop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataTable temp = (DataTable)dtglop.DataSource;
            try
            {
                adapter.Update(temp);
                dtglop.Refresh();
            }
            catch(Exception)
            {

            }
            frmLops_Load(sender, e);
         
        }
        public void bingding()
        {
            txtmalop.DataBindings.Clear();
            txtmalop.DataBindings.Add("Text", dtglop.DataSource, "MaLop");
            txttenlop.DataBindings.Clear();
            txttenlop.DataBindings.Add("Text", dtglop.DataSource, "TenLop");
            txtgiaoviencn.DataBindings.Clear();
            txtgiaoviencn.DataBindings.Add("Text", dtglop.DataSource, "GiaoVienChuNhiem");
            txttenkhoa.DataBindings.Clear();
            txttenkhoa.DataBindings.Add("Text", dtglop.DataSource, "Khoa");
           
        }
    }
}
