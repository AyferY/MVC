using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace MVCProject.Controllers
{
    public class CategoryController : Controller
    {



        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult GetCategoryList()
        {
            //var categoryvalues = cm.GetAllBL(); //Category listemi döndermek için önce Business Layer'daki
            //CategoryManager'ı çağırmam gerekiyor.(Yukarda)
            return View();   //view komutu göster demek. categoryvalues değişkeni içindeki değerleri dönder demektir.
        }

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();  //Burada sadece ekranın yüklenmesini beklediğimiz için return view dedik.

        }


        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            //cm.CategoryAddBL(p); 

            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult results = categoryValidator.Validate(p);

            if(results.IsValid)
            {
                cm.CategoryAdd(p);  //result doğrulandıysa ekleme işlemi gerçekleşir
                return RedirectToAction("GetCategoryList");  // bundan sonra redirect edecek
            }
            else
            {
                foreach(var item in results.Errors)  //results'dan gelen hataların içinde dön demektir.
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);  
                    //modelin durumuna hataları ekle.Bu hatalar da propertyname ve errormessage olsun demektir.
                }
            }
            return View();
            
        }
    }
}
