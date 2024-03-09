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
    public partial class BillMaterForm : Form
    {
        BillMasterCommon BMC = new BillMasterCommon();
        BillTransCommon BTC = new BillTransCommon();
        BillMasterBLL BM = new BillMasterBLL();
        public BillMaterForm()
        {
            InitializeComponent();
        }

        private void btnAdditems_Click(object sender, EventArgs e)
        {
            BMC.PUsername = CommonClassData.usernameCommon;
            CommonClassData.BillNumberCommon = txtBillNumber.Text;
            if (!CommonClassData.BillNumberCommon.Equals(""))
            {
                BillTransForm BT = new BillTransForm();
                BT.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Bill number is Mandatory");
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BM.InsertMaster(BMC);
            MessageBox.Show("Please Pay the Amount");
            //BM.inserttrans(BTC);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                { 
                    c.Text = null;
                }
            }

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void BillMaterForm_Load(object sender, EventArgs e)
        {
            BMC.PUsername=CommonClassData.usernameCommon;
            txtBillNumber.Text = CommonClassData.BillNumberCommon;
            //txtBillNumber.Text = BTC.PBillNumber;
            txtBillDate.Text = DateTime.Now.ToString();
            BillMasterCommon.Billdate = Convert.ToDateTime(txtBillDate.Text);
            txtBillAmount.Text = BillTransCommon.Total_Bill_Amount.ToString();
            txtCGST.Text = BillMasterCommon.CGST.ToString();
            TXTSGST.Text = BillMasterCommon.SGST.ToString();
        }

        private void txtBillNumber_Leave(object sender, EventArgs e)
        {
            if (!txtBillNumber.Text.Equals("0"))
                BMC.PBillNumber = txtBillNumber.Text;
            else MessageBox.Show("Bill Number is Mandatory");
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void Discount(object sender, KeyEventArgs e)
        {
            if (txtDiscount.Text.Length != 0)
            {
               BMC.PDiscount = Convert.ToDouble(txtDiscount.Text);
                BMC.PTotalBill= BillTransCommon.Total_Bill_Amount + (BillMasterCommon.CGST * BillTransCommon.Total_Bill_Amount) / 100 +
                    (BillMasterCommon.SGST * BillTransCommon.Total_Bill_Amount) / 100 - ((BMC.PDiscount * BillTransCommon.Total_Bill_Amount) / 100);
                txtTotalBill.Text = BMC.PTotalBill.ToString();
            }
            else
            {
                txtDiscount.Text = "";
                txtTotalBill.Text = "";
            }
        }
    }
}
