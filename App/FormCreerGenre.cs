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
    public partial class FormCreerGenre : Form
    {
        public FormCreerGenre()
        {
            InitializeComponent();
        }

        public Genre GetGenre()
        {
            return (new Genre(Fonctions.RemplacerChaine(txtNomGenre.Text)));
        }
        private void txtNomGenre_TextChanged(object sender, EventArgs e)
        {
            // N'active le bouton que si tous les champs sont remplis
            if (txtNomGenre.Text != "")
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
