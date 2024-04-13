using Microsoft.AspNetCore.Mvc;
using ShopDemo.Models.Domain;

namespace ShopDemo.Views.Shared.Components.ItemCard
{
    public class ItemCardViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(Item info)
        {
            // Logic
            if (info.Quantity >= 10)
            {
                info.Name = $"{info.Name} (Hot)";
            }

            return View("ItemCard", info);
        }
    }
}
