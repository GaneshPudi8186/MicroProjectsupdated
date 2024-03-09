using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroProjectsupdated
{
    public partial class MDIForm : Form
    {
        private int childFormNumber = 0;
  

        ADDitemForm A = new ADDitemForm();
        EditItemForm E = new EditItemForm();
        DeleteItemForm D = new DeleteItemForm();
        CreateNewUser u = new CreateNewUser();
       ViewUserForm j = new ViewUserForm();
        BillMaterForm B = new BillMaterForm();
        ViewBillForm V = new ViewBillForm();
        DeleteUserForm D1 = new DeleteUserForm();
        changeMain C = new changeMain();

        public MDIForm()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A.MdiParent = this;
            A.Show();
        }

        private void editItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            E.MdiParent = this;
            E.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            D.MdiParent = this;
            D.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            u.MdiParent = this;
            u.Show();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            D1.MdiParent = this;
            D1.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C.MdiParent = this;
            C.Show();
        }

        private void viewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            j.MdiParent = this;
            j.Show();
        }

        private void newBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            B.MdiParent = this;
            B.Show();
        }

        private void viewBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            V.MdiParent = this;
            V.Show();
        }
    }
}
