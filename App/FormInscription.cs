using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class FormInscription : Form
    {
        public FormInscription()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Renvoie le nouvel utilisateur
        /// </summary>
        /// <returns>Retourne un objet Utilisateur</returns>
        public Utilisateur GetUtilisateur()
        {
            return (new Utilisateur(Fonctions.RemplacerChaine(txtNom.Text), Fonctions.RemplacerChaine(txtPrenom.Text), Fonctions.RemplacerChaine(txtLogin.Text), Fonctions.RemplacerChaine(txtMdp.Text)));
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            // N'active le bouton que si tous les champs sont remplis
            if (txtLogin.Text != "" && txtMdp.Text != "" && txtNom.Text != "" && txtPrenom.Text != "")
            {
                btnValider.Enabled = true;
                btnValider.BackColor = Color.FromName("Highlight");
            }
            else
            {
                btnValider.Enabled = false;
                btnValider.BackColor = Color.FromName("Control");
            }
        }
    }
}
