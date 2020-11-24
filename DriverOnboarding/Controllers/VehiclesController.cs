using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using DataTables.AspNet.Core;
using DataTables.AspNet.AspNetCore;
using DriverOnboarding.Models;

namespace DriverOnboarding.Controllers
{
    public class VehiclesController : Controller
    {

        IConfiguration _iconfiguration;
        public VehiclesController(IConfiguration iconfiguration)
        {
            _iconfiguration = iconfiguration;
        }


        // GET: Vehicles
        public ActionResult Index()
        {
            ViewBag.PageTitle = "Assigned Vehicles List";
            return View();
        }


        public string getVehicleServiceToken()
        {
            string _VehicleServiceEmail = _iconfiguration["VehiclesService:email"];
            string _VehicleServicePassword = _iconfiguration["VehiclesService:password"];
            string _VehicleServiceUrl = _iconfiguration["VehiclesService:url"];

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_VehicleServiceUrl);

                //client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("text/plain"));
                //client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", token);

                client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "application/json");
                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

                var jsondata = new
                {
                    email = _VehicleServiceEmail,
                    password = _VehicleServicePassword
                };

                var postTask = client.PostAsJsonAsync("user/signin", jsondata);

                postTask.Wait();

                var result = postTask.Result;
                dynamic contents = postTask.Result.Content.ReadAsStringAsync();

                var statusCode = (result.StatusCode).ToString();

                if (result.IsSuccessStatusCode)
                {
                    dynamic responseObject = JsonConvert.DeserializeObject(contents.Result);
                    string ret = responseObject.data.token;
                    return ret;
                }
                else if (statusCode == "BadRequest")
                {
                    dynamic responseObject = JsonConvert.DeserializeObject(contents.Result);
                    string ret = responseObject.data.token;
                    return ret;
                }
                else
                {
                    return "Bad Request";
                }
            }
            
        }


        public List<Vehicles> getVehicles()
        {
            string _VehicleServiceUrl = _iconfiguration["VehiclesService:url"];
            var token = getVehicleServiceToken();
            List<Vehicles> _vehicleList = new List<Vehicles>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_VehicleServiceUrl);

                //client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("text/plain"));
                client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", token);

                client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "application/json");
                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");

                var postTask = client.GetAsync("vehicle/use/inventory");

                postTask.Wait();

                var result = postTask.Result;
                dynamic contents = postTask.Result.Content.ReadAsStringAsync();

                var statusCode = (result.StatusCode).ToString();

                if (result.IsSuccessStatusCode)
                {
                    //dynamic vehicleslist = responseObject.data;
                    
                    dynamic _deserialsedVehicleList = JsonConvert.DeserializeObject(contents.Result);

                    dynamic vehicleslist = _deserialsedVehicleList.data;

                    foreach (var tempvehicle in vehicleslist)
                    {
                        var vehicle = new Vehicles()
                        {
                            id = tempvehicle.id,
                            driver_id = tempvehicle.driver_id,
                            moove_id = tempvehicle.moove_id,
                            make = tempvehicle.make,
                            model = tempvehicle.model,
                            year = tempvehicle.year,
                            color = tempvehicle.color,
                            status = tempvehicle.status,
                            assignment_status = tempvehicle.assignment_status,
                            vin = tempvehicle.vin,
                            mileage = tempvehicle.mileage,
                            registration_number = tempvehicle.registration_number,
                            comment = tempvehicle.comment,
                            created_at = DateTime.Parse(tempvehicle.created_at.ToString()),
                            updated_at = DateTime.Parse(tempvehicle.updated_at.ToString())
                        };
                        _vehicleList.Add(vehicle);
                    }

                    return _vehicleList;
                }
                else if (statusCode == "BadRequest")
                {
                    return _vehicleList;
                }
                else
                {
                    return _vehicleList;
                }
            }

        }


        public IActionResult VehicleData(IDataTablesRequest request)
        {
            try
            {
                var vehicleList = getVehicles().Where(x => x.assignment_status == "assigned"); ;

                var filteredData = String.IsNullOrWhiteSpace(request.Search.Value) ? vehicleList : vehicleList.Where(_item => _item.driver_id.Contains(request.Search.Value));

                var dataPage = filteredData.Skip(request.Start).Take(request.Length);

                var data = dataPage.Select(emList => new
                {
                    id = emList.id,
                    make = emList.make,
                    driver_id = emList.driver_id,
                    moove_id = emList.moove_id,
                    model = emList.model,
                    registration_number = emList.registration_number,
                    assignment_status = emList.assignment_status,
                    //DateCreated = Convert.ToDateTime(emList.DateCreated).ToString("dd MMM yyyy"),
                }).ToList();

                dynamic response = DataTablesResponse.Create(request, vehicleList.Count(), filteredData.Count(), data);

                return new DataTablesJsonResult(response, true);
            }
            catch (Exception ex)
            {
                //Provider.Instance.LogError(ex);
                //return DataTablesResponse.Create(request, 0, 0, 0);
                throw ex;
            }

            //return new DataTablesJsonResult(response, true);
        }


        public ActionResult UnAssigned()
        {
            ViewBag.PageTitle = "Un-Assigned Vehicles List";
            return View();
        }


        public IActionResult UnAssignedVehicleData(IDataTablesRequest request)
        {
            try
            {
                var vehicleList = getVehicles().Where(x=> x.assignment_status == "not assigned");

                var filteredData = String.IsNullOrWhiteSpace(request.Search.Value) ? vehicleList : vehicleList.Where(_item => _item.driver_id.Contains(request.Search.Value));

                var dataPage = filteredData.Skip(request.Start).Take(request.Length);

                var data = dataPage.Select(emList => new
                {
                    id = emList.id,
                    make = emList.make,
                    driver_id = emList.driver_id,
                    moove_id = emList.moove_id,
                    model = emList.model,
                    registration_number = emList.registration_number,
                    assignment_status = emList.assignment_status,
                    //DateCreated = Convert.ToDateTime(emList.DateCreated).ToString("dd MMM yyyy"),
                }).ToList();

                dynamic response = DataTablesResponse.Create(request, vehicleList.Count(), filteredData.Count(), data);

                return new DataTablesJsonResult(response, true);
            }
            catch (Exception ex)
            {
                //Provider.Instance.LogError(ex);
                //return DataTablesResponse.Create(request, 0, 0, 0);
                throw ex;
            }

            //return new DataTablesJsonResult(response, true);
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Vehicles/Create

        public ActionResult Create()
        {
            return View();
        }

        // POST: Vehicles/Create
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

        // GET: Vehicles/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Vehicles/Edit/5
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

        // GET: Vehicles/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Vehicles/Delete/5
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