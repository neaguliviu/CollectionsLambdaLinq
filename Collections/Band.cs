using System;

namespace Collections
{
    public class Band : IComparable
    {
        public string Name { get; private set; }
        public int StudioAlbums { get; private set; }
        public string Genre { get; private set; }
        public string Country { get; private set; }

        public Band(string name, int studioAlbums, string genre, string country)
        {
            Name = name;
            StudioAlbums = studioAlbums;
            Genre = genre;
            Country = country;
        }


        //Implement the IComparable interface in the Band class
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Band otherBand = obj as Band;
            if (otherBand != null)
                return this.StudioAlbums.CompareTo(otherBand.StudioAlbums);
            else
                throw new ArgumentException("Object is not a Band!");

        }

    }
}
