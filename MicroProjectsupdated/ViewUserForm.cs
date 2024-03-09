using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLibBLLProject;
using CLibCommonLayer;
namespace MicroProjectsupdated
{
    public partial class ViewUserForm : Form
    {
        ViewUserBLL V = new ViewUserBLL();
        public ViewUserForm()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewUserForm_Load(object sender, EventArgs e)
        {
            DGVUsers.DataSource = V.GetUsersdata().Tables[0];
        }
    }
}
