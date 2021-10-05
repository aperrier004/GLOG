namespace App
{
    partial class FormCreerAlbum
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
            this.lsbGenre = new System.Windows.Forms.ListBox();
            this.lsbAuteurs = new System.Windows.Forms.ListBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtEditeurAlbum = new System.Windows.Forms.TextBox();
            this.lblEditeur = new System.Windows.Forms.Label();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.lblAuteur = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.txtNomAlbum = new System.Windows.Forms.TextBox();
            this.lblNomAlbum = new System.Windows.Forms.Label();
            this.txtUrlImg = new System.Windows.Forms.TextBox();
            this.lblUrlImg = new System.Windows.Forms.Label();
            this.lblTitleCreer = new System.Windows.Forms.Label();
            this.lsbSerie = new System.Windows.Forms.ListBox();
            this.lsbCategorie = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOK.AutoSize = true;
            this.btnOK.BackColor = System.Drawing.SystemColors.Control;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Enabled = false;
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOK.Location = new System.Drawing.Point(165, 463);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(119, 50);
            this.btnOK.TabIndex = 34;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            // 
            // lsbGenre
            // 
            this.lsbGenre.FormattingEnabled = true;
            this.lsbGenre.ItemHeight = 16;
            this.lsbGenre.Location = new System.Drawing.Point(201, 343);
            this.lsbGenre.Name = "lsbGenre";
            this.lsbGenre.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lsbGenre.Size = new System.Drawing.Size(217, 52);
            this.lsbGenre.TabIndex = 33;
            // 
            // lsbAuteurs
            // 
            this.lsbAuteurs.FormattingEnabled = true;
            this.lsbAuteurs.ItemHeight = 16;
            this.lsbAuteurs.Location = new System.Drawing.Point(201, 214);
            this.lsbAuteurs.Name = "lsbAuteurs";
            this.lsbAuteurs.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lsbAuteurs.Size = new System.Drawing.Size(217, 52);
            this.lsbAuteurs.TabIndex = 32;
            // 
            // lblGenre
            // 
            this.lblGenre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(57, 343);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(48, 17);
            this.lblGenre.TabIndex = 31;
            this.lblGenre.Text = "Genre";
            // 
            // txtEditeurAlbum
            // 
            this.txtEditeurAlbum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEditeurAlbum.Location = new System.Drawing.Point(201, 409);
            this.txtEditeurAlbum.Name = "txtEditeurAlbum";
            this.txtEditeurAlbum.Size = new System.Drawing.Size(217, 22);
            this.txtEditeurAlbum.TabIndex = 30;
            this.txtEditeurAlbum.TextChanged += new System.EventHandler(this.txtUrlImg_TextChanged);
            // 
            // lblEditeur
            // 
            this.lblEditeur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEditeur.AutoSize = true;
            this.lblEditeur.Location = new System.Drawing.Point(57, 408);
            this.lblEditeur.Name = "lblEditeur";
            this.lblEditeur.Size = new System.Drawing.Size(53, 17);
            this.lblEditeur.TabIndex = 29;
            this.lblEditeur.Text = "Éditeur";
            // 
            // lblCategorie
            // 
            this.lblCategorie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(57, 287);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(69, 17);
            this.lblCategorie.TabIndex = 27;
            this.lblCategorie.Text = "Catégorie";
            // 
            // lblAuteur
            // 
            this.lblAuteur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAuteur.AutoSize = true;
            this.lblAuteur.Location = new System.Drawing.Point(57, 208);
            this.lblAuteur.Name = "lblAuteur";
            this.lblAuteur.Size = new System.Drawing.Size(67, 17);
            this.lblAuteur.TabIndex = 26;
            this.lblAuteur.Text = "Auteur(s)";
            // 
            // lblSerie
            // 
            this.lblSerie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSerie.AutoSize = true;
            this.lblSerie.Location = new System.Drawing.Point(59, 160);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(41, 17);
            this.lblSerie.TabIndex = 24;
            this.lblSerie.Text = "Série";
            // 
            // txtNomAlbum
            // 
            this.txtNomAlbum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomAlbum.Location = new System.Drawing.Point(201, 109);
            this.txtNomAlbum.Name = "txtNomAlbum";
            this.txtNomAlbum.Size = new System.Drawing.Size(217, 22);
            this.txtNomAlbum.TabIndex = 23;
            this.txtNomAlbum.TextChanged += new System.EventHandler(this.txtUrlImg_TextChanged);
            // 
            // lblNomAlbum
            // 
            this.lblNomAlbum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomAlbum.AutoSize = true;
            this.lblNomAlbum.Location = new System.Drawing.Point(57, 114);
            this.lblNomAlbum.Name = "lblNomAlbum";
            this.lblNomAlbum.Size = new System.Drawing.Size(37, 17);
            this.lblNomAlbum.TabIndex = 22;
            this.lblNomAlbum.Text = "Nom";
            // 
            // txtUrlImg
            // 
            this.txtUrlImg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUrlImg.Location = new System.Drawing.Point(201, 66);
            this.txtUrlImg.Name = "txtUrlImg";
            this.txtUrlImg.Size = new System.Drawing.Size(217, 22);
            this.txtUrlImg.TabIndex = 36;
            this.txtUrlImg.TextChanged += new System.EventHandler(this.txtUrlImg_TextChanged);
            // 
            // lblUrlImg
            // 
            this.lblUrlImg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUrlImg.AutoSize = true;
            this.lblUrlImg.Location = new System.Drawing.Point(12, 69);
            this.lblUrlImg.Name = "lblUrlImg";
            this.lblUrlImg.Size = new System.Drawing.Size(186, 17);
            this.lblUrlImg.TabIndex = 35;
            this.lblUrlImg.Text = "Url de l\'image de couverture";
            // 
            // lblTitleCreer
            // 
            this.lblTitleCreer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitleCreer.AutoSize = true;
            this.lblTitleCreer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleCreer.Location = new System.Drawing.Point(141, 9);
            this.lblTitleCreer.Name = "lblTitleCreer";
            this.lblTitleCreer.Size = new System.Drawing.Size(192, 29);
            this.lblTitleCreer.TabIndex = 37;
            this.lblTitleCreer.Text = "Créer un album";
            // 
            // lsbSerie
            // 
            this.lsbSerie.FormattingEnabled = true;
            this.lsbSerie.ItemHeight = 16;
            this.lsbSerie.Location = new System.Drawing.Point(201, 150);
            this.lsbSerie.Name = "lsbSerie";
            this.lsbSerie.Size = new System.Drawing.Size(217, 52);
            this.lsbSerie.TabIndex = 38;
            // 
            // lsbCategorie
            // 
            this.lsbCategorie.FormattingEnabled = true;
            this.lsbCategorie.ItemHeight = 16;
            this.lsbCategorie.Location = new System.Drawing.Point(201, 279);
            this.lsbCategorie.Name = "lsbCategorie";
            this.lsbCategorie.Size = new System.Drawing.Size(217, 52);
            this.lsbCategorie.TabIndex = 39;
            // 
            // FormCreerAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 531);
            this.Controls.Add(this.lsbCategorie);
            this.Controls.Add(this.lsbSerie);
            this.Controls.Add(this.lblTitleCreer);
            this.Controls.Add(this.txtUrlImg);
            this.Controls.Add(this.lblUrlImg);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lsbGenre);
            this.Controls.Add(this.lsbAuteurs);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.txtEditeurAlbum);
            this.Controls.Add(this.lblEditeur);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.lblAuteur);
            this.Controls.Add(this.lblSerie);
            this.Controls.Add(this.txtNomAlbum);
            this.Controls.Add(this.lblNomAlbum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCreerAlbum";
            this.Text = "FormCreerAlbum";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormCreerAlbum_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ListBox lsbGenre;
        private System.Windows.Forms.ListBox lsbAuteurs;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtEditeurAlbum;
        private System.Windows.Forms.Label lblEditeur;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Label lblAuteur;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.TextBox txtNomAlbum;
        private System.Windows.Forms.Label lblNomAlbum;
        private System.Windows.Forms.TextBox txtUrlImg;
        private System.Windows.Forms.Label lblUrlImg;
        private System.Windows.Forms.Label lblTitleCreer;
        private System.Windows.Forms.ListBox lsbSerie;
        private System.Windows.Forms.ListBox lsbCategorie;
    }
}