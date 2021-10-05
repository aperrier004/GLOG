namespace App
{
    partial class FormInscription
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
            this.lblFormInscription = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblMdp = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFormInscription
            // 
            this.lblFormInscription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFormInscription.AutoSize = true;
            this.lblFormInscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormInscription.Location = new System.Drawing.Point(92, 25);
            this.lblFormInscription.Name = "lblFormInscription";
            this.lblFormInscription.Size = new System.Drawing.Size(352, 38);
            this.lblFormInscription.TabIndex = 0;
            this.lblFormInscription.Text = "Formulaire d\'inscription";
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(68, 104);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(43, 17);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Login";
            // 
            // lblMdp
            // 
            this.lblMdp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMdp.AutoSize = true;
            this.lblMdp.Location = new System.Drawing.Point(68, 162);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(93, 17);
            this.lblMdp.TabIndex = 2;
            this.lblMdp.Text = "Mot de passe";
            // 
            // lblNom
            // 
            this.lblNom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(68, 220);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(37, 17);
            this.lblNom.TabIndex = 3;
            this.lblNom.Text = "Nom";
            // 
            // lblPrenom
            // 
            this.lblPrenom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(68, 278);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(57, 17);
            this.lblPrenom.TabIndex = 4;
            this.lblPrenom.Text = "Prénom";
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLogin.Location = new System.Drawing.Point(212, 99);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(272, 22);
            this.txtLogin.TabIndex = 5;
            this.txtLogin.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
            // 
            // txtMdp
            // 
            this.txtMdp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMdp.Location = new System.Drawing.Point(212, 159);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(272, 22);
            this.txtMdp.TabIndex = 6;
            this.txtMdp.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
            // 
            // txtNom
            // 
            this.txtNom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNom.Location = new System.Drawing.Point(212, 217);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(272, 22);
            this.txtNom.TabIndex = 7;
            this.txtNom.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
            // 
            // txtPrenom
            // 
            this.txtPrenom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrenom.Location = new System.Drawing.Point(212, 273);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(272, 22);
            this.txtPrenom.TabIndex = 8;
            this.txtPrenom.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
            // 
            // btnValider
            // 
            this.btnValider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnValider.AutoSize = true;
            this.btnValider.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnValider.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnValider.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnValider.FlatAppearance.BorderSize = 0;
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.SystemColors.Control;
            this.btnValider.Location = new System.Drawing.Point(212, 325);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(119, 50);
            this.btnValider.TabIndex = 9;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            // 
            // FormInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 404);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblFormInscription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormInscription";
            this.Text = "Formulaire d\'inscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormInscription;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Button btnValider;
    }
}