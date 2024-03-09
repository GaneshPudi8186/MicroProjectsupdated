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
    public partial class changeMain : Form
    {
        public changeMain()
        {
            InitializeComponent();
        }

        private void optOldPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (optOldPwd.Checked)
            {
                ChangePassword k = new ChangePassword();
                k.Show();
                this.Hide();
            }
        }

        private void optHQue_CheckedChanged(object sender, EventArgs e)
        {
            if (optHQue.Checked)
            {
                changepwdwithHintQ l = new changepwdwithHintQ();
                l.Show();
                this.Hide();
            }
        }

        private void changeMain_Load(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
