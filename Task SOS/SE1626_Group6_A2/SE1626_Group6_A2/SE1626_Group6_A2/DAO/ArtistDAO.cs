using SE1626_Group6_A2.Models;

namespace SE1626_Group6_A2.DAO
{
    internal class ArtistDAO
    {
        public Artist GetArtistByID(int Id)
        {
            Artist artist = new Artist();
            MusicStoreContext musicStoreContext = new MusicStoreContext();
            artist = musicStoreContext.Artists.ToList().Where(p => p.ArtistId == Id).FirstOrDefault();
            return artist;
        }
    }
}
