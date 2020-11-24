using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DriverOnboarding.Models.DBModels;
using DriverOnboarding.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace DriverOnboarding.Controllers
{
    public class UtilitiesController : Controller
    {

        IConfiguration _iconfiguration;
        private gracelakemoovetestContext _context;

        public UtilitiesController(IConfiguration iconfiguration, gracelakemoovetestContext context)
        {
            _iconfiguration = iconfiguration;
            this._context = context;
        }


        public JsonResult GetBanks()
        {
            try
            {
                var bankList = _context.Bank.Select(st => new {
                    id = st.Id,
                    name = st.Name
                }).ToList();
                return Json(new { data = bankList });
            }
            catch (Exception ex)
            {
                //LogError logerror = new LogError();
                LogWorker logWorker = new LogWorker("UtilitiesController", "GetBanks", ex.Message.ToString());
                return Json(new { data = "Error has occured" });
            }
        }

        public JsonResult GetCountries()
        {
            try
            {
                var countryList = _context.Countries.Select(st => new {
                    id = st.Id,
                    name = st.Name
                }).ToList();
                return Json(new { data = countryList });
            }
            catch (Exception ex)
            {
                //LogError logerror = new LogError();
                LogWorker logWorker = new LogWorker("UtilitiesController", "GetCountries", ex.Message.ToString());
                return Json(new { data = "Error has occured" });
            }

        }


        public JsonResult GetStates()
        {
            try
            {
                var stateList = _context.States.Select(st => new {
                    id = st.Id,
                    name = st.Name
                }).ToList();
                return Json(new { data = stateList });
            }
            catch (Exception ex)
            {
                //LogError logerror = new LogError();
                LogWorker logWorker = new LogWorker("UtilitiesController", "GetStates", ex.Message.ToString());
                return Json(new { data = "Error has occured" });
            }
        }


        public JsonResult GetUsers()
        {
            try
            {
                var stateList = _context.AppUsers.Select(st => new {
                    id = st.Id,
                    name = st.Name
                }).ToList();
                return Json(new { data = stateList });
            }
            catch (Exception ex)
            {
                //LogError logerror = new LogError();
                LogWorker logWorker = new LogWorker("UtilitiesController", "GetStates", ex.Message.ToString());
                return Json(new { data = "Error has occured" });
            }
        }


        public JsonResult GetLGAs()
        {
            try
            {
                var stateList = _context.Localgovernments.Select(st => new {
                    id = st.Id,
                    name = st.Name
                }).ToList();
                return Json(new { data = stateList });
            }
            catch (Exception ex)
            {
                //LogError logerror = new LogError();
                LogWorker logWorker = new LogWorker("UtilitiesController", "GetLGAs", ex.Message.ToString());
                return Json(new { data = "Error has occured" });
            }
        }


        public JsonResult GetStateLGAs(string stateId)
        {
            try
            {
                var stateList = _context.Localgovernments.Where(x => x.StateId == stateId).Select(st => new {
                    id = st.Id,
                    name = st.Name
                }).ToList();
                return Json(new { data = stateList });
            }
            catch (Exception ex)
            {
                //LogError logerror = new LogError();
                LogWorker logWorker = new LogWorker("UtilitiesController", "GetStateLGAs", ex.Message.ToString());
                return Json(new { data = "Error has occured" });
            }
        }


    }
}