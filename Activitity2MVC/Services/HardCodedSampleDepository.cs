using Activitity2MVC.Models;
using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activitity2MVC.Services
{
    public class HardCodedSampleDepository : IProductDataService
    {
        static List<ProductModel> productList = new List<ProductModel>();
        public int Delete(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> GetAllProducts()
        {
            if (productList.Count == 0)
            {
                productList.Add(new ProductModel { Id = 1, Name = "Cat food", Price = 9.99m, Description = "tuna and chicken wetfood" });
                productList.Add(new ProductModel { Id = 2, Name = "Dog food", Price = 19.99m, Description = "Beef and Chicken kibble" });
                productList.Add(new ProductModel { Id = 3, Name = "Guinea pig food", Price = 4.49m, Description = "Fresh Grass and Hay" });
                productList.Add(new ProductModel { Id = 4, Name = "Fish food", Price = 1.23m, Description = "High protein flakes" });


                //Github Bogus Library as reference
                for (int i = 0; i < 100; i++)
                {
                    productList.Add(new Faker<ProductModel>()
                        .RuleFor(p => p.Id, i + 5)
                        .RuleFor(p => p.Name, f => f.Commerce.ProductName())
                        .RuleFor(p => p.Price, f => f.Random.Decimal(100))
                        .RuleFor(p => p.Description, f => f.Rant.Review()));
                }
            }


            return productList;
        }

        public ProductModel GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> SearchProducts(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public int Update(ProductModel product)
        {
            throw new NotImplementedException();
        }
    }
}
