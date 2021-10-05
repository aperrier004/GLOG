namespace App
{
    partial class FormCreerGenre
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
            this.lblTitleCreer = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtNomGenre = new System.Windows.Forms.TextBox();
            this.lblNomGenre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitleCreer
            // 
            this.lblTitleCreer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitleCreer.AutoSize = true;
            this.lblTitleCreer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleCreer.Location = new System.Drawing.Point(151, 10);
            this.lblTitleCreer.Name = "lblTitleCreer";
            this.lblTitleCreer.Size = new System.Drawing.Size(189, 29);
            this.lblTitleCreer.TabIndex = 41;
            this.lblTitleCreer.Text = "Créer un genre";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOK.AutoSize = true;
            this.btnOK.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Enabled = false;
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOK.Location = new System.Drawing.Point(171, 170);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(119, 50);
            this.btnOK.TabIndex = 40;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            // 
            // txtNomGenre
            // 
            this.txtNomGenre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomGenre.Location = new System.Drawing.Point(212, 86);
            this.txtNomGenre.Name = "txtNomGenre";
            this.txtNomGenre.Size = new System.Drawing.Size(217, 22);
            this.txtNomGenre.TabIndex = 39;
            this.txtNomGenre.TextChanged += new System.EventHandler(this.txtNomGenre_TextChanged);
            // 
            // lblNomGenre
            // 
            this.lblNomGenre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomGenre.AutoSize = true;
            this.lblNomGenre.Location = new System.Drawing.Point(68, 91);
            this.lblNomGenre.Name = "lblNomGenre";
            this.lblNomGenre.Size = new System.Drawing.Size(37, 17);
            this.lblNomGenre.TabIndex = 38;
            this.lblNomGenre.Text = "Nom";
            // 
            // FormCreerGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 254);
            this.Controls.Add(this.lblTitleCreer);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtNomGenre);
            this.Controls.Add(this.lblNomGenre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FormCreerGenre";
            this.Text = "FormCreerGenre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleCreer;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtNomGenre;
        private System.Windows.Forms.Label lblNomGenre;
    }
}