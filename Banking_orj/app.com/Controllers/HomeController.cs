﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using app.com.Data;
using app.com.Models;

namespace app.com.Controllers
{
  public class HomeController : Controller
  {
    //private IDateMePleaseRepository _repository;
    //public HomeController(IDateMePleaseRepository repository)
    //{
    //  _repository = repository;
    //}

    public ActionResult Index()
    {
            //var randomProfiles = _repository.GetRandomProfiles(6);
            //ViewBag.Message = "Your application description page.";

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

    public ActionResult Acknowledgements()
    {
      return View();
    }
  }
}