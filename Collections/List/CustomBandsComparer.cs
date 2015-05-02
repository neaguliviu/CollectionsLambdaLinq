using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.List
{
    public class CustomBandsComparer : IComparer<Band>
    {
        private readonly BandsCompareBy compareBy;

        public CustomBandsComparer(BandsCompareBy compareBy)
        {
            this.compareBy = compareBy;
        }

        public int Compare(Band firstBand, Band secondBand)
        {
            switch (compareBy)
            {
                case BandsCompareBy.Name:
                {
                    return CompareByName(firstBand, secondBand);
                }
                case BandsCompareBy.Country:
                {
                    return CompareByCountry(firstBand, secondBand);
                }
                case BandsCompareBy.NameLength:
                {
                    return CompareByNameLength(firstBand, secondBand);
                }
                default:
                    return CompareByAlbumCount(firstBand, secondBand);
            }
        }

        private int CompareByAlbumCount(Band firstBand, Band secondBand)
        {
            if (firstBand.StudioAlbums > secondBand.StudioAlbums)
            {
                return -1;
            }

            if (firstBand.StudioAlbums < secondBand.StudioAlbums)
            {
                return 1;
            }

            return 0;
        }

        private int CompareByCountry(Band firstBand, Band secondBand)
        {
            return string.Compare(firstBand.Country, secondBand.Country, StringComparison.CurrentCulture);
        }

        private int CompareByName(Band firstBand, Band secondBand)
        {
            return string.Compare(firstBand.Name, secondBand.Name, StringComparison.CurrentCulture);
        }

        private int CompareByNameLength(Band firstBand, Band secondBand)
        {
            if (firstBand.Name.Length > secondBand.Name.Length)
                return 1;
            if (firstBand.Name.Length < secondBand.Name.Length)
                return -1;
            return 0;

        }
    }

    public enum BandsCompareBy
    {
        Name,
        AlbumCount,
        Country,
        NameLength
    }
}
