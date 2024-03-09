
namespace MicroProjectsupdated
{
    partial class ViewUserForm
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
            this.btnclose = new System.Windows.Forms.Button();
            this.DGVUsers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(201, 447);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(131, 45);
            this.btnclose.TabIndex = 26;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // DGVUsers
            // 
            this.DGVUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUsers.Location = new System.Drawing.Point(1, 1);
            this.DGVUsers.Name = "DGVUsers";
            this.DGVUsers.RowHeadersWidth = 51;
            this.DGVUsers.RowTemplate.Height = 24;
            this.DGVUsers.Size = new System.Drawing.Size(557, 384);
            this.DGVUsers.TabIndex = 25;
            // 
            // ViewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 532);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.DGVUsers);
            this.Name = "ViewUserForm";
            this.Text = "ViewUserForm";
            this.Load += new System.EventHandler(this.ViewUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.DataGridView DGVUsers;
    }
}