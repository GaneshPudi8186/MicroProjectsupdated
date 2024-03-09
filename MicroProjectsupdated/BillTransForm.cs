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
using System.Data.SqlClient;

namespace MicroProjectsupdated
{
    public partial class BillTransForm : Form
    {
        BillMasterCommon BMC = new BillMasterCommon();
        BillTransCommon BC =new  BillTransCommon();
        BillTransBLL B = new BillTransBLL();
        public BillTransForm()
        {
            InitializeComponent();
        }

        private void BillTransForm_Load(object sender, EventArgs e)
        {
            BC.PBillNumber = CommonClassData.BillNumberCommon;
            B.getitemsdata();
            foreach (string C in BillTransCommon.items)
            {
                cmbItems.Items.Add(C);                
            }
            
            DGVItems.DataSource = B.Display(BC).Tables[0];

        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text.Length == 0)
                    {
                        MessageBox.Show("Data is Mandatory");
                        return;
                    }
                }
            }
            BillTransCommon.billno = BC.PBillNumber;
            BC.PItemName = cmbItems.SelectedItem.ToString();
            BC.Pprice = Convert.ToDouble(txtPrice.Text);
            BC.PQuantity = Convert.ToInt32(txtQty.Text);
            BC.PTotal_Price = Convert.ToDouble(txttotalprice.Text);
            B.ADDitemrow(BC);
            txtQty.Text = null;
            txttotalprice.Text = null;
            Console.Beep();

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            B.data(BC);
            BC.PTotal_Price = 0;
            CommonClassData.BillNumberCommon = BC.PBillNumber;
           
            foreach (DataRow dr in BillTransCommon.dsitems.Tables[0].Rows)
            {
                BC.PTotal_Price += Convert.ToDouble(dr["TotalPrice"]);
            }
            BillTransCommon.Total_Bill_Amount = BC.PTotal_Price;
           BillMaterForm Bt = new BillMaterForm();
            Bt.Show();
            this.Hide();
        }

        private void cmbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            BC.PItemName = cmbItems.SelectedItem.ToString(); 
            
            B.ADDitems(BC); 
            txtPrice.Text = BC.Pprice.ToString();
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtQty_KeyUp(object sender, KeyEventArgs e)
        {
            
            
            if (txtQty.Text.Length != 0)
            {
                BC.PQuantity =Convert.ToInt32(txtQty.Text);

                txttotalprice.Text = (BC.Pprice * BC.PQuantity).ToString();
            }
            else
            {
                txtQty.Text = "";
                txttotalprice.Text = "";
            }
        }
    }
}
