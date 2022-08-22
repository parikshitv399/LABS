using ProductLab.Models;
using ProductLab.Product_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductLab.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private readonly ProductOps _productDb = new ProductOps();
        // GET: Product
        [Authorize(Roles = "Admin,User,Developer")]
        public ActionResult Dashboard()
        {
            return View(_productDb.GetAll());
        }
        [HttpGet]
        [Authorize(Roles = "Admin,Developer")]
        public ActionResult Add()
        {
            return View(new Product());
        }
        [HttpPost]
        [Authorize(Roles = "Admin,Developer")]
        public ActionResult Add(Product pProduct)
        {
            _productDb.Add(pProduct);
            return RedirectToAction("Dashboard");
        }
        [HttpGet]
        [Authorize(Roles = "Admin,Developer")]
        public ActionResult Edit(int pId)
        {
            return View(_productDb.GetSingle(pId));
        }
        [HttpPost]
        [Authorize(Roles = "Admin,Developer")]
        public ActionResult Edit(Product pProduct)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _productDb.Update(pProduct.Id, pProduct);
                    return RedirectToAction("Dashboard");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("Not found error", ex.Message);
                    return View("Edit");
                }
            }
            return View("Edit");
        }
        [Authorize(Roles = "Admin,Developer")]
        public ActionResult Delete(int pId)
        {
            return View(_productDb.GetSingle(pId));
        }
        [HttpPost]
        public ActionResult Delete(Product pProduct)
        {
            _productDb.Delete(pProduct);
            return RedirectToAction("Dashboard");
        }

    }
}
