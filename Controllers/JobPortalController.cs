using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JobPortal_Repository;
using JobPortal_Data;
namespace WebApplication1.Controllers
{
    public class JobPortalController : Controller
    {
        // GET: JobPortal
        JobSearcherRepository jobSearcherRepository;
        public JobPortalController()
        {
            jobSearcherRepository = new JobSearcherRepository();
        }
        //[ActionName("GetAll")]
        public ActionResult Index()
        {
            IEnumerable<JobSearcher> searcher = jobSearcherRepository.GetJobSearchers();

            //ViewBag.JobSearcher = searcher;
            return View("Index", searcher);
        }
        public ActionResult Index1()
        {
            IEnumerable<JobSearcher> searcher = jobSearcherRepository.GetJobSearchers();
            ViewData["JobSearcher"] = searcher;
            ViewBag.JobSearcher = searcher;
            TempData["JobSearcher"] = searcher;
            return RedirectToAction("Index2");
        }
        public ActionResult Index2()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(JobSearcher jobSearcher)
        {
            if (ModelState.IsValid)
            {
                jobSearcherRepository.Add(jobSearcher);
                TempData["Message"] = "Added";
                return RedirectToAction("Index");
            }
            return View(jobSearcher);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            JobSearcher search = jobSearcherRepository.GetJobSearchersById(id);
            return View(search);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            jobSearcherRepository.Delete(id);
            TempData["Message"] = "Deleted success";
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Update(JobSearcher job)
        {
            if (ModelState.IsValid)
            {
                jobSearcherRepository.Update(job);
                TempData["Message"] = "Updated succesfully";
                return RedirectToAction("Index");
            }
            return View("Edit", job);
        }
    }
}