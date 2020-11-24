using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataTables.AspNet.AspNetCore;
using DataTables.AspNet.Core;
using DriverOnboarding.Models.DBModels;
using DriverOnboarding.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DriverOnboarding.Controllers
{
    public class DriversController : Controller
    {
        private gracelakemoovetestContext _context;

        public DriversController(gracelakemoovetestContext context)
        {
            this._context = context;
        }

        public ActionResult Index()
        {
            ViewBag.PageTitle = "Drivers List";
            return View();
        }

        public IActionResult DriversData(IDataTablesRequest request)
        {
            try
            {
                var driversList = _context.Applications.ToList();

                var filteredData = String.IsNullOrWhiteSpace(request.Search.Value) ? driversList : driversList.Where(_item => _item.Surname.Contains(request.Search.Value) || _item.FirstName.Contains(request.Search.Value) || _item.Drn.Contains(request.Search.Value));

                var dataPage = filteredData.Skip(request.Start).Take(request.Length);

                var data = dataPage.Select(emList => new
                {
                    id = emList.Id,
                    drn = emList.Drn,
                    fullname = emList.FirstName + " " + emList.Surname + " " + emList.MiddleName,
                    address = emList.Address,
                    uberId = emList.UberId,
                    driverLicense = emList.DriverLicenseNumber,
                    contactDetails = "Email: "+emList.Email +" Tel: "+ emList.Mobile,
                    applicationStatus = emList.ApplicationStatus,
                    dateCreated = Convert.ToDateTime(emList.CreatedDateTime).ToString("dd MMM yyyy"),
                }).ToList();

                dynamic response = DataTablesResponse.Create(request, driversList.Count(), filteredData.Count(), data);

                return new DataTablesJsonResult(response, true);
            }
            catch (Exception ex)
            {
                LogWorker logWorker = new LogWorker("DriversController", "DriversData", ex.Message.ToString());
                throw ex;
            }

            //return new DataTablesJsonResult(response, true);
        }
        // GET: Drivers/Details/5

        [HttpGet]
        public ActionResult Details(int id, string drn)
        {
            try
            {
                if (id == 0)
                {
                    TempData["ErrorMsg"] = "Invalid Driver ID";
                    return RedirectToAction("index", "Drivers");
                }

                //ulong driverId = Convert.ToUInt64(id);

                ViewBag.PageTitle = "Driver Details";
                ViewBag.DriverID = id;

                var driverDetails = (from d in _context.Applications
                                     join g in _context.Guarantordetails on d.Drn equals g.Drn into dg
                                     from g in dg.DefaultIfEmpty()
                                     join p in _context.Applicationpassports on d.Drn equals p.RefNo into dp
                                     from p in dp.DefaultIfEmpty()
                                     join dd in _context.Driverdocuments on d.Drn equals dd.Drn into ddd
                                     from dd in ddd.DefaultIfEmpty()
                                     join gd in _context.Guarantordocuments on d.Drn equals gd.Drn into dgd
                                     from gd in ddd.DefaultIfEmpty()
                                     where d.Drn == drn
                                    select new { Driver = d,
                                                 Guarantor = g,
                                                 DriverPassport = p,
                                                 Driverdocuments = dd,
                                                 Guarantordocuments = gd,
                                    }).ToList();

                ViewBag.DriverDetails = driverDetails[0].Driver;
                ViewBag.DriverPassport = driverDetails[0].DriverPassport;
                ViewBag.Guarantor = driverDetails[0].Guarantor;
                ViewBag.Driverdocuments = driverDetails[0].Driverdocuments;
                ViewBag.Guarantordocuments = driverDetails[0].Guarantordocuments;
                //ViewBag.GuarantorDetails = driverResult.guarantorDetails;
                //ViewBag.leaseId = leaseDetails[0].id;

                return View();

            }
            catch (Exception ex)
            {
                LogWorker logWorker = new LogWorker("DriversController", "Details", ex.Message.ToString());
                return View();
            }
            //return View();
        }

        // GET: Drivers/Create
        public ActionResult Create()
        {
            ViewBag.PageTitle = "New Driver";
            var driversDoc = _context.Driverdocumenttypes.ToList();
            var guarantorDoc = _context.Guarantordocumenttypes.ToList();

            ViewBag.Driverdocuments = driversDoc;
            ViewBag.Guarantordocuments = guarantorDoc;
            return View();
        }

        // POST: Drivers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Drivers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Drivers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Drivers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Drivers/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}