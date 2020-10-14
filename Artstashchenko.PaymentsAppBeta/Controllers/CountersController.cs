using Artstashchenko.PaymentsAppBeta.Models;
using Artstashchenko.PaymentsAppBeta.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Artstashchenko.PaymentsAppBeta.Controllers
{
    public class CountersController : Controller
    {
        private readonly MongoService mongoService;

        public CountersController(MongoService mongoService)
        {
            this.mongoService = mongoService;
        }

        // GET: CountersController
        public ActionResult Index()
        {
            return View(mongoService.Get());
        }

        // GET: CountersController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CountersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CountersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Counters counters)
        {
            if (ModelState.IsValid)
            {
                mongoService.Create(counters);
                return RedirectToAction(nameof(Index));
            }

            return View(counters);
        }

        // GET: CountersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CountersController/Edit/5
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

        // GET: CountersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CountersController/Delete/5
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
