using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Products_N_Categories.Models;

namespace Products_N_Categories.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;

        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            List<Product> AllProducts = dbContext.Product.ToList();
            ViewBag.AllProducts = AllProducts;
            NewProductCategoryModel viewmodel = new NewProductCategoryModel();
            viewmodel.Productss = AllProducts;
            return View(viewmodel);
        }

        [HttpPost("/")]
        public IActionResult AddProduct(Product NewProduct)
        {
            List<Product> AllProducts = dbContext.Product.ToList();
            ViewBag.AllProducts = AllProducts;
            if (ModelState.IsValid)
            {
                dbContext.Product.Add(NewProduct);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet("{ProductId}")]
        public IActionResult ShowProduct(int ProductId)
        {
            Product retrivedProduct = dbContext.Product.Include(p => p.AssociationCategory).ThenInclude(Category => Category.Category).FirstOrDefault(Product => Product.ProductId == ProductId);
            ViewBag.oneProduct = retrivedProduct;


            List<Category> noCategories = dbContext.Category.Include(p => p.Associations).ThenInclude(a => a.Product).ToList();

            List<Category> _currentCategories = new List<Category>();
            foreach (var one in noCategories)
            {
                if (!one.Associations.Any(c => c.Product == retrivedProduct))
                {
                    _currentCategories.Add(one);
                }
            }
            ViewBag.currentCategories = _currentCategories;

            NewProductCategoryModel newView = new NewProductCategoryModel();
            newView.newProduct = retrivedProduct;

            return View(newView);
        }
        [HttpPost("addCategoryToProduct/{ProductId}")]
        public IActionResult addCategoryToProduct(int ProductId, Association data)
        {
            data.ProductId = ProductId;
            dbContext.Add(data);
            dbContext.SaveChanges();

            return RedirectToAction("ShowProduct", new { ProductId = ProductId });
        }

        [HttpGet("catog/{CategoryId}")]
        public IActionResult ShowCategory(int CategoryId)
        {
            Category retrivedProduct = dbContext.Category.Include(p => p.Associations).ThenInclude(Product => Product.Product).FirstOrDefault(Category => Category.CategoryId == CategoryId);
            ViewBag.oneCategory = retrivedProduct;


            List<Product> noProduct = dbContext.Product.Include(p => p.AssociationCategory).ThenInclude(a => a.Category).ToList();

            List<Product> _currentProduct = new List<Product>();
            foreach (var one in noProduct)
            {
                if (!one.AssociationCategory.Any(c => c.Category == retrivedProduct))
                {
                    _currentProduct.Add(one);
                }
            }
            ViewBag.currentProduct = _currentProduct;

            // NewProductCategoryModel newView = new NewProductCategoryModel();
            // newView.newProduct = retrivedProduct;

            return View("ShowCategory");
        }
        [HttpPost("addProducttocatg/{CategoryId}")]
        public IActionResult addProducttocatg(int CategoryId, Association data)
        {
            data.CategoryId = CategoryId;
            dbContext.Add(data);
            dbContext.SaveChanges();

            return RedirectToAction("ShowCategory", new { CategoryId = CategoryId });
        }

        // [HttpGet("{ProductId}")]
        // public IActionResult ShowProduct(int ProductId, int CategoryId)
        // {
        //     Product retrivedProduct = dbContext.Product.Include(p => p.AssociationCategory).ThenInclude(Category => Category.Category).FirstOrDefault(Product => Product.ProductId == ProductId);
        //     // Product retrivedProduct = dbContext.Product.FirstOrDefault(d => d.ProductId == ProductId);
        //     // List<Category> Allcategories = dbContext.Category.ToList ();

        //     List<Category> currentCategories = dbContext.Category.Include(p => p.Associations).ThenInclude(a => a.product).ToList();

        //     List<Category> _currentCategories = new List<Category>();
        //     foreach (var one in _currentCategories)
        //     {
        //         if (!one.Associations.Any(c => c.product == retrivedProduct))
        //         {
        //             currentCategories.Add(one);
        //         }
        //     }

        //     // List<Category> Allcategories = dbContext.Category.Include(p => p.Associations).ThenInclude(a => a.product).Where(e => e.CategoryId != CategoryId).ToList();
        //     // ViewBag.Allcategories = Allcategories;
        //     NewProductCategoryModel newView = new NewProductCategoryModel();
        //     newView.newProduct = retrivedProduct;
        //     // newView.Category = Allcategories;
        //     ViewBag.currentCategories = currentCategories;
        //     return View(newView);
        // }

        // [HttpPost("{ProductId}")]
        // public IActionResult AddCategoryToProduct(int ProductId, NewProductCategoryModel AddCategory)
        // {

        //     Association newAssociation = new Association
        //     {
        //         ProductId = ProductId,
        //         CategoryId = addCategory
        //     };
        //     if (ModelState.IsValid)
        //     {
        //         dbContext.Association.Add(newAssociation);
        //         dbContext.SaveChanges();
        //         return RedirectToAction("ShowProduct");
        //     }
        //     else
        //     {
        //         return View("ShowProduct");
        //     }
        // }

        [HttpGet("Category")]
        public IActionResult Category()
        {
            List<Category> Allcategories = dbContext.Category.ToList();
            ViewBag.Allcategories = Allcategories;
            return View();
        }

        [HttpPost("Category")]
        public IActionResult AddCategory(Category NewCategory)
        {
            List<Category> Allcategories = dbContext.Category.ToList();
            ViewBag.Allcategories = Allcategories;
            if (ModelState.IsValid)
            {
                dbContext.Category.Add(NewCategory);
                dbContext.SaveChanges();
                return RedirectToAction("Category");
            }
            else
            {
                return View("Category");
            }
        }

        [HttpGet("Success")]
        public IActionResult Privacy()
        {
            int? logUser = HttpContext.Session.GetInt32("id");
            if (logUser == null)
            {
                return RedirectToAction("Index");
            }
            Product CurrLog = dbContext.Product.FirstOrDefault(user => user.ProductId == logUser);
            // ViewBag.logFirst = CurrLog.FirstName;
            // ViewBag.logLast = CurrLog.LastName;
            ViewBag.logUser = logUser;

            return View("Privacy");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}