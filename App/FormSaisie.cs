using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class FormSaisie : Form
    {
        public FormSaisie(string valeurEntree)
        {
            InitializeComponent();
            lblErreur.Text = "Les caractères spéciaux ou accents ne sont pas admis \n Veuillez réécrire :\n" + valeurEntree;
        }

        private string nouvelleChaine;

        public string NouvelleChaine
        {
            get { return nouvelleChaine; }
            set { nouvelleChaine = value; }
        }

        private void txtEntree_TextChanged(object sender, EventArgs e)
        {
            // N'active le bouton que si tous les champs sont remplis et conforme
            if (txtEntree.Text != "" && !Regex.Match(txtEntree.Text, "[^a-zA-Z0-9_]").Success)
            {
                nouvelleChaine = txtEntree.Text;
                btnOK.Enabled = true;
                btnOK.BackColor = Color.FromName("Highlight");
            }
            else
            {
                btnOK.Enabled = false;
                btnOK.BackColor = Color.FromName("Control");
            }
        }
    }
}
