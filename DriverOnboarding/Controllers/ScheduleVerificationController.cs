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
    public class ScheduleVerificationController : Controller
    {

        private gracelakemoovetestContext _context;

        public ScheduleVerificationController(gracelakemoovetestContext context)
        {
            this._context = context;
        }

        // GET: ScheduleVerification
        public ActionResult Index()
        {
            return View();
        }

        //List<string> invalidEntries = new List<string>();
        //Location and number of times it wasn't aasigned
        //Dictionary<string, int> UnassiagnedLocations = new Dictionary<string, int>();
        //Unassigned applicants and their location
        //List<Tuple<string, string>> UnassignedApplicants = new List<Tuple<string, string>>();

        //Dictionary<string, DispatchScheduleData> dispatchScheduleData = new Dictionary<string, DispatchScheduleData>();

        //protected void doRun(ScheduleVerification _scheduleVerification)
        //{
        //    var verificationParameters = _context.Dispatchscheduleparameters.FirstOrDefault();
        //    if (verificationParameters == null)
        //    {
        //        throw new Exception("Dispatch schedule parameters not set");
        //    }

        //    if (_scheduleVerification.MaxSchedule == 0)
        //    {
        //        _scheduleVerification.MaxSchedule = verificationParameters.MaxSchedulePerDispatch;
        //    }
        //    if (_scheduleVerification.ScheduleMode == DispatchScheduleMode.NotSet)
        //    {
        //        //_scheduleVerification.ScheduleMode = verificationParameters.DispatchScheduleMode;
        //    }
        //    if (_scheduleVerification.DispatchDate == DateTime.MinValue)
        //    {
        //        _scheduleVerification.DispatchDate = DateTime.Now;
        //    }

        //    var dispatcherids = _scheduleVerification.Dispatchers.Split(new Char[] { ' ', ';', '\r', ',', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();

        //    var driversEntries = _scheduleVerification.Drivers.Split(new Char[] { ' ', ';', '\r', ',', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();

        //    var guarantorEntries = _scheduleVerification.Guarantors.Split(new Char[] { ' ', ';', '\r', ',', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();

        //    var locals = _scheduleVerification.LocalGovernment.Split(new Char[] { ' ', ';', '\r', ',', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();

        //    var dispatches = (from d in _context.Dispatch
        //                      //join ds in _context.Dispatchschedule.GroupBy(ds => ds.DispatchId)
        //                      join ds in _context.Dispatchschedule
        //                      on d.DispatchId equals ds.DispatchId
        //                      where (dispatcherids.Contains(d.DispatchId) || dispatcherids.Count == 0) && ds.Date == _scheduleVerification.DispatchDate
        //                      select new QueryData { DispatchID = d.DispatchId,
        //                          DispatchDate = _scheduleVerification.DispatchDate,
        //                          ScheduleCount = _context.Dispatchschedule.Where(x=>x.DispatchId == _scheduleVerification.Dispatchers && x.Date == _scheduleVerification.DispatchDate).ToList().Count,
        //                          OpA = _context.Dispatchoperationalarea.Where(op => op.DispatchId == d.DispatchId).ToList()
        //                      }).ToList();


        //    PopulateData(dispatches);

        //    var unscheduledDispatch = (from d in _context.Dispatch
        //                               where !dispatchScheduleData.Keys.Contains(d.DispatchId) && (dispatcherids.Contains(d.DispatchId) || dispatcherids.Count == 0)
        //                               select new QueryData { DispatchID = d.DispatchId, DispatchDate = _scheduleVerification.DispatchDate,
        //                                   ScheduleCount = _context.Dispatchschedule.Where(x => x.DispatchId == _scheduleVerification.Dispatchers && x.Date == _scheduleVerification.DispatchDate).ToList().Count,
        //                                   OpA = _context.Dispatchoperationalarea.Where(op => op.DispatchId == d.DispatchId).ToList()
        //                               }).ToList();

        //    PopulateData(unscheduledDispatch);

        //    switch (_scheduleVerification.ScheduleFor)
        //    {
        //        case ScheduleFor.All:

        //            /*this will schedule both the applicant and guarantors by utilizing their respective entries
        //            it would try to schedule the drivers and their respective guarantors.
                    
        //             * */

        //            var unscheduleddrivers = (from a in _context.Applications
        //                                        where a.SubmittedForApproval == 1 && a.Scheduled == 0 && (driversEntries.Contains(a.Drn) || driversEntries.Count == 0)
        //                                        && (locals.Contains(a.LgaofResidence) || locals.Count == 0)
        //                                        && (a.LgaofResidence == _scheduleVerification.LCDA || _scheduleVerification.LCDA == "")
        //                                      select a).ToList();

        //            var unscheduledguarantorsDrns = (from g in _context.Guarantordetails
        //                                             where g.SubmittedForApproval == 1 && g.Scheduled == 0
        //                                             select g).ToList();

        //            ScheduleDrivers(unscheduleddrivers, _scheduleVerification);

        //            //ScheduleGuarantors(unscheduledguarantorsDrns, _scheduleVerification);

        //            foreach (var drn in driversEntries)
        //            {
        //                if (!unscheduleddrivers.Exists(d => d.Drn.ToString().ToLower() == drn.ToLower()))
        //                {
        //                    invalidEntries.Add(drn);
        //                }

        //            }

        //            var unscheduledguarantors = (from g in _context.Guarantordetails
        //                                         where g.SubmittedForApproval == 1 && g.Scheduled == 0 && (guarantorEntries.Contains(g.GuarantorId) || guarantorEntries.Count == 0)
        //                                        && (locals.Contains(g.LocalGovernmentArea) || locals.Count == 0)
        //                                            && (g.Lcda == _scheduleVerification.LCDA || _scheduleVerification.LCDA == "")
        //                                         select g).ToList();

        //            //remove scheduled guarantors from list
        //            var sendunscheduledguarantors = unscheduledguarantorsDrns.Except(unscheduledguarantorsDrns).ToList();

        //            foreach (var gua in guarantorEntries)
        //            {
        //                if (!sendunscheduledguarantors.Exists(g => g.GuarantorId.ToLower() == gua.ToLower()))
        //                {
        //                    invalidEntries.Add(gua);

        //                }

        //            }

        //            //ScheduleGuarantors(sendunscheduledguarantors, _scheduleVerification);

        //            break;
        //        case ScheduleFor.Driver:
        //            /*this will only consider the applicant's entries for scheduling. 
        //             * */
        //            var unScheduledDriversEntries = (from a in _context.Applications
        //                                             where a.SubmittedForApproval == 1 && a.Scheduled == 0 && (driversEntries.Contains(a.Drn) || driversEntries.Count == 0)
        //                                            && (locals.Contains(a.LgaofResidence) || locals.Count == 0)
        //                                                && (a.LgaofResidence == _scheduleVerification.LCDA || _scheduleVerification.LCDA == "")
        //                                             select a).ToList();

        //            var unscheduledDrivers = unScheduledDriversEntries.Select(x => x.Drn).ToList();

        //            var unscheduleddriverguarantors = (from g in _context.Guarantordetails
        //                                               where unscheduledDrivers.Contains(g.Drn) && g.SubmittedForApproval == 1 && g.Scheduled == 0
        //                                               select g).ToList();

        //            ScheduleDrivers(unScheduledDriversEntries, _scheduleVerification);
        //            //ScheduleGuarantors(unscheduleddriverguarantors, _scheduleVerification);

        //            foreach (var drn in driversEntries)
        //            {
        //                if (!unScheduledDriversEntries.Exists(c => c.Drn == drn))
        //                {
        //                    invalidEntries.Add(drn);
        //                }

        //            }

        //            break;
        //        case ScheduleFor.Guarantor:
        //            /*
        //             * this will only consider values from the guarantors entries for scheduling
        //             * */
        //            var unscheduledguarantorsonly = (from g in _context.Guarantordetails
        //                                             where g.SubmittedForApproval ==1 && g.Scheduled ==0 && (guarantorEntries.Contains(g.GuarantorId) || guarantorEntries.Count == 0)
        //                                            && (locals.Contains(g.LocalGovernmentArea) || locals.Count == 0)
        //                                                && (g.Lcda == _scheduleVerification.LCDA || _scheduleVerification.LCDA == "")
        //                                             select g).ToList();
        //            foreach (var gua in guarantorEntries)
        //            {
        //                if (!unscheduledguarantorsonly.Exists(g => g.GuarantorId.ToLower() == gua.ToLower()))
        //                {
        //                    invalidEntries.Add(gua);
        //                }
        //            }

        //            //ScheduleGuarantors(unscheduledguarantorsonly, _scheduleVerification);
        //            break;
        //        default:
        //            break;
        //    }

        //    foreach (var entry in invalidEntries)
        //    {
        //        //Infolog.add($"{entry} was not selected for scheduling", InfoType.Error);
        //    }

        //    foreach (var app in UnassignedApplicants)
        //    {
        //        //Infolog.add($"{app.Item1} in {app.Item2} not assigned", InfoType.Error);
        //    }

        //    foreach (var loc in UnassiagnedLocations)
        //    {
        //        //Infolog.add($"{loc.Value} {loc.Key} not assigned", InfoType.Error);
        //    }

        //    ValidateSchedule(_scheduleVerification);

        //    //Forms.TempDispatchSchedule temp = new Forms.TempDispatchSchedule(tempDatabaseHandler);
        //    //temp.open();
        //}

        //private void PopulateData(IEnumerable<QueryData> dispatches)
        //{
        //    foreach (var dispatch in dispatches)
        //    {
        //        dispatchScheduleData.Add(dispatch.DispatchID, new DispatchScheduleData
        //        {
        //            DispatchID = dispatch.DispatchID,
        //            ScheduleCount = Convert.ToInt32(dispatch.ScheduleCount),
        //            OperationalAreas = new List<Tuple<int, string>> { }
        //        });

        //        foreach (var opa in dispatch.OpA)
        //        {
        //            dispatchScheduleData[dispatch.DispatchID].OperationalAreas.Add(new Tuple<int, string>(opa.Rank, opa.Lga));
        //        }
        //    }
        //}

        //private void ScheduleDrivers(List<Applications> drivers, ScheduleVerification _scheduleVerification)
        //{
        //    //TODO:update scheduled driver and guarantor to reflect that they have been scheduled (it will be done when temp schedule is approved)
        //    if (_scheduleVerification.ScheduleMode == DispatchScheduleMode.FillEachDispatch)
        //    {
        //        var ordDrivers = drivers.OrderBy(x => x.LgaofResidence);
        //        string recentlyFilled = null;
        //        int recentIteration = 0;
        //        int count = 0;
        //        foreach (var d in ordDrivers)
        //        {
        //            count++;
        //            int iterations = 0;
        //            bool scheduled = false;
        //            bool dispatchavailable = false;
        //            var reachedMaxSchedule = new List<string>();

        //            while (!scheduled)
        //            {
        //                dispatchavailable = false;
        //                scheduled = false;

        //                if (UnassiagnedLocations.Keys.Contains(d.LgaofResidence))
        //                {
        //                    UnassiagnedLocations[d.LgaofResidence]++;
        //                    UnassignedApplicants.Add(new Tuple<string, string>(d.Drn, d.LgaofResidence));
        //                    break;
        //                }

        //                if (recentlyFilled != null)
        //                {
        //                    iterations = -1;
        //                    if (dispatchScheduleData[recentlyFilled].ScheduleCount < _scheduleVerification.MaxSchedule)
        //                    {
        //                        if (iterations < dispatchScheduleData[recentlyFilled].OperationalAreas.Count)
        //                        {
        //                            //dispatch available is to check that I have gone through all operational areas for all dispatch 
        //                            dispatchavailable = true;
        //                            if (d.LgaofResidence == dispatchScheduleData[recentlyFilled].OperationalAreas[recentIteration].Item2)
        //                            {
        //                                var tempSchedule = new Tempdispatchschedule
        //                                {
        //                                    DispatchId = dispatchScheduleData[recentlyFilled].DispatchID,
        //                                    Date = _scheduleVerification.DispatchDate,
        //                                    GuarantorId = g.GuarantorId,
        //                                    Drn = g.Drn,
        //                                    DispatchOperationalArea = dispatchScheduleData[recentlyFilled].OperationalAreas[recentIteration].Item2,
        //                                    VerificationLocation = g.LocalGovernmentArea,
        //                                    //DatabaseHandler = tempDatabaseHandler,
        //                                };
        //                                try
        //                                {
        //                                    //DatabaseHandler = tempDatabaseHandler,
        //                                    //tempSchedule.insert();
        //                                    _context.Tempdispatchschedule.Add(tempSchedule);
        //                                    _context.SaveChanges();
        //                                    // DatabaseHandler.DefaultDatabaseHandlerObject.commitTransaction();
        //                                    scheduled = true;
        //                                    dispatchScheduleData[recentlyFilled].ScheduleCount++;
        //                                }
        //                                catch (Exception ex)
        //                                {
        //                                    //Infolog.add(ex.Message, InfoType.Error);
        //                                    //Infolog.writeToEventLog(ex, InfoType.Error);
        //                                    // DatabaseHandler.DefaultDatabaseHandlerObject.rollBackTransaction();
        //                                }
        //                            }
        //                        }
        //                    }
        //                    else
        //                    {
        //                        reachedMaxSchedule.Add(recentlyFilled);
        //                    }
        //                }
        //                else
        //                {
        //                    foreach (var dis in dispatchScheduleData)
        //                    {
        //                        if (dis.Value.ScheduleCount < _scheduleVerification.MaxSchedule)
        //                        {
        //                            if (!dis.Value.Sorted)
        //                            {
        //                                dis.Value.OperationalAreas = dis.Value.OperationalAreas.OrderBy(x => x.Item1).ToList();
        //                                dis.Value.Sorted = true;
        //                            }

        //                            if (iterations < dis.Value.OperationalAreas.Count)
        //                            {
        //                                //dispatch available is to check that I have gone through all operational areas for all dispatch 
        //                                dispatchavailable = true;
        //                                if (d.LgaofResidence == dis.Value.OperationalAreas[iterations].Item2)
        //                                {
        //                                    var tempSchedule = new Tempdispatchschedule
        //                                    {
        //                                        DispatchId = dispatchScheduleData[recentlyFilled].DispatchID,
        //                                        Date = _scheduleVerification.DispatchDate,
        //                                        GuarantorId = g.GuarantorId,
        //                                        Drn = g.Drn,
        //                                        DispatchOperationalArea = dispatchScheduleData[recentlyFilled].OperationalAreas[recentIteration].Item2,
        //                                        VerificationLocation = g.LocalGovernmentArea,
        //                                        //DatabaseHandler = tempDatabaseHandler,
        //                                    };
                                            
        //                                    try
        //                                    {
        //                                        //DatabaseHandler = tempDatabaseHandler,
        //                                        //tempSchedule.insert();

        //                                        _context.Tempdispatchschedule.Add(tempSchedule);
        //                                        _context.SaveChanges();
        //                                        // DatabaseHandler.DefaultDatabaseHandlerObject.commitTransaction();
        //                                        scheduled = true;
        //                                        dis.Value.ScheduleCount++;
        //                                        recentlyFilled = dis.Key;
        //                                        recentIteration = iterations;
        //                                        break;
        //                                    }
        //                                    catch (Exception ex)
        //                                    {
        //                                        //Infolog.add(ex.Message, InfoType.Error);
        //                                        //Infolog.writeToEventLog(ex, InfoType.Error);
        //                                        // DatabaseHandler.DefaultDatabaseHandlerObject.rollBackTransaction();
        //                                        //continue;
        //                                    }
        //                                }
        //                            }
        //                        }
        //                        else
        //                        {
        //                            reachedMaxSchedule.Add(dis.Key);
        //                        }
        //                    }
        //                }

        //                foreach (var s in reachedMaxSchedule)
        //                {
        //                    dispatchScheduleData.Remove(s);
        //                }

        //                //if applicant is not scheduled and there is no dispatch suitable to take the applicant location, log the location so you wont have to check again
        //                if (!scheduled && !dispatchavailable && recentlyFilled == null)
        //                {
        //                    if (UnassiagnedLocations.Keys.Contains(d.LgaofResidence))
        //                    {
        //                        UnassiagnedLocations[d.LgaofResidence]++;
        //                        UnassignedApplicants.Add(new Tuple<string, string>(d.Drn, d.LgaofResidence));
        //                    }
        //                    else
        //                    {
        //                        UnassiagnedLocations.Add(d.LgaofResidence, 1);
        //                        UnassignedApplicants.Add(new Tuple<string, string>(d.Drn, d.LgaofResidence));
        //                    }
        //                    break;
        //                }
        //                else if (!scheduled && (dispatchavailable || recentlyFilled != null))
        //                {
        //                    recentlyFilled = null;
        //                    iterations++;
        //                }
        //            }

        //        }
        //    }
        //    else if (_scheduleVerification.ScheduleMode == DispatchScheduleMode.DistributeEvenly)
        //    {
        //        var grpDrivers = drivers.GroupBy(x => x.LgaofResidence);
        //        foreach (var driver in grpDrivers)
        //        {
        //            int iterations = 0;
        //            bool operationalAreasExhausted = true;
        //            var reachedMaxSchedule = new List<string>();
        //            int currentScheduleCount = 0;

        //            while (driver.Count<Applications>() > currentScheduleCount)
        //            {
        //                var dispatchAvailableInIteration = new List<string>();
        //                var check = false;
        //                foreach (var dis in dispatchScheduleData)
        //                {
        //                    check = false;
        //                    if (dis.Value.ScheduleCount < _scheduleVerification.MaxSchedule)
        //                    {
        //                        if (!dis.Value.Sorted)
        //                        {
        //                            dis.Value.OperationalAreas = dis.Value.OperationalAreas.OrderBy(x => x.Item1).ToList();
        //                            dis.Value.Sorted = true;
        //                        }

        //                        if (iterations < dis.Value.OperationalAreas.Count)
        //                        {
        //                            //goneThroughAllOperationalAreas is to check that I have gone through all operational areas for all dispatch 
        //                            operationalAreasExhausted = false;
        //                            check = true;
        //                            if (driver.Key == dis.Value.OperationalAreas[iterations].Item2)
        //                            {
        //                                dispatchAvailableInIteration.Add(dis.Key);
        //                            }
        //                        }
        //                    }
        //                    else
        //                    {
        //                        reachedMaxSchedule.Add(dis.Key);
        //                    }
        //                }

        //                if (!check)
        //                {
        //                    operationalAreasExhausted = true;
        //                }

        //                var driverList = driver.ToList();
        //                int schedulePerDispatch = 0;
        //                int remainder = 0;
        //                if (dispatchAvailableInIteration.Count > 0)
        //                {
        //                    schedulePerDispatch = (driverList.Count - currentScheduleCount) / dispatchAvailableInIteration.Count;
        //                }

        //                schedulePerDispatch = schedulePerDispatch < 1 ? 1 : schedulePerDispatch;
        //                remainder = driverList.Count - (dispatchAvailableInIteration.Count * schedulePerDispatch);

        //                dispatchAvailableInIteration = dispatchScheduleData.Where(x => dispatchAvailableInIteration.Contains(x.Key)).OrderBy(x => x.Value.ScheduleCount).Select(x => x.Key).ToList();

        //                foreach (var dis in dispatchAvailableInIteration)
        //                {
        //                    int currentScheduleCountForDis = 0;
        //                    bool remainderAdded = false;
        //                    while (currentScheduleCountForDis < schedulePerDispatch || (remainder > 0 && !remainderAdded))
        //                    {
        //                        if (dispatchScheduleData[dis].ScheduleCount < _scheduleVerification.MaxSchedule)
        //                        {
        //                            if (!dispatchScheduleData[dis].Sorted)
        //                            {
        //                                dispatchScheduleData[dis].OperationalAreas = dispatchScheduleData[dis].OperationalAreas.OrderBy(x => x.Item1).ToList();
        //                                dispatchScheduleData[dis].Sorted = true;
        //                            }

        //                            var tempSchedule = new Tempdispatchschedule
        //                            {
        //                                DispatchId = dispatchScheduleData[recentlyFilled].DispatchID,
        //                                Date = _scheduleVerification.DispatchDate,
        //                                GuarantorId = g.GuarantorId,
        //                                Drn = g.Drn,
        //                                DispatchOperationalArea = dispatchScheduleData[recentlyFilled].OperationalAreas[recentIteration].Item2,
        //                                VerificationLocation = g.LocalGovernmentArea,
        //                                //DatabaseHandler = tempDatabaseHandler,
        //                            };
        //                            try
        //                            {
        //                                //DatabaseHandler = tempDatabaseHandler,
        //                                _context.Tempdispatchschedule.Add(tempSchedule);
        //                                _context.SaveChanges();
        //                                // DatabaseHandler.DefaultDatabaseHandlerObject.commitTransaction();
        //                                dispatchScheduleData[dis].ScheduleCount++;
        //                                currentScheduleCount++;
        //                                currentScheduleCountForDis++;

        //                                if (currentScheduleCountForDis > schedulePerDispatch)
        //                                {
        //                                    remainderAdded = true;
        //                                    remainder--;
        //                                }
        //                            }
        //                            catch (Exception ex)
        //                            {
        //                                //Infolog.add(ex.Message, InfoType.Error);
        //                                //Infolog.writeToEventLog(ex, InfoType.Error);
        //                                // DatabaseHandler.DefaultDatabaseHandlerObject.rollBackTransaction();
        //                            }
        //                        }
        //                        else
        //                        {
        //                            reachedMaxSchedule.Add(dis);
        //                            break;//break out of loop cos current dispatch can't take anymore applicant even though it hasn't reached calculated schedule per dispatch
        //                        }
        //                    }

        //                    //current group has been fully scheduled, so move to the next one
        //                    if (currentScheduleCount >= driverList.Count)
        //                    {
        //                        break;
        //                    }
        //                }

        //                foreach (var s in reachedMaxSchedule)
        //                {
        //                    dispatchScheduleData.Remove(s);
        //                }
        //                reachedMaxSchedule.Clear();

        //                //if applicant is not scheduled and there is no dispatch suitable to take the applicant location, log the location so you wont have to check again
        //                if ((driverList.Count - currentScheduleCount) > 0 && operationalAreasExhausted)
        //                {
        //                    int diff = driverList.Count - currentScheduleCount;
        //                    if (!UnassiagnedLocations.Keys.Contains(driver.Key))
        //                    {
        //                        UnassiagnedLocations.Add(driver.Key, diff);
        //                    }
        //                    else
        //                    {
        //                        UnassiagnedLocations[driver.Key] += diff;
        //                    }

        //                    for (int i = 0; i < diff; i++)
        //                    {
        //                        var d = driverList[currentScheduleCount + i];
        //                        UnassignedApplicants.Add(new Tuple<string, string>(d.Drn, d.LgaofResidence));
        //                    }

        //                    break;
        //                }
        //                else if ((driverList.Count - currentScheduleCount) > 0 && !operationalAreasExhausted)
        //                {
        //                    iterations++;
        //                }
        //            }
        //        }
        //    }
        //}

        //private void ScheduleGuarantors(List<GuarantorDetails> guarantors, ScheduleVerification _scheduleVerification)
        //{
        //    if (_scheduleVerification.ScheduleMode == DispatchScheduleMode.FillEachDispatch)
        //    {
        //        var ordGuarantors = guarantors.OrderBy(x => x.LocalGovernmentArea);
        //        string recentlyFilled = null;
        //        int recentIteration = 0;
        //        foreach (var g in ordGuarantors)
        //        {
        //            int iterations = 0;
        //            bool scheduled = false;
        //            bool dispatchavailable = false;
        //            var reachedMaxSchedule = new List<string>();

        //            while (!scheduled)
        //            {
        //                dispatchavailable = false;
        //                scheduled = false;

        //                if (UnassiagnedLocations.Keys.Contains(g.LocalGovernmentArea))
        //                {
        //                    UnassiagnedLocations[g.LocalGovernmentArea]++;
        //                    UnassignedApplicants.Add(new Tuple<string, string>(g.GuarantorId, g.LocalGovernmentArea));
        //                    break;
        //                }

        //                if (recentlyFilled != null)
        //                {
        //                    iterations = -1;
        //                    if (dispatchScheduleData[recentlyFilled].ScheduleCount < _scheduleVerification.MaxSchedule)
        //                    {
        //                        if (iterations < dispatchScheduleData[recentlyFilled].OperationalAreas.Count)
        //                        {
        //                            //dispatch available is to check that I have gone through all operational areas for all dispatch 
        //                            dispatchavailable = true;
        //                            if (g.LocalGovernmentArea == dispatchScheduleData[recentlyFilled].OperationalAreas[recentIteration].Item2)
        //                            {
        //                                var tempSchedule = new Tempdispatchschedule
        //                                {
        //                                    DispatchId = dispatchScheduleData[recentlyFilled].DispatchID,
        //                                    Date = _scheduleVerification.DispatchDate,
        //                                    GuarantorId = g.GuarantorId,
        //                                    Drn = g.Drn,
        //                                    DispatchOperationalArea = dispatchScheduleData[recentlyFilled].OperationalAreas[recentIteration].Item2,
        //                                    VerificationLocation = g.LocalGovernmentArea,
        //                                    //DatabaseHandler = tempDatabaseHandler,
        //                                };
        //                                try
        //                                {
        //                                    //DatabaseHandler = tempDatabaseHandler,
        //                                    //tempSchedule.insert();
        //                                    _context.Tempdispatchschedule.Add(tempSchedule);
        //                                    _context.SaveChanges();
        //                                    // DatabaseHandler.DefaultDatabaseHandlerObject.commitTransaction();
        //                                    scheduled = true;
        //                                    dispatchScheduleData[recentlyFilled].ScheduleCount++;
        //                                }
        //                                catch (Exception ex)
        //                                {
        //                                    //Infolog.add(ex.Message, InfoType.Error);
        //                                    //Infolog.writeToEventLog(ex, InfoType.Error);
        //                                    // DatabaseHandler.DefaultDatabaseHandlerObject.rollBackTransaction();
        //                                }
        //                            }
        //                        }
        //                    }
        //                    else
        //                    {
        //                        reachedMaxSchedule.Add(recentlyFilled);
        //                    }
        //                }
        //                else
        //                {
        //                    foreach (var dis in dispatchScheduleData)
        //                    {
        //                        if (dis.Value.ScheduleCount < _scheduleVerification.MaxSchedule)
        //                        {
        //                            if (!dis.Value.Sorted)
        //                            {
        //                                dis.Value.OperationalAreas = dis.Value.OperationalAreas.OrderBy(x => x.Item1).ToList();
        //                                dis.Value.Sorted = true;
        //                            }

        //                            if (iterations < dis.Value.OperationalAreas.Count)
        //                            {
        //                                //dispatch available is to check that I have gone through all operational areas for all dispatch 
        //                                dispatchavailable = true;
        //                                if (g.LocalGovernmentArea == dis.Value.OperationalAreas[iterations].Item2)
        //                                {
        //                                    var tempSchedule = new Tempdispatchschedule
        //                                    {
        //                                        DispatchId = dis.Value.DispatchID,
        //                                        Date = _scheduleVerification.DispatchDate,
        //                                        GuarantorId = g.GuarantorId,
        //                                        DispatchOperationalArea = dis.Value.OperationalAreas[iterations].Item2,
        //                                        VerificationLocation = g.LocalGovernmentArea,
        //                                        Drn = g.Drn,
        //                                        //DatabaseHandler = tempDatabaseHandler,
        //                                    };
        //                                    try
        //                                    {
        //                                        //DatabaseHandler = tempDatabaseHandler,
        //                                        //tempSchedule.insert();
        //                                        _context.Tempdispatchschedule.Add(tempSchedule);
        //                                        _context.SaveChanges();
        //                                        // DatabaseHandler.DefaultDatabaseHandlerObject.commitTransaction();
        //                                        scheduled = true;
        //                                        dis.Value.ScheduleCount++;
        //                                        recentlyFilled = dis.Key;
        //                                        recentIteration = iterations;
        //                                        break;
        //                                    }
        //                                    catch (Exception ex)
        //                                    {
        //                                        //Infolog.add(ex.Message, InfoType.Error);
        //                                        //Infolog.writeToEventLog(ex, InfoType.Error);
        //                                        // DatabaseHandler.DefaultDatabaseHandlerObject.rollBackTransaction();
        //                                        //continue;
        //                                    }
        //                                }
        //                            }
        //                        }
        //                        else
        //                        {
        //                            reachedMaxSchedule.Add(dis.Key);
        //                        }
        //                    }
        //                }

        //                foreach (var s in reachedMaxSchedule)
        //                {
        //                    dispatchScheduleData.Remove(s);
        //                }

        //                //if applicant is not scheduled and there is no dispatch suitable to take the applicant location, log the location so you wont have to check again
        //                if (!scheduled && !dispatchavailable && recentlyFilled == null)
        //                {
        //                    if (UnassiagnedLocations.Keys.Contains(g.LocalGovernmentArea))
        //                    {
        //                        UnassiagnedLocations[g.LocalGovernmentArea]++;
        //                        UnassignedApplicants.Add(new Tuple<string, string>(g.GuarantorId, g.LocalGovernmentArea));
        //                    }
        //                    else
        //                    {
        //                        UnassiagnedLocations.Add(g.LocalGovernmentArea, 1);
        //                        UnassignedApplicants.Add(new Tuple<string, string>(g.GuarantorId, g.LocalGovernmentArea));
        //                    }
        //                    break;
        //                }
        //                else if (!scheduled && (dispatchavailable || recentlyFilled != null))
        //                {
        //                    recentlyFilled = null;
        //                    iterations++;
        //                }
        //            }

        //        }
        //    }
        //    else if (_scheduleVerification.ScheduleMode == DispatchScheduleMode.DistributeEvenly)
        //    {
        //        var grpGuarantors = guarantors.GroupBy(x => x.LocalGovernmentArea);
        //        foreach (var guarantor in grpGuarantors)
        //        {
        //            int iterations = 0;
        //            bool operationalAreasExhausted = true;
        //            var reachedMaxSchedule = new List<string>();
        //            int currentScheduleCount = 0;

        //            while (guarantor.Count<GuarantorDetails>() > currentScheduleCount)
        //            {
        //                var dispatchAvailableInIteration = new List<string>();
        //                var check = false;
        //                foreach (var dis in dispatchScheduleData)
        //                {
        //                    check = false;
        //                    if (dis.Value.ScheduleCount < _scheduleVerification.MaxSchedule)
        //                    {
        //                        if (!dis.Value.Sorted)
        //                        {
        //                            dis.Value.OperationalAreas = dis.Value.OperationalAreas.OrderBy(x => x.Item1).ToList();
        //                            dis.Value.Sorted = true;
        //                        }

        //                        if (iterations < dis.Value.OperationalAreas.Count)
        //                        {
        //                            //goneThroughAllOperationalAreas is to check that I have gone through all operational areas for all dispatch 
        //                            operationalAreasExhausted = false;
        //                            check = true;
        //                            if (guarantor.Key == dis.Value.OperationalAreas[iterations].Item2)
        //                            {
        //                                dispatchAvailableInIteration.Add(dis.Key);
        //                            }
        //                        }
        //                    }
        //                    else
        //                    {
        //                        reachedMaxSchedule.Add(dis.Key);
        //                    }
        //                }

        //                if (!check)
        //                {
        //                    operationalAreasExhausted = true;
        //                }
        //                var guarantorList = guarantor.ToList();
        //                int schedulePerDispatch = 0;
        //                int remainder = 0;
        //                if (dispatchAvailableInIteration.Count > 0)
        //                {
        //                    schedulePerDispatch = (guarantorList.Count - currentScheduleCount) / dispatchAvailableInIteration.Count;
        //                }

        //                schedulePerDispatch = schedulePerDispatch < 1 ? 1 : schedulePerDispatch;
        //                remainder = guarantorList.Count - (dispatchAvailableInIteration.Count * schedulePerDispatch);

        //                dispatchAvailableInIteration = dispatchScheduleData.Where(x => dispatchAvailableInIteration.Contains(x.Key)).OrderBy(x => x.Value.ScheduleCount).Select(x => x.Key).ToList();

        //                foreach (var dis in dispatchAvailableInIteration)
        //                {
        //                    int currentScheduleCountForDis = 0;
        //                    bool remainderAdded = false;

        //                    while (currentScheduleCountForDis < schedulePerDispatch)
        //                    {
        //                        if (dispatchScheduleData[dis].ScheduleCount < _scheduleVerification.MaxSchedule || (remainder > 0 && !remainderAdded))
        //                        {
        //                            var tempSchedule = new Tempdispatchschedule
        //                            {
        //                                DispatchId = dispatchScheduleData[dis].DispatchID,
        //                                Date = _scheduleVerification.DispatchDate,
        //                                GuarantorId = guarantorList[currentScheduleCount].GuarantorId,
        //                                Drn = guarantorList[currentScheduleCount].Drn,
        //                                DispatchOperationalArea = dispatchScheduleData[dis].OperationalAreas[iterations].Item2,
        //                                VerificationLocation = guarantorList[currentScheduleCount].LocalGovernmentArea,
        //                                //DatabaseHandler = tempDatabaseHandler,
        //                            };
        //                            try
        //                            {
        //                                //DatabaseHandler = tempDatabaseHandler,
        //                                //tempSchedule.insert();
        //                                _context.Tempdispatchschedule.Add(tempSchedule);
        //                                _context.SaveChanges();
        //                                // DatabaseHandler.DefaultDatabaseHandlerObject.commitTransaction();
        //                                dispatchScheduleData[dis].ScheduleCount++;
        //                                currentScheduleCount++;
        //                                currentScheduleCountForDis++;

        //                                if (currentScheduleCountForDis > schedulePerDispatch)
        //                                {
        //                                    remainderAdded = true;
        //                                    remainder--;
        //                                }
        //                            }
        //                            catch (Exception ex)
        //                            {
        //                                //Infolog.add(ex.Message, InfoType.Error);
        //                                //Infolog.writeToEventLog(ex, InfoType.Error);
        //                                // DatabaseHandler.DefaultDatabaseHandlerObject.rollBackTransaction();
        //                            }
        //                        }
        //                        else
        //                        {
        //                            reachedMaxSchedule.Add(dis);
        //                            break;//break out of loop cos current dispatch can't take anymore applicant even though it hasn't reached calculated schedule per dispatch
        //                        }
        //                    }

        //                    //current group has been exhausted, so move to the next one
        //                    if (currentScheduleCount >= guarantorList.Count)
        //                    {
        //                        break;
        //                    }
        //                }

        //                foreach (var s in reachedMaxSchedule)
        //                {
        //                    dispatchScheduleData.Remove(s);
        //                }
        //                reachedMaxSchedule.Clear();

        //                //if applicant is not scheduled and there is no dispatch suitable to take the applicant location, log the location so you wont have to check again
        //                if ((guarantorList.Count - currentScheduleCount) > 0 && operationalAreasExhausted)
        //                {
        //                    int diff = guarantorList.Count - currentScheduleCount;
        //                    if (!UnassiagnedLocations.Keys.Contains(guarantor.Key))
        //                    {
        //                        UnassiagnedLocations.Add(guarantor.Key, diff);
        //                    }
        //                    else
        //                    {
        //                        UnassiagnedLocations[guarantor.Key] += diff;
        //                    }

        //                    for (int i = 0; i < diff; i++)
        //                    {
        //                        var d = guarantorList[currentScheduleCount + i];
        //                        UnassignedApplicants.Add(new Tuple<string, string>(d.GuarantorId, d.LocalGovernmentArea));
        //                    }

        //                    break;
        //                }
        //                else if ((guarantorList.Count - currentScheduleCount) > 0 && !operationalAreasExhausted)
        //                {
        //                    iterations++;
        //                }
        //            }
        //        }
        //    }
        //}

        //private void ValidateSchedule(ScheduleVerification _scheduleVerification)
        //{
        //    var schedule = (from ts in _context.Tempdispatchschedule
        //                    where ts.Date == _scheduleVerification.DispatchDate
        //                    //where ts.Date == _scheduleVerification.DispatchDate && ts.CreatedBy == Session.User.Username
        //                    select ts).ToList().GroupBy(ts => ts.Drn);

        //    foreach (var grp in schedule)
        //    {
        //        if (grp.ToList().Count < 2)
        //        {
        //            try
        //            {
        //                //DatabaseHandler = tempDatabaseHandler,
        //                grp.First();
        //                // DatabaseHandler.DefaultDatabaseHandlerObject.commitTransaction();
        //            }
        //            catch (Exception ex)
        //            {
        //                //Infolog.writeToEventLog(ex, InfoType.Error);
        //                //Infolog.add(ex.Message, InfoType.Error);
        //                // DatabaseHandler.DefaultDatabaseHandlerObject.rollBackTransaction();
        //            }
        //        }
        //    }
        //}
        // GET: ScheduleVerification/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ScheduleVerification/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ScheduleVerification/Create
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

        // GET: ScheduleVerification/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ScheduleVerification/Edit/5
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

        // GET: ScheduleVerification/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ScheduleVerification/Delete/5
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