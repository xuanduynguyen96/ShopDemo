using ShopDemo.Models.Domain;

namespace ShopDemo.ViewModels
{
    public class HomeViewModel
    {
        public User User { get; set; }

        public List<Item> Items { get; set; }
    }
}
