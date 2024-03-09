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
    public partial class LoginForm : Form
    {
       UsersCommon L= new UsersCommon();
        LoginBLL L1 = new LoginBLL();
       
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            CommonClassData.usernameCommon = txtusername.Text;
            CommonClassData.passwordCommon = txtpassword.Text;
            L.pusername = CommonClassData.usernameCommon;
            L.ppassword = CommonClassData.passwordCommon;


           int s= L1.Login(L);
            if(s!=0)
            {
                MDIForm M = new MDIForm();
                M.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Password and Username");
            }
        }
    }
}
