using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    class Fonctions
    {
        /// <summary>
        /// Fonction qui permet de remplacer une chaine de caractère pour l'avoir
        /// sans accents ou caractères spéciaux, sinon elle demande de réecrire
        /// </summary>
        /// <param name="chaineEntree">Chaine de caractère entrée par l'utilisateur</param>
        /// <returns>Chaine de caractère correcte</returns>
        public static string RemplacerChaine(string chaineEntree)
        {
            string chaineRetour = Regex.Replace(chaineEntree, "[^a-zA-Z0-9_]", "");
            if(chaineEntree != chaineRetour)
            {
                // Appelle un formulaire pour saisir la nouvelle valeur
                FormSaisie dlgSaisie = new FormSaisie(chaineEntree);
                if (dlgSaisie.ShowDialog() == DialogResult.OK)
                {
                    chaineRetour = dlgSaisie.NouvelleChaine;
                }
            }
            return chaineRetour;
        }
    }
}
