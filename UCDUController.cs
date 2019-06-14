using Microsoft.Reporting.WebForms;
using Microsoft.Security.Application;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;



using UCDU.Models;
using UCDU.Models.BL;

namespace UCDU.Controllers
{
    public class UCDUController : Controller
    {

        #region Usert Part


        #region  SignUp
        [HttpGet]
        public ActionResult SignUp()
        {

            UserInfo u = new UserInfo();
            return View(u);
        }

        [HttpPost]
        public ActionResult SignUp(UserInfo u)
        {

            if (ModelState.IsValid)
            {
                u.PosId = UserInfoBL.getPositionId(u.PositionVal);

                List<UserInfo> ucheck = UserInfoBL.getAllUname_NID();

                {

                    string Message;

                    #region  Validation Part

                    {


                        //Validation Part Arabic Name
                        u.Aname = Sanitizer.GetSafeHtmlFragment(u.Aname);
                        u.Aname = u.Aname.ToString().Replace("\\", "");
                        u.Aname = u.Aname.ToString().Replace("%", "");
                        u.Aname = Regex.Replace(u.Aname, "(\')", "");
                        u.Aname = Regex.Replace(u.Aname, "(\")", "");
                        u.Aname = Regex.Replace(u.Aname, "(-)", "");



                        //Validation Part English Name
                        u.Ename = Sanitizer.GetSafeHtmlFragment(u.Ename);
                        u.Ename = u.Ename.ToString().Replace("\\", "");
                        u.Ename = u.Ename.ToString().Replace("%", "");
                        u.Ename = Regex.Replace(u.Ename, "(\')", "");
                        u.Ename = Regex.Replace(u.Ename, "(\")", "");
                        u.Ename = Regex.Replace(u.Ename, "(-)", "");

                        //Validation Part BirthDate
                        u.BD = Sanitizer.GetSafeHtmlFragment(u.BD);
                        u.BD = u.BD.ToString().Replace("\\", "");
                        u.BD = u.BD.ToString().Replace("%", "");
                        u.BD = Regex.Replace(u.BD, "(\')", "");
                        u.BD = Regex.Replace(u.BD, "(\")", "");
                        u.BD = Regex.Replace(u.BD, "(-)", "");

                        //Validation Part Country
                        u.Country = Sanitizer.GetSafeHtmlFragment(u.Country);
                        u.Country = u.Country.ToString().Replace("\\", "");
                        u.Country = u.Country.ToString().Replace("%", "");
                        u.Country = Regex.Replace(u.Country, "(\')", "");
                        u.Country = Regex.Replace(u.Country, "(\")", "");
                        u.Country = Regex.Replace(u.Country, "(-)", "");


                        //Validation Part City
                        u.City = Sanitizer.GetSafeHtmlFragment(u.City);
                        u.City = u.City.ToString().Replace("\\", "");
                        u.City = u.City.ToString().Replace("%", "");
                        u.City = Regex.Replace(u.City, "(\')", "");
                        u.City = Regex.Replace(u.City, "(\")", "");
                        u.City = Regex.Replace(u.City, "(-)", "");

                        //Validation Part UserName
                        u.Uname = Sanitizer.GetSafeHtmlFragment(u.Uname);
                        u.Uname = u.Uname.ToString().Replace("\\", "");
                        u.Uname = u.Uname.ToString().Replace("%", "");
                        u.Uname = Regex.Replace(u.Uname, "(\')", "");
                        u.Uname = Regex.Replace(u.Uname, "(\")", "");
                        u.Uname = Regex.Replace(u.Uname, "(-)", "");


                        //Validation Part Email
                        u.Email = Sanitizer.GetSafeHtmlFragment(u.Email);
                        u.Email = u.Email.ToString().Replace("\\", "");
                        u.Email = u.Email.ToString().Replace("%", "");
                        u.Email = Regex.Replace(u.Email, "(\')", "");
                        u.Email = Regex.Replace(u.Email, "(\")", "");
                        u.Email = Regex.Replace(u.Email, "(-)", "");


                        //Validation Part NID
                        long nid;
                        if (!(long.TryParse(u.NID.ToString(), out nid)))
                        {
                            ViewBag.MessageNID = "Invalid National ID please make sure to insert 14 Number";
                            return View(u);

                        }
                        else if (!(u.NID <= 99999999999999 && u.NID > 9999999999999))
                        {
                            ViewBag.MessageNID = "Invalid National ID please make sure to insert 14 Number";
                            return View(u);
                        }


                        //Validation Part PWD
                        u.Pwd = Sanitizer.GetSafeHtmlFragment(u.Pwd);
                        u.Pwd = u.Pwd.ToString().Replace("\\", "");
                        u.Pwd = u.Pwd.ToString().Replace("%", "");
                        u.Pwd = Regex.Replace(u.Pwd, "(\')", "");
                        u.Pwd = Regex.Replace(u.Pwd, "(\")", "");
                        u.Pwd = Regex.Replace(u.Pwd, "(-)", "");

                        //Validation Part ConfirmedPWD
                        u.ConfirmPwd = Sanitizer.GetSafeHtmlFragment(u.ConfirmPwd);
                        u.ConfirmPwd = u.ConfirmPwd.ToString().Replace("\\", "");
                        u.ConfirmPwd = u.ConfirmPwd.ToString().Replace("%", "");
                        u.ConfirmPwd = Regex.Replace(u.ConfirmPwd, "(\')", "");
                        u.ConfirmPwd = Regex.Replace(u.ConfirmPwd, "(\")", "");
                        u.ConfirmPwd = Regex.Replace(u.ConfirmPwd, "(-)", "");


                        //Validation Part University
                        u.University = Sanitizer.GetSafeHtmlFragment(u.University);
                        u.University = u.University.ToString().Replace("\\", "");
                        u.University = u.University.ToString().Replace("%", "");
                        u.University = Regex.Replace(u.University, "(\')", "");
                        u.University = Regex.Replace(u.University, "(\")", "");
                        u.University = Regex.Replace(u.University, "(-)", "");

                        //Validation Part Faculty
                        u.Faculty = Sanitizer.GetSafeHtmlFragment(u.Faculty);
                        u.Faculty = u.Faculty.ToString().Replace("\\", "");
                        u.Faculty = u.Faculty.ToString().Replace("%", "");
                        u.Faculty = Regex.Replace(u.Faculty, "(\')", "");
                        u.Faculty = Regex.Replace(u.Faculty, "(\")", "");
                        u.Faculty = Regex.Replace(u.Faculty, "(-)", "");


                        //Validation Part Case
                        u.PositionVal = Sanitizer.GetSafeHtmlFragment(u.PositionVal);
                        u.PositionVal = u.PositionVal.ToString().Replace("\\", "");
                        u.PositionVal = u.PositionVal.ToString().Replace("%", "");
                        u.PositionVal = Regex.Replace(u.PositionVal, "(\')", "");
                        u.PositionVal = Regex.Replace(u.PositionVal, "(\")", "");
                        u.PositionVal = Regex.Replace(u.PositionVal, "(-)", "");

                        var checkNID = ucheck.Exists(x => x.NID == u.NID);
                        var checkUName = ucheck.Exists(x => x.Uname == u.Uname);
                        var checkEmail = ucheck.Exists(x => x.Email == u.Email);

                        if (checkNID)
                        {
                            Message = "NationID is Exist";
                            ViewBag.MessageNID = Message;
                            return View(u);
                        }
                        if (checkUName)
                        {
                            Message = "UserName is Exist";
                            ViewBag.MessageUname = Message;
                            return View(u);
                        }
                        if (checkEmail)
                        {
                            Message = "Email is Exists";
                            ViewBag.MessageEmail = Message;
                            return View(u);

                        }

                    }


                    #endregion  Validation Part
                }

                UserInfoBL.Insert(u);

                return RedirectToAction("LogIn");
            }

            else
            {
                return View(u);
            }

        }

        #endregion
        #region LogOut
        public ActionResult LogOut()
        {
            Session.Clear();
            return RedirectToAction("LogIn");
        }
        #endregion 
        #region LogIn
        [HttpGet]
        public ActionResult LogIn()
        {
            if (Session["UserId"] != null)
            {
                return RedirectToAction($"CourseDescription");
            }

            return View();
        }



        //This part used to refresh the Notification
        public void refreshNotification()
        {
            if (Session["UserId"] != null)
            {
                long NID = long.Parse(Session["UserId"].ToString());
                List<Wait> w = WaitBL.sendNotification(NID);
                Session["NotificationCount"] = w.Count;
                Session["NotificationContent"] = w;

            }
            RedirectToAction("Login");

           
        }


        public ActionResult GetMessages()
        {
            //
           // long NID = long.Parse(Session["UserID"].ToString());
            MessagesRepository _messageRepository = new MessagesRepository();
            //  PartialView("_MessagesCount", _messageRepository.GetAllMessages());
            // test();
            _messageRepository.GetAllMessages();
            return RedirectToAction("test");
            //return PartialView("_MessagesList", _messageRepository.GetAllNotification(NID));

        }

        public JsonResult getMessageContent(string id)
        {
            long NID = long.Parse(Session["UserID"].ToString());

            List<Wait> userWaited = new List<Wait>();
            userWaited = WaitBL.sendNotification(NID);
            return Json(userWaited, JsonRequestBehavior.AllowGet);
        }


        public ActionResult test()
        {
            //
            long NID = long.Parse(Session["UserID"].ToString());
            MessagesRepository _messageRepository = new MessagesRepository();
            //return PartialView("_MessagesList", _messageRepository.GetAllMessages());
            return PartialView("_MessagesList", _messageRepository.GetAllNotification(NID));
        }



        //End of refresh the Notification
        [HttpPost]
        public ActionResult LogIn(Login lg)
        {
            {
                //Validation Part UserName
                lg.UNAME = Sanitizer.GetSafeHtmlFragment(lg.UNAME);
                lg.UNAME = lg.UNAME.ToString().Replace("\\", "");
                lg.UNAME = lg.UNAME.ToString().Replace("%", "");
                lg.UNAME = Regex.Replace(lg.UNAME, "(\')", "");
                lg.UNAME = Regex.Replace(lg.UNAME, "(\")", "");
                lg.UNAME = Regex.Replace(lg.UNAME, "(-)", "");


                //Validation Part PWD

                lg.PWD = Sanitizer.GetSafeHtmlFragment(lg.PWD);
                lg.PWD = lg.PWD.ToString().Replace("\\", "");
                lg.PWD = lg.PWD.ToString().Replace("%", "");
                lg.PWD = Regex.Replace(lg.PWD, "(\')", "");
                lg.PWD = Regex.Replace(lg.PWD, "(\")", "");
                lg.PWD = Regex.Replace(lg.PWD, "(-)", "");
            }



            if (ModelState.IsValid)
            {
                UserInfo u = new UserInfo();

                if (UserInfoBL.CheckExistentUser(lg.UNAME, lg.PWD, u))
                {
                    ViewBag.UserId = u.NID;
                    Session["UserName"] = u.Ename;
                    Session["UserId"] = u.NID;

                    //Notification Part
                    refreshNotification();

                    if (u.AuthId == 301)
                        return RedirectToAction($"userManagement");

                    return RedirectToAction($"CourseDescription");
                }

                ViewBag.ErrorMessage = " Wrong UserName or Password";

            }
            return View();
        }
        #endregion  
        #region CourseDescription


        [ValidateInput(false)]
        public ActionResult CourseDescription(int startingColm = 0, string search = "")
        {

            //Notification Part
            refreshNotification();

            // Validation Part

            search = Sanitizer.GetSafeHtmlFragment(search);
            search = search.ToString().Replace("\\", "");
            search = search.ToString().Replace("%", "");
            search = Regex.Replace(search, "(\')", "");
            search = Regex.Replace(search, "(\")", "");
            search = Regex.Replace(search, "(-)", "");



            // use this ViewBag in Pagination
            ViewBag.search = search;

            if (Session["UserId"] == null)
            {
                return RedirectToAction("LogIn");
            }
            else
            {
                int RowAmount = 6;

                ViewBag.RowCount = Math.Ceiling((CourseBL.RowCount(search)) / RowAmount);
                ViewBag.ActivePage = ((startingColm + 1) / RowAmount) + 1;
                ViewBag.srtColumn = startingColm;


                ViewBag.UserId = Session["UserId"];
                return View(CourseBL.DisplayAll(startingColm, RowAmount, search));
            }
        }




        #endregion


        #region Courses

        [HttpGet]
        public ActionResult Course()
        {
          int  startingCReg = startingColmnReg;
          int startingCHist = startingColmnHist;

            #region switching between tabs
            {
                if (regTab)
                {
                    ViewBag.RegTabActive = "active";
                    ViewBag.RegTabShowActive = "show active";

                    ViewBag.HistTabActive = "";
                    ViewBag.HistTabShowActive = "";

                    ViewBag.ROFTabActive = "";
                    ViewBag.ROFTabShowActive = "";

                    ViewBag.Histsearch = "";
                    ViewBag.search = searchReg;
                }
                else if (HistTab)
                {

                    ViewBag.RegTabActive = "";
                    ViewBag.RegTabShowActive = "";

                    ViewBag.HistTabActive = "active";
                    ViewBag.HistTabShowActive = "show active";

                    ViewBag.ROFTabActive = "";
                    ViewBag.ROFTabShowActive = "";

                    ViewBag.Histsearch = searchHist;
                    ViewBag.search = "";

                }
                else if (ROFTab)
                {

                    ViewBag.RegTabActive = "";
                    ViewBag.RegTabShowActive = "";

                    ViewBag.HistTabActive = "";
                    ViewBag.HistTabShowActive = "";

                    ViewBag.ROFTabActive = "active";
                    ViewBag.ROFTabShowActive = "show active";

                    ViewBag.Histsearch = "";
                    ViewBag.search = "";

                }


            }
            #endregion
                
          
            //Notification Part
            refreshNotification();

            if (Session["UserId"] == null)
            {
                return RedirectToAction("LogIn");
            }
            else
            {
                ViewBag.UserId = Session["UserId"];
                long id = ViewBag.UserId;

                

                rpc = new  List<ReplacementCert>();
                rpc = CourseBL.replacOfLost(id);
                ViewBag.ReplacementCert = rpc;
                   





                //History Tab Part
                {

                    #region pagination History
                    //Pagination For Registeration Part
                    int RowAmountHist = 6;
                    ViewBag.RowCountH = Math.Ceiling((CourseBL.selectHistoryWithPaginCount(id, searchHist)) / RowAmountHist);
                    ViewBag.ActivePageH = ((startingCHist + 1) / RowAmountHist) + 1;
                    ViewBag.srtColumnH = startingCHist;
                    #endregion end_Pagination

                    ViewBag.History = CourseBL.DisplayHistory(id,startingColmnHist,RowAmountHist,searchHist);
                }

               

                //getCourseNotConfirmed
                ViewBag.getCourseNotConfirmed = CourseBL.getCourseNotConfirmed(id);
                ViewBag.HistoryToPrevent = CourseBL.DisplayHistoryToPrevent(id);

                //getCompleted Course_With_BillNumber_Confirmed
                ViewBag.getCompletedCourse_With_BN_Confirmed = CourseBL.getCompletedCourse_With_BN_Confirmed();

                //getCompleted Course_Without_BillNumber_
                ViewBag.getCompletedCourse_WithOut_BN = CourseBL.getCompletedCourse_WithOut_BN();


                #region Static Variables used to validated the Course Registeration Process
                {

                    getCompletedCourse_WithOut_BN = ViewBag.getCompletedCourse_WithOut_BN;
                    getCompletedCourse_With_BN_Confirmed = ViewBag.getCompletedCourse_With_BN_Confirmed;
                    getCourseNotConfirmed = ViewBag.getCourseNotConfirmed;
                    Historyvar = ViewBag.History;
                }
                #endregion end of static Vairiables


                #region pagination Registeration
                //Pagination For Registeration Part
                int RowAmount = 6;
                ViewBag.RowCountR = Math.Ceiling((CourseBL.getRowsCountInSpecificPosition(id, searchReg)) / RowAmount);
                ViewBag.ActivePageR = ((startingCReg + 1) / RowAmount) + 1;
                ViewBag.srtColumnR = startingCReg;
                #endregion end_Pagination

                
                return View(CourseBL.GetAll(id, startingCReg, RowAmount, searchReg));
            }
        }

        public ActionResult CourseRegTab(int startingColmn=0 , string search = "")
        {

            #region Validation Part
            search = Sanitizer.GetSafeHtmlFragment(search);
            search = search.ToString().Replace("\\", "");
            search = search.ToString().Replace("%", "");
            search = Regex.Replace(search, "(\')", "");
            search = Regex.Replace(search, "(\")", "");
            search = Regex.Replace(search, "(-)", "");
            #endregion


            regTab = true;
            HistTab = false;
            ROFTab = false;
            startingColmnReg = startingColmn;
            startingColmnHist = 0;
            searchReg = search;
            searchHist = "";

            return RedirectToAction($"Course");
        }
        public ActionResult CourseHistTab(int startingColmn = 0, string search = "")
        {


            #region Validation Part
            search = Sanitizer.GetSafeHtmlFragment(search);
            search = search.ToString().Replace("\\", "");
            search = search.ToString().Replace("%", "");
            search = Regex.Replace(search, "(\')", "");
            search = Regex.Replace(search, "(\")", "");
            search = Regex.Replace(search, "(-)", "");
            #endregion

            regTab = false;
            HistTab = true;
            ROFTab = false;
            startingColmnReg = 0;
            startingColmnHist = startingColmn;
            searchReg = "";
            searchHist = search;

            return RedirectToAction($"Course");
        }
        public ActionResult CourseROFTab(int cid=-1)
        {
            regTab = false;
            HistTab = false;
            ROFTab = true;
            startingColmnReg = 0;
            startingColmnHist = 0;
            searchReg ="" ;
            searchHist = "";
            long NID = long.Parse(Session["UserId"].ToString());

            if (rpc.Exists(x => x.Cid == cid))
            {
                if (CourseBL.checkIfROFNotSubmitted(NID, cid).Exists(x => x.Submit == 0))
                {
                    //this part means that he already asked for the request and he want to print the Bill again
                   
                    return RedirectToAction($"reportPrintROF/{cid}");


                }
                else
                {
                    //this part means that he asking for a  request  to get ROF
                    CourseBL.addROFRequest(NID, cid);
                    return RedirectToAction($"reportPrintROF/{cid}");

                }

            }
            else
            {
                ViewBag.InvalidCourseName = "هذا الكورس غير متاح ";
            }

            

            return RedirectToAction($"Course");
        }



        #region Static Varibles for Switching Between Tabs in Course Page

        static bool regTab = true;
        static bool HistTab = false;
        static bool ROFTab = false;
        
        static int startingColmnReg = 0;
        static int startingColmnHist = 0;
        static string searchReg = "";
        static string searchHist = "";

        static List<ReplacementCert> rpc;

        #endregion end of  Static Varibles


        // this Action tell the user that the course is Complete
        public ActionResult CourseHaveCompleted(int id = -1)
        {
            //Notification Part
            refreshNotification();
            if(!(getCompletedCourse_WithOut_BN.Exists(ww=>ww.CID==id)))
            {
                return RedirectToAction("Course"); // it should be ERROR404

            }
            if (id == -1)
            {
                return RedirectToAction("Course");// it should be ERROR404
            }
            int cid = id;

            Course crs = CourseBL.getCourseById(cid);

            Session["CourseId"] = crs.CID;
            Session["DatesofCourse"] = crs.Sdate + " - " + crs.Edate;
            long nid = long.Parse(Session["UserId"].ToString());

            string dates = Session["DatesofCourse"].ToString();


            ViewBag.flag = WaitBL.getWaitedList(nid, cid, dates);

            return View(crs);
        }

        [HttpPost]
        public ActionResult CourseHaveCompleted()
        {
            //Notification Part
            refreshNotification();

            if (Session["UserId"] == null)
            {
                return RedirectToAction("Course");

            }
            int cid = int.Parse(Session["CourseId"].ToString());
            string dates = Session["DatesofCourse"].ToString();
            long nid = long.Parse(Session["UserId"].ToString());

            WaitBL.InsertToCrsPos(nid, cid, dates);

            return RedirectToAction("Course");
        }

        public ActionResult CourseCancel(int cid=-1)
        {
            //Notification Part
            refreshNotification();

            if (Session["UserId"] == null)
            {
                return RedirectToAction("LogIn");
            }
            else
            {
                ViewBag.UserId = Session["UserId"];
                long id = ViewBag.UserId;

                CourseBL.CourseCancel(id, cid);
                return RedirectToAction("Course");
            }
        }




        #endregion

        static List<Course> getCompletedCourse_WithOut_BN,
                      getCompletedCourse_With_BN_Confirmed,
                      getCourseNotConfirmed;
        static List<History> Historyvar;

        #region  CourseRegiseration For User History 1 Args
        [HttpGet]
        public ActionResult CourseRegister(int id=-1)
        {
            //ValidationPart
            {

                var getHistory = (List<History>)Historyvar;

                bool flag = false;

                //this part to check if the url--> CourseID is valid or not 
                if(!(CourseBL.selectAllCourses().Exists(xx=>xx.CID==id)))
                    return RedirectToAction("Course");
                

                    foreach (var val in getHistory)
                {
                    if (id == val.Cid)
                    {
                        flag = true;
                        break;
                    }

                }
                if (flag)
                {
                    return RedirectToAction("Course");

                }


                // This Part to tell the user that his course didn't confirmed yet
                // and if he want to cancel or to print the bill agian

                var _getCourseNotConfirmed = (List<Course>)getCourseNotConfirmed;

                bool nflag = false;
                foreach (var val in _getCourseNotConfirmed)
                {
                    if (id == val.CID)
                    {
                        nflag = true;
                        break;
                    }

                }
                if (nflag)
                {
                    return RedirectToAction("Course");



                }


                //This Part is to get Courses that have Full Capacity
                //with Courses Confirmed

                var _getCompletedCourse_With_BN_Confirmed = (List<Course>)getCompletedCourse_With_BN_Confirmed;
                bool nflag2 = false;
                foreach (var val in _getCompletedCourse_With_BN_Confirmed)
                {
                    if (id == val.CID)
                    {
                        nflag2 = true;
                        break;
                    }

                }
                if (nflag2 && nflag == false && flag == false)
                {

                    return RedirectToAction("Course");
                }



                //This Part is to get Courses that have Full Capacity 
                //Without Courses Confirmed
                var _getCompletedCourse_WithOut_BN = (List<Course>)getCompletedCourse_WithOut_BN;

                bool nflag3 = false;
                foreach (var val in _getCompletedCourse_WithOut_BN)
                {
                    if (id == val.CID)
                    {
                        nflag3 = true;
                        break;
                    }

                }
                if (nflag3 && nflag2 == false && nflag == false && flag == false)
                {
                    return RedirectToAction($"CourseHaveCompleted/{id}");

                }

            }

            // End Validation Part


            //Notification Part
            refreshNotification();

            ViewBag.Degree = CourseBL.selectDegree(int.Parse(Session["UserId"].ToString()));
            ViewBag.States = CourseBL.selectState(int.Parse(Session["UserId"].ToString()));
            ViewBag.CourseName = CourseBL.selectTitle(id).Title;
            Session["CID"] = id;

            return View();
        }




      



        [HttpPost]
        //  CourseRegiseration For User History 0 Args
        public ActionResult CourseRegister()
        {
            //Notification Part
            refreshNotification();

            Course c = new Course();

            long Nid = long.Parse(Session["UserId"].ToString());
            int Cid = int.Parse(Session["CourseId"].ToString());
            c = CourseBL.selectSpecificCourse(Cid);
            string Dates = $"{c.Sdate} - {c.Edate}";
            string Times = $"{c.Stime} - {c.Etime}";
            int StateId = int.Parse(Session["StateOfUser"].ToString());
            int DegID = int.Parse(Session["DegreeOfUser"].ToString());
            Register r = new Register { NID = Nid, CID = Cid, Date = Dates, Times = Times, StateId = StateId, DegId = DegID };

            CourseBL.InsertToCourseRegister(r);

            return RedirectToAction($"reportPrint/{Cid}");
        }
        #endregion


        #region  Course Price
        [HttpPost]
        public ActionResult CoursePrice(int id, int DegreeOfUser = 0, int StateOfUser = 0)
        {
            //Notification Part
            refreshNotification();

            Session["CourseId"] = id;
            Session["DegreeOfUser"] = DegreeOfUser;
            Session["StateOfUser"] = StateOfUser;


            ViewBag.CourseName = CourseBL.selectTitle(id).Title;
            Session["CourseName"] = ViewBag.CourseName;
            Session["AName"] = UserInfoBL.getArabicName(int.Parse(Session["UserId"].ToString()));

            ViewBag.PriceValue = CourseBL.selectPrice(int.Parse(Session["UserId"].ToString()), StateOfUser, DegreeOfUser).Value.ToString();
            Session["PriceValue"] = ViewBag.PriceValue;
            return View(CourseBL.selectSpecificCourse(id));
           
        }
        #endregion

        #region Report Print
        public ActionResult reportPrint(int id=-1)
        {

            //Notification Part
            refreshNotification();

            int cid = id;
            long Nid = long.Parse(Session["UserId"].ToString());
            if ( CourseBL.getCourseNotConfirmed(Nid).Exists(x => x.CID == cid)) { 
            

            ViewBag.getBillData = WaslBL.getBillData(Nid, cid);

            return View();
            }else
            {
                return RedirectToAction($"course");
            }
        }


        public ActionResult reportPrintROF(int id=-1)
        {

            //Notification Part
            refreshNotification();
            int cid = id;
            long Nid = long.Parse(Session["UserId"].ToString());
          
            if (rpc.Exists(x => x.Cid == cid))
            {
                if (CourseBL.checkIfROFNotSubmitted(Nid, cid).Exists(x => x.Submit == 0))
                {
                    //this part means that he already asked for the request and he want to print the Bill again
                    Wasl wasl = new Wasl();
                    wasl = WaslBL.getData4ROFCertificate(Nid, cid);

                    ViewBag.getBillData = wasl;

                    Session["PriceValue"] = wasl.Price;
                    Session["CourseName"] = wasl.CourseName;
                    Session["AName"] = wasl.Aname;

                    return View();
                }
                else
                {
                    //this part means that he asking for a  request  to get ROF
                    CourseBL.addROFRequest(Nid, cid);
                    Wasl wasl = new Wasl();
                    wasl = WaslBL.getData4ROFCertificate(Nid, cid);

                    ViewBag.getBillData = wasl;

                    Session["PriceValue"] = wasl.Price;
                    Session["CourseName"] = wasl.CourseName;
                    Session["AName"] = wasl.Aname;

                    return View();
                }

            }
            else
            {
                ViewBag.InvalidCourseName = "هذا الكورس غير متاح ";
                return RedirectToAction($"Course");
            }

         

          //  return View();
        }

        #region Reports Part
        public ActionResult Report()
        {
            //Print The Bill
            //Notification Part
            refreshNotification();

            LocalReport localRpt = new LocalReport();
            localRpt.ReportPath = Server.MapPath("~/Reports/Report1.rdlc");
            //ReportDataSource rds = new ReportDataSource();
            //rds.Name = "";
            //Session["AName"] = UserInfoBL.getArabicName(int.Parse(Session["UserId"].ToString()));
            ReportParameter[] parameters = new ReportParameter[]
            {
                new ReportParameter("CrsPrice",Session["PriceValue"].ToString()),
                 new ReportParameter("CrsName",Session["CourseName"].ToString()),
                  new ReportParameter("UserName",Session["AName"].ToString())
        };

            localRpt.SetParameters(parameters);
            //localRpt.DataSources.Add(rds);
            string mimeType;
            string enconding;
            string fileNameExtension = "pdf";

            string[] streams;
            Warning[] warning;
            byte[] renderedByte;
            renderedByte = localRpt.Render("PDF", "", out mimeType, out enconding, out fileNameExtension
                , out streams, out warning);
            Response.AddHeader("content-disposition", "attachment;filename=wasl.pdf");
            return File(renderedByte, fileNameExtension);
            //End of Printing
        }


        public ActionResult ReportROF()
        {
            //Print The Bill
            //Notification Part
            refreshNotification();

            LocalReport localRpt = new LocalReport();
            localRpt.ReportPath = Server.MapPath("~/Reports/ReportROF.rdlc");
            //ReportDataSource rds = new ReportDataSource();
            //rds.Name = "";
            //Session["AName"] = UserInfoBL.getArabicName(int.Parse(Session["UserId"].ToString()));
            ReportParameter[] parameters = new ReportParameter[]
            {
                new ReportParameter("CrsPrice",Session["PriceValue"].ToString()),
                 new ReportParameter("CrsName",Session["CourseName"].ToString()),
                  new ReportParameter("UserName",Session["AName"].ToString())
        };

            localRpt.SetParameters(parameters);
            //localRpt.DataSources.Add(rds);
            string mimeType;
            string enconding;
            string fileNameExtension = "pdf";

            string[] streams;
            Warning[] warning;
            byte[] renderedByte;
            renderedByte = localRpt.Render("PDF", "", out mimeType, out enconding, out fileNameExtension
                , out streams, out warning);
            Response.AddHeader("content-disposition", "attachment;filename=wasl.pdf");
            return File(renderedByte, fileNameExtension);
            //End of Printing
        }



        #endregion

        #endregion

        #region updateUserInfo


        [HttpGet]
        public ActionResult update()
        {
            //Notification Part
            refreshNotification();
            return View(UserInfoBL.getUserDataById(int.Parse(Session["UserId"].ToString())));
        }
        [HttpPost]
        public ActionResult update(UserInfo u)
        {
            u.PosId = UserInfoBL.getPositionId(u.PositionVal);

            UserInfoBL.UpdateProfile(u);



            return View(u);

        }


        #endregion

        #endregion // End User Part


        #region Admin Part


        #region addCourse
        [HttpGet]
        public ActionResult addCrs()
        {
            posList cpl = new posList();
            cpl.pList = PositionBL.selectAllPosition();
            return View(cpl);
        }



        [HttpPost]
        public ActionResult addCrs(posList cpl, Course c, HttpPostedFileBase file)
        {
            var path = "";
            string ImageName = "";

            #region Image part
            //for checking uploaded
            if (file != null && (Path.GetExtension(file.FileName).ToLower() == ".jpg"
                   || Path.GetExtension(file.FileName).ToLower() == ".png"
                    || Path.GetExtension(file.FileName).ToLower() == ".gif"
                     || Path.GetExtension(file.FileName).ToLower() == ".jpeg"))
            {

                ImageName = file.FileName;
                path = Path.Combine(Server.MapPath("~/Images/"), file.FileName);
                c.Img = file.FileName;
                file.SaveAs(path);

                ViewBag.UploadSuccess = true;
            }


            #endregion

            //Insert Values
            CourseBL.InsertToCrs(c);
            //get Course Id using Course Title           
            int courseId = CourseBL.selectCoursIdusingTitle(c.Title).CID;

            #region Adding the Positon to the Course
            Course_To_Position ctp = new Course_To_Position();
            ctp.CID = courseId;
            for (int i = 0; i < cpl.pList.Count; i++)
            {
                if (cpl.pList[i].IsChecked)
                {
                    ctp.PosId = cpl.pList[i].PosId;
                    CourseBL.InsertToCrsPos(ctp);
                }
            }
            #endregion

            return RedirectToAction($"addCrs");
        }

        #endregion

        #region editCrs

        #region Get Part
        [HttpGet]
        public ActionResult editCrs(int id)
        {

            posList pl = new posList();
            pl.pList = PositionBL.selectAllPosition();
            crpList coursepositionList = new crpList();
            coursepositionList.coursePositionList = Course_To_PositionBL.selectAllPositionOfCourse(id);

            for (int i = 0; i < coursepositionList.coursePositionList.Count; i++)
            {
                for (int j = 0; j < pl.pList.Count; j++)
                {
                    if (coursepositionList.coursePositionList[i].PosId == pl.pList[j].PosId)
                        pl.pList[j].IsChecked = true;

                }
            }

            ViewBag.Model = CourseBL.getCourseById(id);
            return View(pl);

        }
        #endregion

        #region Post Part
        [HttpPost]
        public ActionResult editCrs(posList cpl, Course c, HttpPostedFileBase file)
        {
            

            //for checking uploaded
            if (file != null && (Path.GetExtension(file.FileName).ToLower() == ".jpg"
                   || Path.GetExtension(file.FileName).ToLower() == ".png"
                    || Path.GetExtension(file.FileName).ToLower() == ".gif"
                     || Path.GetExtension(file.FileName).ToLower() == ".jpeg"))
            {




                // Specify the path to save the uploaded file to.
                string savePath = Server.MapPath("~/Images/");

                // Get the name of the file to upload.
                string fileName = file.FileName;

                // Create the path and file name to check for duplicates.
                string pathToCheck = savePath + fileName;

                // Create a temporary file name to use for checking duplicates.
                string tempfileName = "";

                // Check to see if a file already exists with the
                // same name as the file to upload.        
                if (System.IO.File.Exists(pathToCheck))
                {
                    int counter = 2;
                    while (System.IO.File.Exists(pathToCheck))
                    {
                        // if a file with this name already exists,
                        // prefix the filename with a number.
                        tempfileName = counter.ToString() + fileName;
                        pathToCheck = savePath + tempfileName;
                        counter++;
                    }
                    fileName = tempfileName;
                    // c.Img = tempfileName;


                }

                c.Img = fileName;
                savePath += fileName;
                file.SaveAs(savePath);

                ViewBag.UploadSuccess = true;

            }
            CourseBL.UpdateCourse(c);

            CourseBL.DeleteCourse_to_Position(c.CID);

            #region Adding the Positon to the Course
            Course_To_Position ctp = new Course_To_Position();
            ctp.CID = c.CID;
            for (int i = 0; i < cpl.pList.Count; i++)
            {
                if (cpl.pList[i].IsChecked)
                {
                    ctp.PosId = cpl.pList[i].PosId;
                    CourseBL.InsertToCrsPos(ctp);
                }
            }
            #endregion

            return RedirectToAction("CourseManagement");

        }
        #endregion

        #endregion

        #region Course Confirmation
        public ActionResult CourseConfirmation(int id = -1)
        {

            ViewBag.SelectCourseNotConfirmed = CourseBL.SelectCourseNotConfirmed();
            ViewBag.SelectCourseIsConfirmed = CourseBL.SelectCourseIsConfirmed();
            if (Session["ViewBagDates"] != null)
                ViewBag.DatesOfConfirmedCourse = Session["ViewBagDates"];
            if (selectedTab)
            {
                ViewBag.FTabActive = "";
                ViewBag.FTShow = "";
                ViewBag.STabActive = "active";
                ViewBag.STShow = "show";
                ViewBag.SelectedItemSTab = id;
                ViewBag.selectedDateSTab = selectedDate;
                if (selectedDate.Length > 0)
                    ViewBag.getDataofUsers4ConfirmedCourse = CourseBL.getDataofUsers4ConfirmedCourse(id, selectedDate);
            }
            else
            {
                ViewBag.STabActive = "";
                ViewBag.STShow = "";
                ViewBag.FTabActive = "active";
                ViewBag.FTShow = "show";
                ViewBag.SelectedItemFTab = id;
            }

            Session.Remove("ViewBagDates");
            selectedTab = false;
            selectedDate = "";

            return View(CourseBL.SelectUserToConfirm(id));
        }
        #endregion


        #region billNumber of The Course Edit/Delete
        [HttpPost]
        public ActionResult manageBillNumber(string action, long BillNumber=-400,long NID=-400)
        {

            return RedirectToAction("CourseConfirmation");
        }

        //[HttpPost]
        //public ActionResult manageBillNumber(string action)
        //{

        //    return RedirectToAction("CourseConfirmation");
        //}

        #endregion

        #region InsertBillNumber
        [HttpGet]
        public ActionResult insertBillNumber(Register r)

        {

            CourseBL.UpdateBillNumber(r);
            return RedirectToAction("CourseConfirmation");
        }
        #endregion


        #endregion

        #region userManagement

        [HttpGet]
        public ActionResult userManagement()
        {

            return View(UserInfoBL.getAllUser());
        }

        public ActionResult makeAdmin(int id, int authId)
        {

            UserInfoBL.MakeAdmin(id, authId);
            return RedirectToAction("userManagement");
        }

        public ActionResult deActiveUser(int id, int Active)
        {
            UserInfoBL.DeactiveUser(id, Active);

            return RedirectToAction("userManagement");
        }

        public ActionResult makeInst(int id = -1)
        {
           
            CourseList crsList = new CourseList();
            crsList.crsList = CourseBL.selectAllCourses();

            return View(crsList);
        }

        public ActionResult CourseManagement(int id = -1)
        {
            ViewBag.PositionList = PositionBL.selectAllPosition();
            ViewBag.SelectedItemDDL = id;
            return View(CourseBL.SpecificCourseUnderPosition(id));
        }

        public ActionResult CourseDeActive(int cid, int posId, int active)
        {
            CourseBL.Deactive(cid, active);
            return RedirectToAction($"CourseManagement/{posId}");
        }


        // Get the Dates of  Confirmed COurses
        static int crsID=-1;
        static bool selectedTab = false;
        static string selectedDate = "";
        public ActionResult getConfirmedDates(int id, string ldate = "")
        {
            crsID = id;
            selectedTab = true;
            selectedDate = ldate;
            Session["ViewBagDates"] = CourseBL.getConfirmedDates(id);
            //  return RedirectToAction($"CourseConfirmation?lid={id}&ldate={ldate}");
            return RedirectToAction($"CourseConfirmation/{id}");
        }
    
        #endregion

        #region certificate
        [HttpGet]
        public ActionResult Cert(int id = -1)
        {

            //GetCoursesToCreateThe Certificates
            ViewBag.getCrsForCreate = CourseBL.get_Course_that_Not_Have_Certificate();
            //use of this ViewBag in Both History & ROF
            ViewBag.getCrsForHistory = CourseBL.GetAllCoursesForCertHistory();


            // Create Part
            if (Session["ViewBagDatesForCreate"] != null)
            {
                ViewBag.DatesOfConfirmedCourseCreate = Session["ViewBagDatesForCreate"];
                ViewBag.DatesOfConfirmedCourseHistory = null;
                ViewBag.DatesOfConfirmedCourseROF = null;
                if (CreateTab)
                {
                    Session.Remove("ViewBagDatesForHistory");
                    Session.Remove("ViewBagDatesForROF");
                }



            }

            // History Part
            if (Session["ViewBagDatesForHistory"] != null)
            {
                ViewBag.DatesOfConfirmedCourseHistory = Session["ViewBagDatesForHistory"];
                ViewBag.DatesOfConfirmedCourseCreate = null;
                ViewBag.DatesOfConfirmedCourseROF = null;
                if (HistoryTab)
                {
                    Session.Remove("ViewBagDatesForCreate");
                    Session.Remove("ViewBagDatesForROF");

                }


            }

            // ROF Part
            if (Session["ViewBagDatesForROF"] != null)
            {
                ViewBag.DatesOfConfirmedCourseROF = Session["ViewBagDatesForROF"];
                ViewBag.DatesOfConfirmedCourseCreate = null;
                ViewBag.DatesOfConfirmedCourseHistory = null;
                if (ReplacementTab)
                {
                    Session.Remove("ViewBagDatesForCreate");
                    Session.Remove("ViewBagDatesForHistory");
                }

            }



            ViewBag.SelectedItemSTab = id;
            ViewBag.selectedDateSTab = selectedDate;

            diffdataList dl = new diffdataList();




            //Tab Parts

            if (CreateTab)
            {

                ViewBag.SelectedItemFromDropDownListofCourses = "Create";

                ViewBag.HistoryTabActive = "";
                ViewBag.HistoryTShow = "";
                ViewBag.ReplaceTabActive = "";
                ViewBag.ReplaceTShow = "";
                ViewBag.CreateTabActive = "active";
                ViewBag.CreateTShow = "show";

                //generate Table for Create
                if (selectedDate.Length > 0)
                {
                    dl.dList = DiffDataBL.getDifferentData(id, selectedDate);
                    ViewBag.getDataofUsers4ConfirmedCourse = dl;
                }


            }
            else if (HistoryTab)
            {
                ViewBag.HistoryTabActive = "active";
                ViewBag.HistoryTShow = "show";
                ViewBag.CreateTabActive = "";
                ViewBag.CreateTShow = "";
                ViewBag.ReplaceTabActive = "";
                ViewBag.ReplaceTShow = "";

                ViewBag.SelectedItemFromDropDownListofCourses = "History";
                //generate Table for History
                if (selectedDate.Length > 0)
                {
                    dl.dList = DiffDataBL.getHistoryForCertificates(id, selectedDate);
                    ViewBag.getHistoryForCertificates = dl;
                }

            }
            else
            {
                ViewBag.SelectedItemFromDropDownListofCourses = "ROF";

                ViewBag.HistoryTabActive = "";
                ViewBag.HistoryTShow = "";
                ViewBag.CreateTabActive = "";
                ViewBag.CreateTShow = "";
                ViewBag.ReplaceTabActive = "active";
                ViewBag.ReplaceTShow = "show";
                //generate Table for ROF , Note :Same table as History
                if (selectedDate.Length > 0)
                {
                    dl.dList = DiffDataBL.getHistoryForCertificates(id, selectedDate);
                    ViewBag.getROF_ForCertificates = dl;
                }
            }


            selectedDate = "";
            return View(dl);
        }

        #region Golbal Variables 

        static bool CreateTab = true;

        static bool HistoryTab = false;

        static bool ReplacementTab = false;
        //  static string selectedDate = "";

        #endregion


        // Get the Dates of  Confirmed Courses For #Create Certificate
        public ActionResult getConfirmedDatesForCreate(int id, string ldate = "")
        {
            #region For Showing Tabs
            CreateTab = true;
            HistoryTab = false;
            ReplacementTab = false;
            #endregion

            selectedDate = ldate;
            Session["ViewBagDatesForCreate"] = CourseBL.getConfirmedDates(id);
            return RedirectToAction($"Cert/{id}");
        }

        // Get the Dates of  Confirmed Courses For #History Certificate
        public ActionResult getConfirmedDatesForHistory(int id, string ldate = "")
        {
            #region For Showing Tabs
            CreateTab = false;
            HistoryTab = true;
            ReplacementTab = false;
            #endregion

            selectedDate = ldate;
            Session["ViewBagDatesForHistory"] = CourseBL.GetAllDateForCertHistory(id);
            return RedirectToAction($"Cert/{id}");
        }

        // Get the Dates of  Confirmed Courses For #ROF Certificate
        public ActionResult getConfirmedDatesForROF(int id, string ldate = "")
        {
            #region For Showing Tabs
            CreateTab = false;
            HistoryTab = false;
            ReplacementTab = true;
            #endregion

            selectedDate = ldate;
            Session["ViewBagDatesForROF"] = CourseBL.GetAllDateForCertHistory(id);
            return RedirectToAction($"Cert/{id}");
        }




        // Create Orignal Cert
        [HttpPost]
        public ActionResult createCert(int cid, string date, diffdataList dl)
        {

            for (int c = 0; c < dl.dList.Count; c++)
            {
                if (dl.dList[c].IsChecked == true)
                {
                    CertificatBL.InsertToCrsPos(cid, dl.dList[c].NID, date);
                }

            }

            return RedirectToAction("Cert");

        }

        //Create ROF Cert
        [HttpGet]
        public ActionResult insertToCertificate_ROF(long NID, long BillNum, int Cid, string Dates)
        {

            CertificatBL.insertToCertificate_ROF(Cid, NID, BillNum, Dates);

            return RedirectToAction($"Cert/{Cid}");

        }


        #region historyOfCert
        [HttpGet]
        public ActionResult CertHistory(int id = -1)
        {

            ViewBag.getCrs = CourseBL.GetAll();
            if (Session["ViewBagDates"] != null)
                ViewBag.DatesOfConfirmedCourse = Session["ViewBagDates"];
            ViewBag.SelectedItemSTab = id;
            ViewBag.selectedDateSTab = selectedDate;
            if (selectedDate.Length > 0)
                ViewBag.getDataofUsers4ConfirmedCourse = DiffDataBL.getDifferentData(id, selectedDate);

            CreateTab = true;
            HistoryTab = false;
            ReplacementTab = false;


            selectedDate = "";
            return View();

        }

        #endregion
        #endregion




        #region Error 404


        static string ActionNameToRedirect = "";
        public ActionResult Error404()
        {

            return View();
        }


        #endregion


    }


}