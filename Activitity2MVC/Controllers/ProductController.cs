using Activitity2MVC.Models;
using Activitity2MVC.Services;
using Bogus;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activitity2MVC.Controllers
{
    public class ProductController : Controller
    {
               
        public IActionResult Index()
        {

            ProductsDOA products = new ProductsDOA();
            return View(products.GetAllProducts());
        }

        public IActionResult SearchResults(string searchTerm)
        {

            ProductsDOA products = new ProductsDOA();
            List<ProductModel> productList = products.SearchProducts(searchTerm);

            return View("index", productList);
        }

        public IActionResult ShowDetails(int id)
        {

            ProductsDOA products = new ProductsDOA();
            ProductModel foundProduct = products.GetProductById(id);

            return View(foundProduct);
        }

        public IActionResult Edit(int id)
        {
            ProductsDOA products = new ProductsDOA();
            ProductModel foundProduct = products.GetProductById(id);

            return View("ShowEdit", foundProduct);
        }

        public IActionResult ProcessEdit(ProductModel product)
        {
            ProductsDOA products = new ProductsDOA();
            products.Update(product);

            return View("Index", products.GetAllProducts());
        }

        public IActionResult InputForm()
        {
                 return View();
        }

        public IActionResult ProcessCreate(ProductModel product)
        {
            ProductsDOA products = new ProductsDOA();
            products.Insert(product);

            return View("Index", products.GetAllProducts());
        }

        public IActionResult Delete(int id)
        {
            ProductsDOA products = new ProductsDOA();
            ProductModel foundProduct = products.GetProductById(id);
            products.Delete(foundProduct);

            return View("Index", products.GetAllProducts());
        }

        //public IActionResult CreateProductModel()
        //{
        //    ProductModel newProduct = new ProductModel();
        //    ProductsDOA products = new ProductsDOA();


        //    List<ProductModel> productList = productList.Add(products.Insert(newProduct));

        //    return View();
        //}

        public IActionResult SearchForm()
        {
            return View();
        }

        public IActionResult Message()
        {
            return View("message");
        }

        public IActionResult Welcome(string name, int secretNumber=13)
        {
            ViewBag.Name = name;
            ViewBag.Secret = secretNumber;

            return View();
        }
    }
}
