namespace App
{
    partial class FormProfil
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
            this.btnOK = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblProfilUtilisateur = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOK.AutoSize = true;
            this.btnOK.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOK.Location = new System.Drawing.Point(174, 330);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(119, 50);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            // 
            // txtNom
            // 
            this.txtNom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNom.Enabled = false;
            this.txtNom.Location = new System.Drawing.Point(174, 104);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(272, 22);
            this.txtNom.TabIndex = 12;
            // 
            // lblNom
            // 
            this.lblNom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(30, 109);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(37, 17);
            this.lblNom.TabIndex = 11;
            this.lblNom.Text = "Nom";
            // 
            // lblProfilUtilisateur
            // 
            this.lblProfilUtilisateur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProfilUtilisateur.AutoSize = true;
            this.lblProfilUtilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfilUtilisateur.Location = new System.Drawing.Point(116, 29);
            this.lblProfilUtilisateur.Name = "lblProfilUtilisateur";
            this.lblProfilUtilisateur.Size = new System.Drawing.Size(245, 38);
            this.lblProfilUtilisateur.TabIndex = 10;
            this.lblProfilUtilisateur.Text = "Profil Utilisateur";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrenom.Enabled = false;
            this.txtPrenom.Location = new System.Drawing.Point(174, 194);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(272, 22);
            this.txtPrenom.TabIndex = 15;
            // 
            // lblPrenom
            // 
            this.lblPrenom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(30, 199);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(57, 17);
            this.lblPrenom.TabIndex = 14;
            this.lblPrenom.Text = "Prenom";
            // 
            // FormProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 410);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblProfilUtilisateur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormProfil";
            this.Text = "Profil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblProfilUtilisateur;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblPrenom;
    }
}