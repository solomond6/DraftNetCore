using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataTables.AspNet.AspNetCore;
using DataTables.AspNet.Core;
using DriverOnboarding.Models;
using DriverOnboarding.Models.DBModels;
using DriverOnboarding.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DriverOnboarding.Controllers
{
    public class VerificationController : Controller
    {

        private gracelakemoovetestContext _context;

        public VerificationController(gracelakemoovetestContext context)
        {
            this._context = context;
        }

        // GET: Verification
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ScheduledVerification()
        {
            ViewBag.PageTitle = "Drivers Scheduled For Verification";
            return View();
        }

        public IActionResult DriversScheduledVerificationData(IDataTablesRequest request)
        {
            try
            {
                var driversList = _context.Applications.Where(x => x.Scheduled == 1).ToList();

                var filteredData = String.IsNullOrWhiteSpace(request.Search.Value) ? driversList : driversList.Where(_item => _item.Surname.Contains(request.Search.Value) || _item.FirstName.Contains(request.Search.Value) || _item.Drn.Contains(request.Search.Value));

                var dataPage = filteredData.Skip(request.Start).Take(request.Length);

                var data = dataPage.Select(emList => new
                {
                    id = emList.Drn,
                    fullname = emList.FirstName + " " + emList.Surname + " " + emList.MiddleName,
                    address = emList.Address,
                    uberId = emList.UberId,
                    driverLicense = emList.DriverLicenseNumber,
                    contactDetails = "Email: " + emList.Email + " Tel: " + emList.Mobile,
                    applicationStatus = emList.ApplicationStatus,
                    dateCreated = Convert.ToDateTime(emList.CreatedDateTime).ToString("dd MMM yyyy"),
                }).ToList();

                dynamic response = DataTablesResponse.Create(request, driversList.Count(), filteredData.Count(), data);

                return new DataTablesJsonResult(response, true);
            }
            catch (Exception ex)
            {
                LogWorker logWorker = new LogWorker("VerificationController", "DriversScheduledVerificationData", ex.Message.ToString());
                throw ex;
            }

            //return new DataTablesJsonResult(response, true);
        }


        public ActionResult VerificationPendingApproval()
        {
            ViewBag.PageTitle = "Verification Pending For Approval";
            return View();
        }


        public IActionResult PendingVerificationForApprovalData(IDataTablesRequest request)
        {
            try
            {
                //var driversList = _context.Applications.Where(x => x.Scheduled == 1).ToList();

                var driverVerificationresult = (from driver in _context.Applications
                                               join vresult in _context.Verificationresult on driver.Drn equals vresult.RefNo
                                               join vresulta in _context.Verificationresultsapproval on driver.Drn equals vresulta.Drn
                                               where vresulta.FirstApproval == 0 && vresulta.SecondApproval == 0
                                               //into g from d in g.DefaultIfEmpty()
                                               select new
                                               {
                                                   driver.Id,
                                                   driver.Drn,
                                                   driver.FirstName,
                                                   driver.Surname,
                                                   driver.MiddleName,
                                                   driver.Mobile,
                                                   driver.Address,
                                                   driver.Email,
                                                   driver.ApplicationStatus,
                                                   vresult.Note,
                                                   vresult.VerificationItem,
                                                   vresult.CreatedDateTime,
                                                   vresult.Gps,
                                                   vresulta.FirstApproval,
                                                   vresulta.SecondApproval
                                               }).ToList();

                var distinct = driverVerificationresult.GroupBy(x => x.Drn, (key, group) => group.First());

                var filteredData = String.IsNullOrWhiteSpace(request.Search.Value) ? distinct : distinct.Where(_item => _item.Surname.Contains(request.Search.Value) || _item.FirstName.Contains(request.Search.Value) || _item.Drn.Contains(request.Search.Value));

                var dataPage = filteredData.Skip(request.Start).Take(request.Length);

                var data = dataPage.Select(emList => new
                {
                    id = emList.Id,
                    drn = emList.Drn,
                    fullname = emList.FirstName + " " + emList.Surname + " " + emList.MiddleName,
                    address = emList.Address,
                    //driverLicense = emList.DriverLicenseNumber,
                    contactDetails = "Email: " + emList.Email + " Tel: " + emList.Mobile,
                    applicationStatus = emList.ApplicationStatus,
                    verificationItem = emList.VerificationItem,
                    dateCreated = Convert.ToDateTime(emList.CreatedDateTime).ToString("dd MMM yyyy"),
                }).ToList();

                dynamic response = DataTablesResponse.Create(request, driverVerificationresult.Count(), filteredData.Count(), data);

                return new DataTablesJsonResult(response, true);
            }
            catch (Exception ex)
            {
                LogWorker logWorker = new LogWorker("VerificationController", "PendingVerificationForApprovalData", ex.Message.ToString());
                throw ex;
            }

            //return new DataTablesJsonResult(response, true);
        }


        // GET: Verification/Details/5
        public ActionResult VerificationDetails(int id, string drn)
        {
            try
            {
                if (id == 0)
                {
                    TempData["ErrorMsg"] = "Invalid Driver ID";
                    return RedirectToAction("index", "Drivers");
                }

                //ulong driverId = Convert.ToUInt64(id);

                ViewBag.PageTitle = "Driver Verification Details";
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
                                     select new
                                     {
                                         Driver = d,
                                         Guarantor = g,
                                         DriverPassport = p,
                                         Driverdocuments = dd,
                                         Guarantordocuments = gd,
                                     }).ToList();

                var schedules = (from es in _context.Examinationschedules
                                 join e in _context.Examinations on Convert.ToUInt64(es.ExaminationId) equals e.Id
                                 where es.RefNo == drn
                                 //&& (es.Status == "Finished" || es.Status == "TimeElapsed")
                                 select new { es.RefNo, e.Subject, es.Score, es.PercentageScore, es.ModifiedDateTime }).ToList();

                var driverDocuments = (from dds in _context.Driverdocumenttypes
                                       join dd in _context.Driverdocuments
                                       on dds.DriverDocumentType equals dd.DocumentType
                                       where dd.Drn == drn
                                       select dd).ToList();

                var bankAccs = (from b in _context.Bankdetails
                                join dd in _context.Verifiedbankaccounts on b.AccountNumber equals dd.AccountNumber
                                where b.Drn == drn
                                select new BankDetailVerificationRes { sAccountName = b.AccountName, sAccountNumber = b.AccountNumber, dAccountName = dd.AccountName, dAccountNumber = dd.AccountNumber }).ToList();

                var bvnVerified = (from b in _context.Verifiedbvns
                                   join dd in _context.Applications on b.Bvn equals dd.Bvn
                                   where dd.Drn == drn
                                   select b).ToList();

                var subjects = _context.Verificationresultsapproval.Select(x => x.VerificationItem).ToList();

                var testOnboarding = (from e in _context.Examinationschedules
                                       join es in _context.Examinations
                                       on Convert.ToUInt64(e.ExaminationId) equals es.Id
                                       where e.RefNo == drn
                                       && es.Subject == "Driver Onboarding Test"
                                       //&& subjects.Contains(es.Subject)
                                       select new OnboardingTest  { VenueId = e.VenueId, StartDateTime= e.StartDateTime, Score = e.Score, PercentageScore = e.PercentageScore, ActualStartDateTime = e.ActualStartDateTime, Subject = es.Subject }).ToList();


                var vResults = (from vr in _context.Verificationresult.OrderByDescending(vr => vr.Id)
                                join vrimg in _context.Verificationresultimages on vr.Id equals Convert.ToUInt64(vrimg.VerificatioResultId)
                                where vr.RefNo == drn
                                select new AddressVerificationResult  { DispatchScheduleId = vr.DispatchScheduleId,
                                                                        Gps= vr.Gps,
                                                                        Note= vr.Note,
                                                                        Status= vr.Status,
                                                                        StatusReason= vr.StatusReason,
                                                                        VerificationItem = vr.VerificationItem,
                                                                        Id = vr.Id,
                                                                        ImageData = vrimg.ImageData,
                                                                        ImageType= vrimg.ImageType
                                                                     }).ToList();

                var testPhysical = (from es in _context.Examinationschedules
                                   join e in _context.Examinations
                                   on Convert.ToUInt64(es.ExaminationId) equals e.Id
                                   join q in _context.Examinationquestions
                                   on es.ExaminationId equals q.ExaminationId
                                   join tr in _context.Testresult.DefaultIfEmpty()
                                   on new { ScheduleID = es.Id, QuestionNumber = (long)q.QuestionNumber } equals new { ScheduleID = Convert.ToUInt64(tr.TestScheduleId), QuestionNumber = tr.TestQuestionId }
                                   where es.RefNo == drn && e.PhysicalTest == 1
                                   select new PhysicalTest  { QuestionHtml = q.QuestionHtml, Remark = tr.Remark, Result = tr.Result }).ToList();

                string latitude = "6.5244";
                string longitude = "3.3792";

                if (vResults.Count > 0)
                {
                    string addressGps = vResults[0].Gps;
                    var gpsSplit = addressGps.Split(',');
                    latitude = gpsSplit[0];
                    longitude = gpsSplit[1];
                }
                

                ViewBag.DriverDetails = driverDetails[0].Driver;
                ViewBag.DriverPassport = driverDetails[0].DriverPassport;
                ViewBag.Guarantor = driverDetails[0].Guarantor;
                ViewBag.Driverdocuments = driverDetails[0].Driverdocuments;
                ViewBag.Guarantordocuments = driverDetails[0].Guarantordocuments;

                ViewBag.VResult = vResults;
                ViewBag.TestResult = testOnboarding;
                ViewBag.TestPhysicalResult = testPhysical;
                ViewBag.BankAccount = bankAccs;
                ViewBag.BvnVerified = bvnVerified;
                ViewBag.Latitude = latitude;
                ViewBag.Longitude = longitude;

                return View();
            }
            catch (Exception ex)
            {
                LogWorker logWorker = new LogWorker("VerificationController", "VerificationDetails", ex.Message.ToString());
                TempData["ErrorMsg"] = "Record Not Found";
                return RedirectToAction("VerificationPendingApproval", "Verification");
            }
            
        }

        // GET: Verification/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Verification/Create
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

        // GET: Verification/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Verification/Edit/5
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

        // GET: Verification/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Verification/Delete/5
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