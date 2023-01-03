using SE1626_Group6_A2.Models;

namespace SE1626_Group6_A2.DAO
{
    public class CartDAO
    {
        MusicStoreContext context = new MusicStoreContext();
        public List<Cart> GetCartsByUser(string username)
        {
            List<Cart> carts = context.Carts.Where(c => c.CartId == username).ToList();
            return carts;
        }
    }
}
