using MvcSiteMapProvider.Web.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSiteMapProvider_407.Controllers
{
    public class ProductRelatedItemModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Label { get; set; }
        public int ParentId { get; set; }
        public string ParentLabel { get; set; }
    }

    public class ProductRelatedItemController : Controller
    {
        //
        // GET: /ProductRelatedItem/
        [SiteMapTitle("Label")]
        [SiteMapTitle("ParentLabel", Target = AttributeTarget.ParentNode )]
        public ActionResult Index(int productId, int id)
        {
            var productRelatedItem = new ProductRelatedItemModel()
            {
                Id = 1,
                Label = "Product Related Item",
                ProductId = productId,
                ParentId = id,
                ParentLabel = "Product " + id.ToString()
            };

            return View(productRelatedItem);
        }
    }
}