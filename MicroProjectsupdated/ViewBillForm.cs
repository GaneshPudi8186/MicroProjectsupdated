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
    public partial class ViewBillForm : Form
    {
        ViewBillBLL VBB = new ViewBillBLL();
        ViewBillCommon VBC = new ViewBillCommon();
        public ViewBillForm()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewBillForm_Load(object sender, EventArgs e)
        {
            VBB.GetBIll();

            foreach (string C in ViewBillCommon.items)
            {
                cmbBillNumber.Items.Add(C);
            }
            
        }

        private void cmbBillNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            VBC.Pbillnumber = cmbBillNumber.SelectedItem.ToString();
            VBB.Display(VBC);
             VBB.transdata(VBC);
            DGVItems.DataSource = ViewBillCommon.dsbill.Tables[0];
            DGVBill.DataSource = ViewBillCommon.dsitems.Tables[0];
        }
    }
}
