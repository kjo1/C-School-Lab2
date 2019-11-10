namespace Parent_Form
{
    partial class frmListAllChidren
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
            this.lstChildren = new System.Windows.Forms.ListBox();
            this.lblChildren = new System.Windows.Forms.Label();
            this.llblClose = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lstChildren
            // 
            this.lstChildren.FormattingEnabled = true;
            this.lstChildren.Location = new System.Drawing.Point(18, 30);
            this.lstChildren.Name = "lstChildren";
            this.lstChildren.Size = new System.Drawing.Size(237, 264);
            this.lstChildren.TabIndex = 0;
            // 
            // lblChildren
            // 
            this.lblChildren.AutoSize = true;
            this.lblChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblChildren.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblChildren.Location = new System.Drawing.Point(28, 8);
            this.lblChildren.Name = "lblChildren";
            this.lblChildren.Size = new System.Drawing.Size(140, 17);
            this.lblChildren.TabIndex = 1;
            this.lblChildren.Text = "All Your Children: ";
            // 
            // llblClose
            // 
            this.llblClose.AutoSize = true;
            this.llblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.llblClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.llblClose.LinkColor = System.Drawing.Color.White;
            this.llblClose.Location = new System.Drawing.Point(209, 9);
            this.llblClose.Name = "llblClose";
            this.llblClose.Size = new System.Drawing.Size(48, 17);
            this.llblClose.TabIndex = 2;
            this.llblClose.TabStop = true;
            this.llblClose.Text = "Close";
            this.llblClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblClose_LinkClicked);
            // 
            // frmListAllChidren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(272, 309);
            this.Controls.Add(this.llblClose);
            this.Controls.Add(this.lblChildren);
            this.Controls.Add(this.lstChildren);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListAllChidren";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All your children";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstChildren;
        private System.Windows.Forms.Label lblChildren;
        private System.Windows.Forms.LinkLabel llblClose;
    }
}