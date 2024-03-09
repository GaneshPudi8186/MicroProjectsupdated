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
using System.Data.SqlClient;
namespace MicroProjectsupdated
{
    public partial class CreateNewUser : Form
    {
        CreateNewUserBLL CBLL = new CreateNewUserBLL();
        UsersCommon C = new UsersCommon();
        public CreateNewUser()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
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
            if (txtPwd.Text == txtCPwd.Text)
            {
               C.ppassword = txtCPwd.Text;

            }
            else
            {
                MessageBox.Show("both password are Not same");
                return;
            }

            C.pusername = txtUname.Text;
            C.ppassword = txtPwd.Text;
            C.pconfirmpassword = txtCPwd.Text;
            C.pfname = txtFname.Text;
            C.plname = txtLname.Text;
            C.phintque = cmbHQue.SelectedItem.ToString();
            C.phintanswer = txtHanswer.Text;          
            MessageBox.Show(CBLL.insertdata(C)); 
            Console.Beep();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
         foreach(Control c in this.Controls)
            {
                if(c is TextBox)
                {
                    c.Text = null;
                }
                if(c is ComboBox)
                {
                    c.Text = null;
                }
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateNewUser_Load(object sender, EventArgs e)
        {
            //
        }
    }
}
