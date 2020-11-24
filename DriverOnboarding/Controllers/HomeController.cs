using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DriverOnboarding.Models;
using MySqlConnector;
using DriverOnboarding.Models.DBModels;
using DriverOnboarding.Utility;

namespace DriverOnboarding.Controllers
{
    public class HomeController : Controller
    {

        private gracelakemoovetestContext _context;

        public HomeController(gracelakemoovetestContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            ViewBag.PageTitle = "Dashboard";

            var applicationStatusCount = _context.Applications.GroupBy(info => info.ApplicationStatus)
                                               .Select(group => new ItemCounts
                                               {
                                                   StatusKey = group.Key,
                                                   StatusCount = group.Count()
                                               }).ToList();

            ViewBag.DriverStatus = applicationStatusCount;
            return View();
        }

        public JsonResult GetDriversData()
        {
            try
            {
                var driversStatusCount = _context.Applications.GroupBy(info => info.ApplicationStatus)
                                                .Select(group => new ItemCounts
                                                {
                                                    StatusKey = group.Key,
                                                    StatusCount = group.Count()
                                                }).ToList();


                var driverVerificationCount = _context.Verificationresultsapproval.GroupBy(info => info.VerificationItem)
                                                .Select(group => new ItemCounts
                                                {
                                                    StatusKey = group.Key,
                                                    StatusCount = group.Count()
                                                }).ToList();

                return Json(new { driverStatus = driversStatusCount, verificationCount = driverVerificationCount });
            }
            catch (Exception ex)
            {
                LogWorker logWorker = new LogWorker("HomeController", "GetProjectData", ex.Message.ToString());
                return Json(new { data = "Error has occured" });
            }

        }
    }
}
