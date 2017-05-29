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
using System.Data.Sql;
namespace Phần_mềm_QLĐ
{
    public partial class Bangdiemtonghop : Form
    {
        string chuoiKN = "Data Source=.\\SQLEXPRESS;Initial Catalog=QLD;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt1;
        public void ketnoi()
        {
            try
            {
                conn = new SqlConnection(chuoiKN);
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối that bai");
            }
        }
        public Bangdiemtonghop()
        {
            InitializeComponent();
        }
        QLDDataContext dt = new QLDDataContext();
        xuli xl = new xuli();
        private void Bangdiemtonghop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDDataSet14.Ketqua' table. You can move, or remove it, as needed.
            this.ketquaTableAdapter2.Fill(this.qLDDataSet14.Ketqua);
            // TODO: This line of code loads data into the 'qLDDataSet13.Ketqua' table. You can move, or remove it, as needed.
            this.ketquaTableAdapter1.Fill(this.qLDDataSet13.Ketqua);
            // TODO: This line of code loads data into the 'qLDDataSet12.Ketqua' table. You can move, or remove it, as needed.
            this.ketquaTableAdapter.Fill(this.qLDDataSet12.Ketqua);
            // TODO: This line of code loads data into the 'qLDDataSet11.DiemHP' table. You can move, or remove it, as needed.
            this.diemHPTableAdapter2.Fill(this.qLDDataSet11.DiemHP);
            // TODO: This line of code loads data into the 'qLDDataSet10.DiemHP' table. You can move, or remove it, as needed.
            this.diemHPTableAdapter1.Fill(this.qLDDataSet10.DiemHP);
            // TODO: This line of code loads data into the 'qLDDataSet7.MonHP_SelectAll' table. You can move, or remove it, as needed.
            this.monHP_SelectAllTableAdapter.Fill(this.qLDDataSet7.MonHP_SelectAll);
            // TODO: This line of code loads data into the 'qLDDataSet6.MonHP' table. You can move, or remove it, as needed.
            this.monHPTableAdapter.Fill(this.qLDDataSet6.MonHP);
            // TODO: This line of code loads data into the 'qLDDataSet5.DiemHP' table. You can move, or remove it, as needed.
            this.diemHPTableAdapter.Fill(this.qLDDataSet5.DiemHP);
            cboLop.ValueMember = "MaLop";
            cboLop.DisplayMember = "TenLop";
            cboLop.DataSource = dt.Lops_SelectAll();
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            foreach(var r in dt.SinhVien_selectMalop(cboLop.SelectedValue.ToString()))
            {
                TreeNode node = new TreeNode();
                node.Name = r.MaSV;
                node.Text = r.HoTen;
                treeView1.Nodes.Add(node);
            }
            treeView1.ExpandAll();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var table = new DataTable();

            foreach (var r in dt.Sinhvien_selectMasv(e.Node.Name))
            {
                lblmasv.Text=e.Node.Name;
                lblten.Text= r.HoTen;
                lblngay.Text=r.NgaySinh.ToString();
                lblgioitinh.Text= r.GioiTinh.ToString();
                if(r.GioiTinh.ToString()=="1")
                {
                    lblgioitinh.Text="Nữ";
                }
                else
                {
                    lblgioitinh.Text="Nam";
                }
                lbldantoc.Text=r.DanToc;
                lblnoi.Text=r.NoiSinh;
                lbldiachi.Text=r.DiaChi;
                lblemail.Text=r.Email;
                lblsdt.Text=r.Sdt;
                dataGridViewX1.DataSource = table;

            }
            //var table = new DataTable();
            DataColumnCollection col = table.Columns;
            if (!col.Contains("MaHP"))
                table.Columns.Add("MaHP", typeof(String));
            if (!col.Contains("TenHP"))
                table.Columns.Add("TenHP", typeof(String));
           // if (!col.Contains("SoTinChi"))
           //     table.Columns.Add("SoTinChi", typeof(String));
            if (!col.Contains("DiemHP"))
                table.Columns.Add("DiemHP", typeof(String));
            if (!col.Contains("DiemChu"))
                table.Columns.Add("DiemChu", typeof(String));
            if (!col.Contains("DiemSo"))
                table.Columns.Add("DiemSo", typeof(String));
           
                    ketnoi();
                    cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from Ketqua where MaSV='" + e.Node.Name + "'";
                    dr = cmd.ExecuteReader();
                    dt1 = new DataTable();
                    dt1.Load(dr);
                    dataGridViewX1.DataSource = dt1;
                    conn.Close();
                    cmd.Dispose();


            //foreach(var m in dt.ketqua_selectAll())
            //{
            //    DataRow r = table.NewRow();
            //    r["MaHP"] = m.MaHP;
            //    r["TenHP"] = m.TenHP;
                
             
                
                

                
                
            //    dataGridViewX1.DataSource = table;
            //}
           


        }

        private void lblemail_Click(object sender, EventArgs e)
        {

        }

        private void lblngay_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
         
    }
}
