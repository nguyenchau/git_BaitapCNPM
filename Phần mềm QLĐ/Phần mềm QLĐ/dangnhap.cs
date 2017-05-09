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
using System.Threading;

namespace Phần_mềm_QLĐ
{
    public partial class dangnhap : Form
    {

        frmMain ht;
        String strConnection = @"Data Source=DESKTOP-B0VGDDV\SQLEXPRESS;Initial Catalog=QLD;Integrated Security=True";
        SqlConnection conn;
        SqlCommand command;
        public dangnhap()
        {
            
            
            
            InitializeComponent();

        }
       

        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void panelEx1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "Select count(*) from [QLD].[dbo].[DangNhap] where username=@user and password=@pass";
                conn = new SqlConnection(strConnection);
                conn.Open();
                command = new SqlCommand(sql, conn);
                command.Parameters.Add(new SqlParameter("@user", txtUser.Text));
                command.Parameters.Add(new SqlParameter("@pass", txtPassword.Text));
                int x = (int)command.ExecuteScalar();
                if (x == 1)
                {
                    this.Hide();
                    ht = new frmMain();
                    ht.Show();
                }
                else
                {
                    lblIncorrect.Text = "User name or password is Not Correct";
                    txtUser.Text = "";
                    txtPassword.Text = "";
                    txtUser.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn thực sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialog == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void ckbShowpass_CheckedChanged_1(object sender, EventArgs e)
        {
            if (ckbShowpass.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
