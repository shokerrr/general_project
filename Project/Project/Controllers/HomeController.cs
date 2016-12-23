using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.Interfaces;
using BLL.DTO;
using BLL.Infrastructure;
using BLL.Services;
using Domain;
using Project.Models;
using Repository;

//using Repository;

//using UoWMvcApp.Models;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        IOrderService orderService;
        public HomeController(IOrderService serv)
        {
            orderService = serv;
        }
        public ActionResult Index()
        {
            //var Advertisment = unitOfWork.Advertisment.GetAll();
            //IEnumerable<AdvertismentDTO> advertismentDto = AdvertismentService.GetAdvertisment();
            //Mapper.Initialize(cfg => cfg.CreateMap<AdvertismentDTO, AdvertismentViewModel>());
            //var Advertisment = Mapper.Map<IEnumerable<Advertisment>, List<AdvertismentViewModel>>(advertismentDto);
            //return System.Web.UI.WebControls.View(Advertisment);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        UnitOfWork unitOfWork;

        public HomeController()
        {
            unitOfWork = new UnitOfWork();
        }


        //protected override void Dispose(bool disposing)
        //{
        //    //unitOfWork.Dispose();
        //    base.Dispose(disposing);
        //}

        //public ActionResult Index()
        //{
        //    var advertisment = unitOfWork.Advertisment.GetAll();
        //    return View();
        //}

        //public ActionResult Create()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Create(Advertisment a)
        //{
        //    if(ModelState.IsValid)
        //    {
        //        unitOfWork.Advertisment.Create(a);
        //        unitOfWork.Save();
        //        return RedirectToAction("Index");
        //    }
        //    return View(b);
        //}

        //public ActionResult Edit(int id)
        //{
        //    Advertisment a = unitOfWork.Advertisment.Get(id);
        //    if (a == null)
        //        return HttpNotFound();
        //    return View(a);
        //}

        //[HttpPost]
        //public ActionResult Edit(Advertisment a)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        unitOfWork.Advertisment.Update(a);
        //        unitOfWork.Save();
        //        return RedirectToAction("Index");
        //    }
        //    return View(a);
        //}

        //public ActionResult Delete(int id)
        //{
        //    unitOfWork.Advertisment.Delete(id);
        //    unitOfWork.Save();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    unitOfWork.Dispose();
        //    base.Dispose(disposing);
        //}
    
    }
}