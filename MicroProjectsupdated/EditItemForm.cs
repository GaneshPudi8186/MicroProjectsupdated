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
using CLibCommonLayer;
using CLibBLLProject;
namespace MicroProjectsupdated
{
    public partial class EditItemForm : Form
    {
        EditItemBLL Bl = new EditItemBLL();
        ItemsCommon I = new ItemsCommon();
        string g;
        public EditItemForm()
        {
            InitializeComponent();
        }

        private void EditItemForm_Load(object sender, EventArgs e)
        {
            DGVItems.DataSource = Bl.GetItemsData().Tables[0];
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            I.pitem = txtItem.Text;
            g = txtItem.Text;
            I.pprice = Convert.ToDouble(txtprice.Text);
          
            Bl.EditItem(I);
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
