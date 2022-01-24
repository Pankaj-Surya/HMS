using HMS.Areas.Dashboard.ViewModels;
using HMS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HMS.Areas.Dashboard.Controllers
{
    public class AccomodationTypesController : Controller
    {

        AccomodationTypesService accomodationTypesService = new AccomodationTypesService();


        // GET: Dashboard/AccomodationTypes
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listing()
        {
            AccomodationTypesListingModel model = new AccomodationTypesListingModel();

             model.AccomodationTypes= accomodationTypesService.GetAllAccomodationTypes();

            return PartialView("_Listing",model);
            
        }

        //Create & Edit both done by single action Method
        public ActionResult Action()
        {
            AccomodationTypeActionModel model = new AccomodationTypeActionModel();

            return PartialView("_Action1", model);
        }


        //public ActionResult Action1()
        //{
        //    AccomodationTypeActionModel model = new AccomodationTypeActionModel();

        //    return View();
        //}

    }
}

