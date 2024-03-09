
namespace MicroProjectsupdated
{
    partial class ViewBillForm
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
            this.cmbBillNumber = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DGVItems = new System.Windows.Forms.DataGridView();
            this.DGVBill = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBill)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBillNumber
            // 
            this.cmbBillNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBillNumber.FormattingEnabled = true;
            this.cmbBillNumber.Location = new System.Drawing.Point(231, 11);
            this.cmbBillNumber.Name = "cmbBillNumber";
            this.cmbBillNumber.Size = new System.Drawing.Size(157, 34);
            this.cmbBillNumber.TabIndex = 72;
            this.cmbBillNumber.SelectedIndexChanged += new System.EventHandler(this.cmbBillNumber_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 71;
            this.label3.Text = "Item Details";
            // 
            // DGVItems
            // 
            this.DGVItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVItems.Location = new System.Drawing.Point(27, 243);
            this.DGVItems.Name = "DGVItems";
            this.DGVItems.RowHeadersWidth = 51;
            this.DGVItems.RowTemplate.Height = 24;
            this.DGVItems.Size = new System.Drawing.Size(626, 209);
            this.DGVItems.TabIndex = 70;
            // 
            // DGVBill
            // 
            this.DGVBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBill.Location = new System.Drawing.Point(27, 99);
            this.DGVBill.Name = "DGVBill";
            this.DGVBill.RowHeadersWidth = 51;
            this.DGVBill.RowTemplate.Height = 24;
            this.DGVBill.Size = new System.Drawing.Size(626, 82);
            this.DGVBill.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 68;
            this.label2.Text = "Bill Details";
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(266, 467);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(88, 45);
            this.btnclose.TabIndex = 67;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 66;
            this.label1.Text = "Select Bill Number";
            // 
            // ViewBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 542);
            this.Controls.Add(this.cmbBillNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DGVItems);
            this.Controls.Add(this.DGVBill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.label1);
            this.Name = "ViewBillForm";
            this.Text = "View Bill";
            this.Load += new System.EventHandler(this.ViewBillForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBillNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGVItems;
        private System.Windows.Forms.DataGridView DGVBill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label1;
    }
}