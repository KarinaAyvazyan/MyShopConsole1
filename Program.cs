using MyShop.Data;
//using MyShopConsole.Services;
using MyShop.Data.Entities;
using MyShopConsole.Services;

namespace MyShopConsole;

internal class Program
{
    static void Main(string[] args)
    {
        ShopDataContext shop = new();
        Product product = new Product()
        {
            Name = "Smartphone",
            Discount = 0,
            CategoryId = 1,
            Price = 5000,
            VendorId=1,

        };
        shop.Products.Add(product); 
        shop.SaveChanges();
        Product product3 = new Product()
        {
            Name = "Iphone",
            Discount = 10,
            CategoryId = 1,
            Price = 15000,
            VendorId = 1,

        };
       



    }
}