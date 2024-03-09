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
    public partial class DeleteItemForm : Form
    {
        DeleteItemBLL Bl = new DeleteItemBLL();
        ItemsCommon I = new ItemsCommon();
        string g;
        public DeleteItemForm()
        {
            InitializeComponent();
        }

        private void DeleteItemForm_Load(object sender, EventArgs e)
        {
            DGVItems.DataSource = Bl.GetItemsData().Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            I.pitem = txtItem.Text;
            Bl.FindItem(I.pitem);
           
            Bl.DeleteItem(I);
            Console.Beep();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Bl.UpdateToDB();
            Console.Beep();
            MessageBox.Show("Data is stored to DB");
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGVItems_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow Row = this.DGVItems.Rows[e.RowIndex];
                g = Row.Cells[0].Value.ToString();

            }
            Bl.FindItem(g);
        }
    }
}
