using System;
using DAL;
using Domain;
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
    public partial class FormCreerAlbum : Form
    {
        public FormCreerAlbum(IAuteurRepository auteurRepository, ISerieRepository serieRepository, IGenreRepository genreRepository, ICategorieRepository categorieRepository)
        {
            InitializeComponent();
            // On remplit les listes des objets correspondants
            foreach (Auteur auteur in auteurRepository.GetAll())
            {
                lsbAuteurs.Items.Add(auteur);
                lsbAuteurs.DisplayMember = "Nom";
            }
            foreach (Categorie categorie in categorieRepository.GetAll())
            {
                lsbCategorie.Items.Add(categorie);
                lsbCategorie.DisplayMember = "NomCategorie";
            }
            foreach (Genre genre in genreRepository.GetAll())
            {
                lsbGenre.Items.Add(genre);
                lsbGenre.DisplayMember = "NomGenre";
            }
            foreach (Serie serie in serieRepository.GetAll())
            {
                lsbSerie.Items.Add(serie);
                lsbSerie.DisplayMember = "NomSerie";
            }
        }

        /// <summary>
        /// Permet de créer un objet Album avec les infos du form
        /// </summary>
        /// <returns>Un objet Album</returns>
        public Album GetAlbum()
        {
            List<Auteur> listeAuteurs = new List<Auteur>();
            foreach(Auteur auteur in lsbAuteurs.SelectedItems)
            {
                listeAuteurs.Add(auteur);
            }

            List<Genre> listeGenres = new List<Genre>();
            foreach (Genre genre in lsbGenre.SelectedItems)
            {
                listeGenres.Add(genre);
            }

            return (new Album(txtUrlImg.Text, Fonctions.RemplacerChaine(txtNomAlbum.Text),
                Fonctions.RemplacerChaine(txtEditeurAlbum.Text), listeAuteurs,
                    (Serie)lsbSerie.SelectedItem, (Categorie)lsbCategorie.SelectedItem, listeGenres));
        }

        private void FormCreerAlbum_MouseClick(object sender, MouseEventArgs e)
        {
            // On active le bouton OK que si toutes les informations ont été rentrées / sélectionnées
            if(txtEditeurAlbum.Text != "" && txtNomAlbum.Text != "" && txtUrlImg.Text != "" && lsbAuteurs.SelectedItem != null && lsbCategorie.SelectedItem != null && lsbGenre.SelectedItem != null && lsbSerie.SelectedItem != null)
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


        private void txtUrlImg_TextChanged(object sender, EventArgs e)
        {
            // On active le bouton OK que si toutes les informations ont été rentrées / sélectionnées
            if (txtEditeurAlbum.Text != "" && txtNomAlbum.Text != "" && txtUrlImg.Text != "" && lsbAuteurs.SelectedItem != null && lsbCategorie.SelectedItem != null && lsbGenre.SelectedItem != null && lsbSerie.SelectedItem != null)
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
