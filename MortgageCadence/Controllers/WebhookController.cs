﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MortgageCadenceWebhook.Controllers
{
    public class WebhookController : Controller
    {
        // GET: WebhookController
        public ActionResult Index()
        {
            return View();
        }

        // GET: WebhookController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WebhookController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WebhookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: WebhookController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WebhookController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: WebhookController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WebhookController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public async Task<IActionResult> PostWebhook()
        {
            var json = "";
            using (var inputStream = new System.IO.StreamReader(HttpContext.Request.Body))
            {
                json = await inputStream.ReadToEndAsync();
            }
            return Json(new { message = "success!" });
        }
    }
}
