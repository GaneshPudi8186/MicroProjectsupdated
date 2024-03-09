using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLibCommonLayer;
using CLibBLLProject;
namespace MicroProjectsupdated
{
    public partial class ChangePassword : Form
    {
        ChangePwdBLL CB = new ChangePwdBLL();
        UsersCommon C = new UsersCommon();

        public ChangePassword()
        {
            InitializeComponent();
        }
        private void ChangePassword_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text.Length == 0)
                    {
                        MessageBox.Show("enter Data is Mandatory");
                        return;
                    }
                }
            }
            if (txtNewPwd.Text == txtRePwd.Text)
            {
                C.ppassword = txtNewPwd.Text;
            }
            else
            {
                MessageBox.Show("Re-enter the password");
                txtRePwd.Clear();
                txtRePwd.Focus();
                return;
            }
            C.pusername = CommonClassData.usernameCommon;
            C.ppassword = txtNewPwd.Text;
            C.poldpwd = txtoldpwd.Text;
            C.pconfirmpassword = txtRePwd.Text;
            MessageBox.Show(CB.changeoldpwd(C));
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = null;
                }
            }
            
            Console.Beep();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangePassword_Load_1(object sender, EventArgs e)
        {
           
        }

        private void optHQue_CheckedChanged(object sender, EventArgs e)
        {
            if (optHQue.Checked)
            {
                changepwdwithHintQ l = new changepwdwithHintQ();
                l.Show();
                this.Hide();
            }
        }
    }
}
