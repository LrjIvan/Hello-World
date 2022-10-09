using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FillSystemDownloader.Project
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Equals("weilai") & txtPwd.Text.Equals("123456"))
            {
                this.DialogResult = DialogResult.OK;
                this.Hide();

                FrmMain frmMain = new FrmMain();
                frmMain.ShowDialog();

                this.Close();
            }
            else
            {
                lblInfo.Text = "账号或密码错误！";
            }
        }


        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnLogin_Click(null, null);
        }

        private void Txt_TextChanged(object sender, EventArgs e)
        {
            lblInfo.Text = "";
        }

    }
}
