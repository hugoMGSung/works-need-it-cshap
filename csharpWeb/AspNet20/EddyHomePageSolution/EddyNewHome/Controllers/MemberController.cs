using EddyNewHome.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EddyNewHome.Controllers
{
    public class MemberController : Controller
    {
        EddyNewHomeEntities db = new EddyNewHomeEntities();

        // GET: Member
        public ActionResult Entry()
        {
            Members member = new Members();
            return View(member);
        }

        [HttpPost]
        public ActionResult Entry(Members member)
        {
            member.EntryDate = DateTime.Now;

            try
            {
                db.Members.Add(member);
                db.SaveChanges();
                ViewBag.Result = "OK";
            }
            catch (Exception)
            {                
                ViewBag.Result = "FAIL";
            }

            return View(member);
        }

        [HttpGet]
        public ActionResult List()
        {
            IEnumerable<Members> list = db.Members.ToList();
            return View(list);
        }

        [HttpGet]
        public ActionResult Edit(string memberid)
        {
            Members member = db.Members.Where(m => m.MemberID == memberid).FirstOrDefault();
            return View(member);
        }

        [HttpPost]
        public ActionResult Edit(Members member)
        {
            //Members dbMember = db.Members.Where(m => m.MemberID == member.MemberID).FirstOrDefault();
            Members origin = db.Members.Find(member.MemberID);
            try
            {
                origin.MemberName = member.MemberName;
                origin.MemberPWD = member.MemberPWD;
                origin.Email = member.Email;
                origin.Telephone = member.Telephone;

                db.Entry(origin).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                ViewBag.Result = "OK";
            }
            catch (Exception)
            {
                ViewBag.Result = "FAIL";
            }

            return View(origin);
        }

        [HttpGet]
        public ActionResult Delete(string memberid)
        {
            Members member = db.Members.Find(memberid);
            db.Members.Remove(member);
            db.SaveChanges();

            return RedirectToAction("List");
        }

        /// <summary>
        /// Ajax 중복체크 메서드
        /// </summary>
        /// <param name="memberid"></param>
        /// <returns></returns>
        [HttpGet]
        public JsonResult IDCheck(string memberid)
        {
            string result = string.Empty;
            Members member = db.Members.Find(memberid);
            if (member == null)
                result = "OK";
            else
                result = "FAIL";

            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}