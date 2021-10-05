using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SensorDetectWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SensorDetectWebApp.Controllers
{
    public class TrechoController : Controller
    {
        // GET: TrechoController
        public ActionResult Index()
        {
            return View(Trecho.GetAll());
        }

        // GET: TrechoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TrechoController/Create
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

        // GET: TrechoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Trecho.GetAll().Where(s => s.Id.Equals(id)).FirstOrDefault());
        }

        // POST: TrechoController/Edit/5
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

        // GET: TrechoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(Trecho.GetAll().Where(s => s.Id.Equals(id)).FirstOrDefault());
        }

        // POST: TrechoController/Delete/5
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
    }
}
