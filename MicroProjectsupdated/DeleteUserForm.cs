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
    public partial class DeleteUserForm : Form
    { UsersCommon C = new UsersCommon();string g;
        DeleteUserBLL D = new DeleteUserBLL();
        public DeleteUserForm()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            D.Deletedata(C);
            Console.Beep();
            DGVUsers.DataSource = D.GetUsersdata().Tables[0];
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteUserForm_Load(object sender, EventArgs e)
        {
            DGVUsers.DataSource = D.GetUsersdata().Tables[0];
        }

        private void DGVUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow Row = this.DGVUsers.Rows[e.RowIndex];
                g = Row.Cells[0].Value.ToString();
                C.pusername = g;
            }
        }
    }
}
