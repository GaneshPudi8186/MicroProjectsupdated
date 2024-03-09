using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLibCommonLayer;using CLibBLLProject;
namespace MicroProjectsupdated
{
    public partial class changepwdwithHintQ : Form
    {
        ChangePwdBLL CB = new ChangePwdBLL();
        UsersCommon C = new UsersCommon(); 
        
        public changepwdwithHintQ()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            if (txtNewpwd.Text == txtRepwd.Text)
            {
                C.ppassword = txtNewpwd.Text;
            }
            else
            {
                MessageBox.Show("Re enter the password");
                txtRepwd.Clear();
                txtRepwd.Focus();
                return;
            }
            C.pusername = CommonClassData.usernameCommon;
            C.phintque = cmbHQue.SelectedItem.ToString();
            C.ppassword = txtNewpwd.Text;
            C.phintanswer = txtHanswer.Text;
            C.pconfirmpassword = txtRepwd.Text;
            MessageBox.Show(CB.changeoldhq(C));
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

        private void optOldPwd_CheckedChanged(object sender, EventArgs e)
        {

            if (optOldPwd.Checked)
            {
                ChangePassword k = new ChangePassword();
                k.Show();
                this.Hide();
            }
        }

        private void changepwdwithold_Load(object sender, EventArgs e)
        {

        }
    }
}
