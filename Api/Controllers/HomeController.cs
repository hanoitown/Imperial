using Imperial.Data.Entities;
using Imperial.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Api.Controllers
{
    public class HomeController : Controller
    {
        ITaxService _taxService;
        IUnitOfWork _uow;
        public HomeController(ITaxService taxService, IUnitOfWork uow)
        {
            _taxService = taxService;
            _uow = uow;
        }

        public ActionResult Index()
        {
            var rate = _taxService.GetTaxRate();
            _uow.Products.Add(Product.New("hello", "world", "SKU"));
            _uow.Save();
            ViewBag.Title = rate.ToString();

            return View();
        }
    }

    public class TaxService : ITaxService
    {
        public double GetTaxRate()
        {
            return 0.7;
        }
    }

    public interface ITaxService
    {
        double GetTaxRate();
    }

}

