
namespace MicroProjectsupdated
{
    partial class changepwdwithHintQ
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbHQue = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.optHQue = new System.Windows.Forms.RadioButton();
            this.optOldPwd = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRepwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewpwd = new System.Windows.Forms.TextBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtHanswer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbHQue
            // 
            this.cmbHQue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHQue.FormattingEnabled = true;
            this.cmbHQue.Items.AddRange(new object[] {
            "What is Your Favorite Color?",
            "What is Your Favorite Pet Name?",
            "What is Your Favorite Hero/Heroin?"});
            this.cmbHQue.Location = new System.Drawing.Point(277, 125);
            this.cmbHQue.Name = "cmbHQue";
            this.cmbHQue.Size = new System.Drawing.Size(212, 33);
            this.cmbHQue.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(59, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 25);
            this.label7.TabIndex = 52;
            this.label7.Text = "Select Hint Question";
            // 
            // optHQue
            // 
            this.optHQue.AutoSize = true;
            this.optHQue.Checked = true;
            this.optHQue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optHQue.Location = new System.Drawing.Point(311, 67);
            this.optHQue.Name = "optHQue";
            this.optHQue.Size = new System.Drawing.Size(206, 29);
            this.optHQue.TabIndex = 51;
            this.optHQue.TabStop = true;
            this.optHQue.Text = "Using Hint Question";
            this.optHQue.UseVisualStyleBackColor = true;
            // 
            // optOldPwd
            // 
            this.optOldPwd.AutoSize = true;
            this.optOldPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optOldPwd.Location = new System.Drawing.Point(48, 67);
            this.optOldPwd.Name = "optOldPwd";
            this.optOldPwd.Size = new System.Drawing.Size(210, 29);
            this.optOldPwd.TabIndex = 50;
            this.optOldPwd.Text = "Using Old Password";
            this.optOldPwd.UseVisualStyleBackColor = true;
            this.optOldPwd.CheckedChanged += new System.EventHandler(this.optOldPwd_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(237, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 49;
            this.label4.Text = "Select Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 25);
            this.label3.TabIndex = 48;
            this.label3.Text = "Re-Enter Password";
            // 
            // txtRepwd
            // 
            this.txtRepwd.Location = new System.Drawing.Point(277, 311);
            this.txtRepwd.Multiline = true;
            this.txtRepwd.Name = "txtRepwd";
            this.txtRepwd.Size = new System.Drawing.Size(212, 38);
            this.txtRepwd.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "Enter  New Password";
            // 
            // txtNewpwd
            // 
            this.txtNewpwd.Location = new System.Drawing.Point(277, 245);
            this.txtNewpwd.Multiline = true;
            this.txtNewpwd.Name = "txtNewpwd";
            this.txtNewpwd.Size = new System.Drawing.Size(212, 38);
            this.txtNewpwd.TabIndex = 45;
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(322, 390);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(88, 45);
            this.btnclose.TabIndex = 44;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(125, 390);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(133, 45);
            this.btnSubmit.TabIndex = 43;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtHanswer
            // 
            this.txtHanswer.Location = new System.Drawing.Point(277, 176);
            this.txtHanswer.Multiline = true;
            this.txtHanswer.Name = "txtHanswer";
            this.txtHanswer.Size = new System.Drawing.Size(212, 38);
            this.txtHanswer.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "Enter Hint Answer";
            // 
            // changepwdwithold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 461);
            this.Controls.Add(this.cmbHQue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.optHQue);
            this.Controls.Add(this.optOldPwd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRepwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewpwd);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtHanswer);
            this.Controls.Add(this.label1);
            this.Name = "changepwdwithold";
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.changepwdwithold_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbHQue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton optHQue;
        private System.Windows.Forms.RadioButton optOldPwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRepwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewpwd;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtHanswer;
        private System.Windows.Forms.Label label1;
    }
}