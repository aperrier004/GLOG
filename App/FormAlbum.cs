using DAL;
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
    public partial class FormAlbum : Form
    {
        public FormAlbum(Album album, IAuteurRepository auteurRepository, IGenreRepository genreRepository)
        {
            InitializeComponent();

            // Ajout des informations de l'album correspondant
            string urlImg = album.ImgCouv;
            picImgCouv.ImageLocation = urlImg;
            txtNomAlbum.Text = album.NomAlbum;
            txtSerieAlbum.Text = album.Serie.NomSerie;

            // On ajoute à la liste tous les auteurs de l'album
            foreach(Auteur auteur in auteurRepository.GetAuteursParAlbumId(album.Id))
            {
                lsbAuteurs.Items.Add(auteur);
                lsbAuteurs.DisplayMember = auteur.ToString();
            }

            txtCategorieAlbum.Text = album.Categorie.NomCategorie;

            // On ajoute à la liste tous les genres de l'album
            foreach (Genre genre in genreRepository.GetGenresParAlbumNom(album.NomAlbum))
            {
                lsbGenre.Items.Add(genre);
                lsbGenre.DisplayMember = "NomGenre";
            }

            txtEditeurAlbum.Text = album.Editeur;

        }
    }
}
