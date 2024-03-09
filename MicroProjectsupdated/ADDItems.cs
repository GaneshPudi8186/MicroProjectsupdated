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
using CLibBLLProject;
using CLibCommonLayer;
namespace MicroProjectsupdated
{
    public partial class ADDitemForm : Form
    {
        ItemsCommon I = new ItemsCommon();
        Bllitems Bl = new Bllitems();
        public ADDitemForm()
        {
            InitializeComponent();
        }

        private void ADDitemForm_Load(object sender, EventArgs e)
        {
            DGVItems.DataSource = Bl.getitemsdata().Tables[0];
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            I.pitem = txtItem.Text;
            I.pprice = Convert.ToDouble(txtprice.Text);
            Bl.ADDitems(I);
            Console.Beep();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Bl.UpdateTODB();
            Console.Beep();
            MessageBox.Show("Data is stored to DB");
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
