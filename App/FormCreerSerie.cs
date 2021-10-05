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
    public partial class FormCreerSerie : Form
    {
        public FormCreerSerie()
        {
            InitializeComponent();
        }
        public Serie GetSerie()
        {
            return (new Serie(Fonctions.RemplacerChaine(txtNomSerie.Text)));
        }


        private void txtNomSerie_TextChanged(object sender, EventArgs e)
        {
            // N'active le bouton que si tous les champs sont remplis
            if (txtNomSerie.Text != "")
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
