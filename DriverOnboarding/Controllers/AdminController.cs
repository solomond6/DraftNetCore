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
using Microsoft.Extensions.Configuration;

namespace DriverOnboarding.Controllers
{
    public class AdminController : Controller
    {
        IConfiguration _iconfiguration;
        private gracelakemoovetestContext _context;

        public AdminController(IConfiguration iconfiguration, gracelakemoovetestContext context)
        {
            _iconfiguration = iconfiguration;
            this._context = context;
        }

        public ActionResult Countries()
        {
            ViewBag.PageTitle = "List of Countries";
            return View();
        }


        public IActionResult GetCountries(IDataTablesRequest request)
        {
            try
            {
                var countries = (from c in _context.Countries
                                                select new
                                                {
                                                    c.Id,
                                                    c.Name,
                                                }).ToList();

                var filteredData = String.IsNullOrWhiteSpace(request.Search.Value) ? countries : countries.Where(_item => _item.Name.Contains(request.Search.Value));

                var dataPage = filteredData.Skip(request.Start).Take(request.Length);

                var data = dataPage.Select(emList => new
                {
                    id = emList.Id,
                    countryName = emList.Name,
                }).ToList();

                dynamic response = DataTablesResponse.Create(request, countries.Count(), filteredData.Count(), data);

                return new DataTablesJsonResult(response, true);
            }
            catch (Exception ex)
            {
                LogWorker logWorker = new LogWorker("AdminController", "GetCountries", ex.Message.ToString());
                throw ex;
            }
        }


        public ActionResult States()
        {
            ViewBag.PageTitle = "List of States";
            return View();
        }


        public IActionResult GetStates(IDataTablesRequest request)
        {
            try
            {
                var states = (from c in _context.States
                                 select new
                                 {
                                     c.Id,
                                     c.Name,
                                 }).ToList();

                var filteredData = String.IsNullOrWhiteSpace(request.Search.Value) ? states : states.Where(_item => _item.Name.Contains(request.Search.Value));

                var dataPage = filteredData.Skip(request.Start).Take(request.Length);

                var data = dataPage.Select(emList => new
                {
                    id = emList.Id,
                    stateName = emList.Name,
                }).ToList();

                dynamic response = DataTablesResponse.Create(request, states.Count(), filteredData.Count(), data);

                return new DataTablesJsonResult(response, true);
            }
            catch (Exception ex)
            {
                LogWorker logWorker = new LogWorker("AdminController", "GetStates", ex.Message.ToString());
                throw ex;
            }
        }

        public ActionResult LGAS()
        {
            ViewBag.PageTitle = "List of Local Govt. Areas";
            return View();
        }


        public IActionResult GetLGAS(IDataTablesRequest request)
        {
            try
            {
                var localgovernments = (from c in _context.Localgovernments
                                          select new
                                          {
                                              c.Id,
                                              c.Name,
                                          }).ToList();

                var filteredData = String.IsNullOrWhiteSpace(request.Search.Value) ? localgovernments : localgovernments.Where(_item => _item.Name.Contains(request.Search.Value));

                var dataPage = filteredData.Skip(request.Start).Take(request.Length);

                var data = dataPage.Select(emList => new
                {
                    id = emList.Id,
                    lgaName = emList.Name,
                }).ToList();

                dynamic response = DataTablesResponse.Create(request, localgovernments.Count(), filteredData.Count(), data);

                return new DataTablesJsonResult(response, true);
            }
            catch (Exception ex)
            {
                LogWorker logWorker = new LogWorker("AdminController", "GetLGAS", ex.Message.ToString());
                throw ex;
            }
        }



        
        public ActionResult DispatchSetup()
        {
            ViewBag.PageTitle = "Dispatch Setup";
            return View();
        }


        public IActionResult GetDispatchSetup(IDataTablesRequest request)
        {
            try
            {
                var dispatchSetups = (from c in _context.Dispatchscheduleparameters
                                        select new
                                        {
                                            c.Id,
                                            c.DispatchScheduleMode,
                                            c.MaxSchedulePerDispatch,
                                        }).ToList();

                var filteredData = String.IsNullOrWhiteSpace(request.Search.Value) ? dispatchSetups : dispatchSetups.Where(_item => _item.DispatchScheduleMode.Contains(request.Search.Value));

                var dataPage = filteredData.Skip(request.Start).Take(request.Length);

                var data = dataPage.Select(emList => new
                {
                    id = emList.Id,
                    scheduleMode = emList.DispatchScheduleMode,
                    maxDispacth = emList.MaxSchedulePerDispatch,
                }).ToList();

                dynamic response = DataTablesResponse.Create(request, dispatchSetups.Count(), filteredData.Count(), data);

                return new DataTablesJsonResult(response, true);
            }
            catch (Exception ex)
            {
                LogWorker logWorker = new LogWorker("AdminController", "GetDispatchSetup", ex.Message.ToString());
                throw ex;
            }
        }


        public ActionResult UpdateDispatchSetup(DispatchSetup dispatchSetup)
        {
            try
            {
                ulong _id = Convert.ToUInt64(dispatchSetup.id);

                var dispatchParam = _context.Dispatchscheduleparameters
                                        .Where(s => s.Id == _id)
                                        .SingleOrDefault();

                dispatchParam.DispatchScheduleMode = dispatchSetup.schedulemode;
                dispatchParam.MaxSchedulePerDispatch = dispatchSetup.maxdispacth;
                dispatchParam.ModifiedDateTime = DateTime.Now;
                dispatchParam.ModifiedBy = HttpContext.Session.GetString("StaffName");
                _context.SaveChanges();

                TempData["SuccessMsg"] = "Dispatch Setup modified successfully";
                return RedirectToAction("DispatchSetup", "Admin");
            }
            catch (Exception ex)
            {
                LogWorker logWorker = new LogWorker("AdminController", "UpdateDispatchSetup", ex.Message.ToString());
                TempData["ErrorMsg"] = "Error Occured modifying dispatch setup";
                return RedirectToAction("DispatchSetup", "Admin");
            }
        }
        public ActionResult AppUsers()
        {
            ViewBag.PageTitle = "App Users List";
            return View();
        }

        public IActionResult GetAppUsers(IDataTablesRequest request)
        {
            try
            {
                var appUsers = (from c in _context.AppUsers
                                select new
                                {
                                    c.Id,
                                    c.Name,
                                    c.Supervisor,
                                    c.Enabled,
                                }).ToList();

                var filteredData = String.IsNullOrWhiteSpace(request.Search.Value) ? appUsers : appUsers.Where(_item => _item.Name.Contains(request.Search.Value));

                var dataPage = filteredData.Skip(request.Start).Take(request.Length);

                var data = dataPage.Select(emList => new
                {
                    id = emList.Id,
                    fullanme = emList.Name,
                    supervisor = emList.Supervisor,
                    enabled = emList.Enabled
                }).ToList();

                dynamic response = DataTablesResponse.Create(request, appUsers.Count(), filteredData.Count(), data);

                return new DataTablesJsonResult(response, true);
            }
            catch (Exception ex)
            {
                LogWorker logWorker = new LogWorker("AdminController", "GetAppUsers", ex.Message.ToString());
                throw ex;
            }
        }


        public ActionResult UpdateUserStatus(int id, sbyte statusId)
        {
            try
            {
                ulong _id = Convert.ToUInt64(id);

                var userStat = _context.AppUsers
                                        .Where(s => s.Id == _id)
                                        .SingleOrDefault();

                userStat.Enabled = statusId;
                userStat.ModifiedDateTime = DateTime.Now;
                userStat.ModifiedBy = HttpContext.Session.GetString("StaffName");
                _context.SaveChanges();

                return Json(new { status = "00" });
            }
            catch (Exception ex)
            {
                LogWorker logWorker = new LogWorker("AdminController", "UpdateUserStatus", ex.Message.ToString());
                return Json(new { status = "01" });
            }
        }


        public ActionResult CreateUser(Users _users)
        {
            try
            {
                var userAccount = new AppUsers()
                {
                    Name = _users.username,
                    Username = _users.username,
                    Supervisor = _users.supervisor,
                    Enabled = 1,
                    Deleted = 0,
                    Password = "default",
                    Company = "Moove",
                    DefaultCompany = "",
                    PreviousCompany = "",
                    CreatedBy = HttpContext.Session.GetString("StaffName"),
                    ModifiedBy = HttpContext.Session.GetString("StaffName"),
                    CreatedDateTime = DateTime.Now,
                    ModifiedDateTime = DateTime.Now,
                };

                _context.AppUsers.Add(userAccount);
                _context.SaveChanges();

                TempData["SuccessMsg"] = "User created successfully";
                return RedirectToAction("AppUsers", "Admin");
            }
            catch (Exception ex)
            {
                LogWorker logWorker = new LogWorker("AdminController", "UpdateUserStatus", ex.Message.ToString());
                TempData["ErrorMsg"] = "Error Occured creating user";
                return RedirectToAction("AppUsers", "Admin");
            }
        }

        public ActionResult DriverApprovalSetup()
        {
            ViewBag.PageTitle = "Setting for Driver's Approval";
            return View();
        }

        public IActionResult GetDriverApprovalSetup(IDataTablesRequest request)
        {
            try
            {
                var driverApprovalSetups = (from c in _context.Driverparameter
                                      select new
                                      {
                                          c.Id,
                                          c.Driverscheme,
                                          c.GuarantorOptionalForVerfication,
                                          c.GuarantorOptionalForApprovalSubmission,
                                      }).ToList();

                var filteredData = String.IsNullOrWhiteSpace(request.Search.Value) ? driverApprovalSetups : driverApprovalSetups.Where(_item => _item.Driverscheme.Contains(request.Search.Value));

                var dataPage = filteredData.Skip(request.Start).Take(request.Length);

                var data = dataPage.Select(emList => new
                {
                    id = emList.Id,
                    driverscheme = emList.Driverscheme,
                    guarantorOptionalForVerfication = emList.GuarantorOptionalForVerfication,
                    guarantorOptionalForApprovalSubmission = emList.GuarantorOptionalForApprovalSubmission,
                }).ToList();

                dynamic response = DataTablesResponse.Create(request, driverApprovalSetups.Count(), filteredData.Count(), data);

                return new DataTablesJsonResult(response, true);
            }
            catch (Exception ex)
            {
                LogWorker logWorker = new LogWorker("AdminController", "GetDriverApprovalSetup", ex.Message.ToString());
                throw ex;
            }
        }


        public ActionResult UpdateDriverApprovalSetup(DriverParameters driverParameters)
        {
            try
            {
                ulong _id = Convert.ToUInt64(driverParameters.id);

                var driverParams = _context.Driverparameter
                                        .Where(s => s.Id == _id)
                                        .SingleOrDefault();

                driverParams.Driverscheme = driverParameters.driverscheme;
                driverParams.GuarantorOptionalForVerfication = driverParameters.guarantorOptionalForVerfication;
                driverParams.GuarantorOptionalForApprovalSubmission = driverParameters.guarantorOptionalForApprovalSubmission;
                driverParams.ModifiedDateTime = DateTime.Now;
                driverParams.ModifiedBy = HttpContext.Session.GetString("StaffName");
                _context.SaveChanges();

                TempData["SuccessMsg"] = "Setup modified successfully";
                return RedirectToAction("DriverApprovalSetup", "Admin");
            }
            catch (Exception ex)
            {
                LogWorker logWorker = new LogWorker("AdminController", "UpdateUserStatus", ex.Message.ToString());
                TempData["ErrorMsg"] = "Error Occured modifying setup";
                return RedirectToAction("DriverApprovalSetup", "Admin");
            }
        }


        public ActionResult DriverDocumentSetup()
        {
            ViewBag.PageTitle = "List of Docuemnts Needed From Driver";
            return View();
        }

        
        public IActionResult GetDriverDocumentSetup(IDataTablesRequest request)
        {
            try
            {
                var driverDocs = (from c in _context.Driverdocumenttypes
                                            select new
                                            {
                                                c.Id,
                                                c.Name,
                                                c.DriverDocumentType,
                                                c.DocumentStatus,
                                            }).ToList();

                var filteredData = String.IsNullOrWhiteSpace(request.Search.Value) ? driverDocs : driverDocs.Where(_item => _item.DriverDocumentType.Contains(request.Search.Value));

                var dataPage = filteredData.Skip(request.Start).Take(request.Length);

                var data = dataPage.Select(emList => new
                {
                    id = emList.Id,
                    docName = emList.Name,
                    docType = emList.DriverDocumentType,
                    docStatus = emList.DocumentStatus,
                }).ToList();

                dynamic response = DataTablesResponse.Create(request, driverDocs.Count(), filteredData.Count(), data);

                return new DataTablesJsonResult(response, true);
            }
            catch (Exception ex)
            {
                LogWorker logWorker = new LogWorker("AdminController", "GetDriverApprovalSetup", ex.Message.ToString());
                throw ex;
            }
        }



        public ActionResult UpdateDriverDocumentSetup(DriverDocumentSetup driverDocumentsetup)
        {
            try
            {
                ulong _id = Convert.ToUInt64(driverDocumentsetup.id);

                var driverDocs = _context.Driverdocumenttypes
                                        .Where(s => s.Id == _id)
                                        .SingleOrDefault();

                driverDocs.Name = driverDocumentsetup.docName;
                driverDocs.DriverDocumentType = driverDocumentsetup.docType;
                driverDocs.DocumentStatus = driverDocumentsetup.docStatus;
                driverDocs.ModifiedDateTime = DateTime.Now;
                driverDocs.ModifiedBy = HttpContext.Session.GetString("StaffName");
                _context.SaveChanges();

                TempData["SuccessMsg"] = "Driver Document modified successfully";
                return RedirectToAction("DriverDocumentSetup", "Admin");
            }
            catch (Exception ex)
            {
                LogWorker logWorker = new LogWorker("AdminController", "UpdateDriverDocumentSetup", ex.Message.ToString());
                TempData["ErrorMsg"] = "Error Occured modifying driver's document";
                return RedirectToAction("DriverDocumentSetup", "Admin");
            }
        }


        public ActionResult CreateDriverDocument(DriverDocumentSetup driverDocumentsetup)
        {
            try
            {
                var driverDoc = new Driverdocumenttypes()
                {
                    Name = driverDocumentsetup.docName,
                    DriverDocumentType = driverDocumentsetup.docType,
                    DocumentStatus = driverDocumentsetup.docStatus,
                    Deleted = 0,
                    CreatedBy = HttpContext.Session.GetString("StaffName"),
                    ModifiedBy = HttpContext.Session.GetString("StaffName"),
                    CreatedDateTime = DateTime.Now,
                    ModifiedDateTime = DateTime.Now,
                };

                _context.Driverdocumenttypes.Add(driverDoc);
                _context.SaveChanges();

                TempData["SuccessMsg"] = "Document created successfully";
                return RedirectToAction("DriverDocumentSetup", "Admin");
            }
            catch (Exception ex)
            {
                LogWorker logWorker = new LogWorker("AdminController", "CreateDriverDocument", ex.Message.ToString());
                TempData["ErrorMsg"] = "Error Occured creating document";
                return RedirectToAction("DriverDocumentSetup", "Admin");
            }
        }


        public ActionResult GuarantorDocumentSetup()
        {
            ViewBag.PageTitle = "List of Docuemnts Needed From Guarantor";
            return View();
        }



        public IActionResult GetGuarantorDocumentSetup(IDataTablesRequest request)
        {
            try
            {
                var guarantorDocs = (from c in _context.Guarantordocumenttypes
                                    select new
                                    {
                                        c.Id,
                                        c.Name,
                                        c.GuarantorDocumentType,
                                        c.IsPassport,
                                    }).ToList();

                var filteredData = String.IsNullOrWhiteSpace(request.Search.Value) ? guarantorDocs : guarantorDocs.Where(_item => _item.Name.Contains(request.Search.Value));

                var dataPage = filteredData.Skip(request.Start).Take(request.Length);

                var data = dataPage.Select(emList => new
                {
                    id = emList.Id,
                    docName = emList.Name,
                    guarantorDocumentType = emList.GuarantorDocumentType,
                    isPassport = emList.IsPassport,
                }).ToList();

                dynamic response = DataTablesResponse.Create(request, guarantorDocs.Count(), filteredData.Count(), data);

                return new DataTablesJsonResult(response, true);
            }
            catch (Exception ex)
            {
                LogWorker logWorker = new LogWorker("AdminController", "GetDriverApprovalSetup", ex.Message.ToString());
                throw ex;
            }
        }


        public ActionResult UpdateGuarantorDocumentSetup(DriverDocumentSetup guarantorDocumentsetup)
        {
            try
            {
                ulong _id = Convert.ToUInt64(guarantorDocumentsetup.id);

                var driverDocs = _context.Guarantordocumenttypes
                                        .Where(s => s.Id == _id)
                                        .SingleOrDefault();

                driverDocs.Name = guarantorDocumentsetup.docName;
                driverDocs.GuarantorDocumentType = guarantorDocumentsetup.docType;
                driverDocs.DocumentStatus = guarantorDocumentsetup.docStatus;
                driverDocs.ModifiedDateTime = DateTime.Now;
                driverDocs.ModifiedBy = HttpContext.Session.GetString("StaffName");
                _context.SaveChanges();

                TempData["SuccessMsg"] = "Guarantor Document modified successfully";
                return RedirectToAction("GuarantorDocumentSetup", "Admin");
            }
            catch (Exception ex)
            {
                LogWorker logWorker = new LogWorker("AdminController", "UpdateDriverDocumentSetup", ex.Message.ToString());
                TempData["ErrorMsg"] = "Error Occured modifying guarantor's document";
                return RedirectToAction("GuarantorDocumentSetup", "Admin");
            }
        }


        public ActionResult CreateGuarantorDocument(DriverDocumentSetup guarantorDocumentsetup)
        {
            try
            {
                var guarantorDoc = new Guarantordocumenttypes()
                {
                    Name = guarantorDocumentsetup.docName,
                    GuarantorDocumentType = guarantorDocumentsetup.docType,
                    DocumentStatus = guarantorDocumentsetup.docStatus,
                    Deleted = 0,
                    CreatedBy = HttpContext.Session.GetString("StaffName"),
                    ModifiedBy = HttpContext.Session.GetString("StaffName"),
                    CreatedDateTime = DateTime.Now,
                    ModifiedDateTime = DateTime.Now,
                };

                _context.Guarantordocumenttypes.Add(guarantorDoc);
                _context.SaveChanges();

                TempData["SuccessMsg"] = "Document created successfully";
                return RedirectToAction("GuarantorDocumentSetup", "Admin");
            }
            catch (Exception ex)
            {
                LogWorker logWorker = new LogWorker("AdminController", "CreateGuarantorDocument", ex.Message.ToString());
                TempData["ErrorMsg"] = "Error Occured creating document";
                return RedirectToAction("GuarantorDocumentSetup", "Admin");
            }
        }



        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Details));
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Details));
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Details));
            }
            catch
            {
                return View();
            }
        }
    }
}