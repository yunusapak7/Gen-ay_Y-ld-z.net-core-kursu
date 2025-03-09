using Microsoft.AspNetCore.Mvc;
using Örnek_uygulama.Models;

namespace Örnek_uygulama.Controllers
{
    [Route("[controller]")]
    public class ProductController : Controller
    {
        [HttpGet("")]
        //public IActionResult GetProducts()
        //{
        //    Product product = new Product();
        //    return View();
        //}


        #region ViewResult
        public ViewResult GetProducts1()
        {
            return View();
        }

        #endregion

        #region PartialViewResult
        public PartialViewResult GetProducts2()
        {
            return PartialView();
        }

        #endregion

        #region JSONResult
        public JsonResult GetProducts3()
        {
            return Json(new Product
            {
                Id = 1,
                ProductName = "Laptop",
                Quantity = 1,
            });

        }

        #endregion

        #region EmptyResult
        public EmptyResult GetProducts4()
        {
            return new EmptyResult();

        }

        #endregion

        #region ContentResult
        public ContentResult GetProducts5()
        {
            return Content("istemciye metin göndermek için kullanılır");
        }
        #endregion

        #region Actionresult
        public ActionResult GetProducts6()
        { // ortak tür kullanır 
            if (true)
            {
                return Json(new Product { });
            }
            else if (true)
            {
                return Content("bir  metin dönder");
            }
       
            return View();
        }

        #endregion

         
    }
}
