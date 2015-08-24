using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcSiteMapProvider.Web.Mvc.Filters;

namespace MvcSiteMapProvider_407.Controllers
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Label { get; set; }
    }

    public class ProductController : Controller
    {
        //
        // GET: /Product/
        public ActionResult Index()
        {
            var products = new List<ProductModel>
            {
                new ProductModel {Id = 1, Label = "Product 1"},
                new ProductModel {Id = 2, Label = "Product 2"}
            };

            return View(products);
        }

        //
        // GET: /Product/
        [SiteMapTitle("Label")]
        public ActionResult Details(int id)
        {
            var product = new ProductModel { Id = id, Label = "Product " + id };

            return View(product);
        }
    }
}