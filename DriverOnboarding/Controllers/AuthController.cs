using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DriverOnboarding.Models;
using DriverOnboarding.Models.DBModels;
using DriverOnboarding.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DriverOnboarding.Controllers
{
    public class AuthController : Controller
    {

        private gracelakemoovetestContext _context;

        public AuthController(gracelakemoovetestContext context)
        {
            this._context = context;
        }

        // GET: Auth
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(UserLogin userLogin)
        {
            try
            {
                var checkUserLogins = _context.AppUsers.Where(x => x.Username == userLogin.username).FirstOrDefault();
                //var checkUserLogins = _context.AppUsers.Where(x => x.Username == userLogin.username && x.Password == userLogin.password).FirstOrDefault();
                HttpContext.Session.SetString("StaffName", checkUserLogins.Name);

                if (checkUserLogins.Enabled == 1)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return RedirectToAction("UserList", "Admin");
                }

                TempData["ErrorMsg"] = "Incorrect Username/Password";

                return RedirectToAction("Index", "Auth");
            }
            catch(Exception ex)
            {
                TempData["ErrorMsg"] = "Incorrect Username/Password";
                LogWorker logWorker = new LogWorker("AuthController", "Login", ex.Message.ToString());
                return RedirectToAction("Index", "Auth");
            }
            
        }
        // GET: Auth/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Auth/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Auth/Create
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

        // GET: Auth/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Auth/Edit/5
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

        // GET: Auth/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Auth/Delete/5
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