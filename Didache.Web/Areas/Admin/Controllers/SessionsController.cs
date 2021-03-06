﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Didache.Web.Areas.Admin.Controllers
{
	[AdminAndBuilder]
    public class SessionsController : Controller
    {

		private DidacheDb db = new DidacheDb();

		
		public ActionResult Index() {
			return View(Didache.Sessions.GetSessions());
		}

		public ActionResult Edit(int? id) {
			Session session = db.Sessions.SingleOrDefault(s => s.SessionID == id);
			if (session == null)
				session = new Session() { SessionID = 0, StartDate=DateTime.Now, EndDate=DateTime.Now.AddMonths(4), Program="MAST", SessionYear = DateTime.Now.Year+1, SessionCode="FA", Name = "Fall " + (DateTime.Now.Year+1).ToString() };

			return View(session);
		}

		[HttpPost]
		public ActionResult Edit(Session model) {

			if (model.SessionID > 0) {
				// EDIT MODE
				try {
					model = db.Sessions.Find(model.SessionID);

					UpdateModel(model);

					db.SaveChanges();

					//return RedirectToAction("Sessions", new { id = model.ID });
					return RedirectToAction("Index");
				} catch (Exception) {
					ModelState.AddModelError("", "Edit Failure, see inner exception");
				}

				return View(model);
			} else {

				// ADD MODE
				if (ModelState.IsValid) {
					db.Sessions.Add(model);
					db.SaveChanges();
					return RedirectToAction("Index");
				} else {
					return View(model);
				}
			}

		}

		[HttpPost]
		public RedirectToRouteResult Delete(int id, FormCollection collection) {
			Session session = db.Sessions.Find(id);
			db.Sessions.Remove(session);
			db.SaveChanges();

			return RedirectToAction("Sessions");
		}

    }
}
