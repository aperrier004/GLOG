namespace App
{
    partial class FormSaisie
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
            this.lblErreur = new System.Windows.Forms.Label();
            this.txtEntree = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblErreur
            // 
            this.lblErreur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErreur.Location = new System.Drawing.Point(0, 10);
            this.lblErreur.Name = "lblErreur";
            this.lblErreur.Size = new System.Drawing.Size(423, 46);
            this.lblErreur.TabIndex = 0;
            this.lblErreur.Text = "-----";
            this.lblErreur.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtEntree
            // 
            this.txtEntree.Location = new System.Drawing.Point(123, 71);
            this.txtEntree.Name = "txtEntree";
            this.txtEntree.Size = new System.Drawing.Size(179, 22);
            this.txtEntree.TabIndex = 1;
            this.txtEntree.TextChanged += new System.EventHandler(this.txtEntree_TextChanged);
            // 
            // btnOK
            // 
            this.btnOK.AutoSize = true;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(180, 105);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(62, 27);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "Valider";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // FormSaisie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 140);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtEntree);
            this.Controls.Add(this.lblErreur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSaisie";
            this.Text = "Erreur de saisie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblErreur;
        private System.Windows.Forms.TextBox txtEntree;
        private System.Windows.Forms.Button btnOK;
    }
}