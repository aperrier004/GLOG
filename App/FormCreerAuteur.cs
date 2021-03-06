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
    public partial class FormCreerAuteur : Form
    {
        public FormCreerAuteur()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Créer un nouvel objet Auteur
        /// </summary>
        /// <returns>Retourne un objet auteur</returns>
        public Auteur GetAuteur()
        {
            return (new Auteur(Fonctions.RemplacerChaine(txtNomAuteur.Text),Fonctions.RemplacerChaine(txtPrenomAuteur.Text)));
        }

        private void txtPrenomAuteur_TextChanged(object sender, EventArgs e)
        {
            // N'active le bouton que si tous les champs sont remplis
            if (txtNomAuteur.Text != "" && txtPrenomAuteur.Text != "")
            {
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
