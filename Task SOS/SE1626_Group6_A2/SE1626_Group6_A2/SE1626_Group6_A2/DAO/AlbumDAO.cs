using SE1626_Group6_A2.Models;

namespace SE1626_Group6_A2.DAO
{
    internal class AlbumDAO
    {

        public List<Album> LoadAllAlbum()
        {
            MusicStoreContext musicStore = new MusicStoreContext();
            List<Album> list = new List<Album>();
            list = musicStore.Albums.ToList();
            return list;
        }
        public List<Album> LoadPaginationAlbum(int page, int quantity, List<Album> listA)
        {
            var listPage = listA.Skip((page - 1) * quantity).Take(quantity).ToList();
            return listPage;
        }

        public List<Album> LoadAlbumByGenre(int genreID)
        {
            var list = new List<Album>();
            list = LoadAllAlbum();
            var listPage = list.Where(p => p.GenreId == genreID).ToList();
            return listPage;
        }

        public List<Album> LoadAlbumByTitle(string search)
        {
            var list = new List<Album>();
            list = LoadAllAlbum();
            var listPage = list.Where(p => p.Title.Contains(search)).ToList();
            return listPage;
        }

        public Album LoadAlbumByID(int id)
        {
            var list = new List<Album>();
            list = LoadAllAlbum();
            Album albums = list.Where(p => p.AlbumId == id).FirstOrDefault();

            return albums;
        }

        public void Delete(int id)
        {
            var list = new List<Album>();
            list = LoadAllAlbum();
            Album albums = LoadAlbumByID(id);
            MusicStoreContext musicStore = new MusicStoreContext();
            try
            {
                musicStore.Remove(albums);
                musicStore.SaveChanges();
                MessageBox.Show("That album is deleted");
            }
            catch
            {
                MessageBox.Show("Album is ordered");
            }


        }
        public void AddAlbums(Album album)
        {
            MusicStoreContext musicStore = new MusicStoreContext();
            try
            {
                musicStore.Albums.Add(album);
                musicStore.SaveChanges();
                MessageBox.Show("That album is added");
            }
            catch
            {
                MessageBox.Show("Error");
            }


        }

    }
}
