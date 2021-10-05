using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Genre
    {
        public virtual int Id { get; set; }
        public virtual string NomGenre { get; set; }
        public virtual IList<Album> ListeAlbums { get; set; }

        public Genre() { }

        public Genre(string genre)
        {
            NomGenre = genre;
            ListeAlbums = new List<Album>();
        }

        public override string ToString()
        {
            return NomGenre.ToString();
        }
    }
}
