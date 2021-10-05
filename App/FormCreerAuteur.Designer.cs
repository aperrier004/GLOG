namespace App
{
    partial class FormCreerAuteur
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
            this.txtNomAuteur = new System.Windows.Forms.TextBox();
            this.lblNomAuteur = new System.Windows.Forms.Label();
            this.txtPrenomAuteur = new System.Windows.Forms.TextBox();
            this.lblPrenomAuteur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitleCreer
            // 
            this.lblTitleCreer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitleCreer.AutoSize = true;
            this.lblTitleCreer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleCreer.Location = new System.Drawing.Point(117, 66);
            this.lblTitleCreer.Name = "lblTitleCreer";
            this.lblTitleCreer.Size = new System.Drawing.Size(194, 29);
            this.lblTitleCreer.TabIndex = 45;
            this.lblTitleCreer.Text = "Créer un auteur";
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
            this.btnOK.Location = new System.Drawing.Point(157, 258);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(119, 50);
            this.btnOK.TabIndex = 44;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            // 
            // txtNomAuteur
            // 
            this.txtNomAuteur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomAuteur.Location = new System.Drawing.Point(178, 130);
            this.txtNomAuteur.Name = "txtNomAuteur";
            this.txtNomAuteur.Size = new System.Drawing.Size(217, 22);
            this.txtNomAuteur.TabIndex = 43;
            this.txtNomAuteur.TextChanged += new System.EventHandler(this.txtPrenomAuteur_TextChanged);
            // 
            // lblNomAuteur
            // 
            this.lblNomAuteur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomAuteur.AutoSize = true;
            this.lblNomAuteur.Location = new System.Drawing.Point(34, 135);
            this.lblNomAuteur.Name = "lblNomAuteur";
            this.lblNomAuteur.Size = new System.Drawing.Size(37, 17);
            this.lblNomAuteur.TabIndex = 42;
            this.lblNomAuteur.Text = "Nom";
            // 
            // txtPrenomAuteur
            // 
            this.txtPrenomAuteur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrenomAuteur.Location = new System.Drawing.Point(178, 183);
            this.txtPrenomAuteur.Name = "txtPrenomAuteur";
            this.txtPrenomAuteur.Size = new System.Drawing.Size(217, 22);
            this.txtPrenomAuteur.TabIndex = 47;
            this.txtPrenomAuteur.TextChanged += new System.EventHandler(this.txtPrenomAuteur_TextChanged);
            // 
            // lblPrenomAuteur
            // 
            this.lblPrenomAuteur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrenomAuteur.AutoSize = true;
            this.lblPrenomAuteur.Location = new System.Drawing.Point(34, 188);
            this.lblPrenomAuteur.Name = "lblPrenomAuteur";
            this.lblPrenomAuteur.Size = new System.Drawing.Size(57, 17);
            this.lblPrenomAuteur.TabIndex = 46;
            this.lblPrenomAuteur.Text = "Prenom";
            // 
            // FormCreerAuteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 342);
            this.Controls.Add(this.txtPrenomAuteur);
            this.Controls.Add(this.lblPrenomAuteur);
            this.Controls.Add(this.lblTitleCreer);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtNomAuteur);
            this.Controls.Add(this.lblNomAuteur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCreerAuteur";
            this.Text = "FormCreerAuteur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleCreer;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtNomAuteur;
        private System.Windows.Forms.Label lblNomAuteur;
        private System.Windows.Forms.TextBox txtPrenomAuteur;
        private System.Windows.Forms.Label lblPrenomAuteur;
    }
}