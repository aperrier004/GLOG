namespace App
{
    partial class FormCreerSerie
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
            this.txtNomSerie = new System.Windows.Forms.TextBox();
            this.lblNomSerie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitleCreer
            // 
            this.lblTitleCreer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitleCreer.AutoSize = true;
            this.lblTitleCreer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleCreer.Location = new System.Drawing.Point(96, 75);
            this.lblTitleCreer.Name = "lblTitleCreer";
            this.lblTitleCreer.Size = new System.Drawing.Size(195, 29);
            this.lblTitleCreer.TabIndex = 45;
            this.lblTitleCreer.Text = "Créer une série";
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
            this.btnOK.Location = new System.Drawing.Point(116, 235);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(119, 50);
            this.btnOK.TabIndex = 44;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            // 
            // txtNomSerie
            // 
            this.txtNomSerie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomSerie.Location = new System.Drawing.Point(157, 151);
            this.txtNomSerie.Name = "txtNomSerie";
            this.txtNomSerie.Size = new System.Drawing.Size(217, 22);
            this.txtNomSerie.TabIndex = 43;
            this.txtNomSerie.TextChanged += new System.EventHandler(this.txtNomSerie_TextChanged);
            // 
            // lblNomSerie
            // 
            this.lblNomSerie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomSerie.AutoSize = true;
            this.lblNomSerie.Location = new System.Drawing.Point(35, 151);
            this.lblNomSerie.Name = "lblNomSerie";
            this.lblNomSerie.Size = new System.Drawing.Size(37, 17);
            this.lblNomSerie.TabIndex = 42;
            this.lblNomSerie.Text = "Nom";
            // 
            // FormCreerSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 361);
            this.Controls.Add(this.lblTitleCreer);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtNomSerie);
            this.Controls.Add(this.lblNomSerie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCreerSerie";
            this.Text = "FormCreerSerie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleCreer;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtNomSerie;
        private System.Windows.Forms.Label lblNomSerie;
    }
}