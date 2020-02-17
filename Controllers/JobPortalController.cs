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
      
        public ActionResult Index()
        {
            IEnumerable<JobSearcher> searcher = jobSearcherRepository.GetJobSearchers();

            //ViewBag.JobSearcher = searcher;
            return View("Index", searcher);
        }

        [HttpGet]
        [ActionName("Create")]
        public ActionResult Create_Get()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create_Post()
        {
            if (ModelState.IsValid)
            {
                JobSearcher jobSearcher = new JobSearcher();
                UpdateModel<JobSearcher>(jobSearcher);
                jobSearcherRepository.Add(jobSearcher);
                TempData["Message"] = "Added successfully";
                return RedirectToAction("Index");
            }
            return View();
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
        public ActionResult Update()    
        {
            JobSearcher job = new JobSearcher();
            if (ModelState.IsValid)
            {
                
                TryUpdateModel<JobSearcher>(job);
                jobSearcherRepository.Update(job);
                TempData["Message"] = "Updated succesfully";
                return RedirectToAction("Index");
            }
            return View("Edit", job);
        }
    }
}        //public ActionResult Index1()
         //{
         //    IEnumerable<JobSearcher> searcher = jobSearcherRepository.GetJobSearchers();
         //    ViewData["JobSearcher"] = searcher;
         //    ViewBag.JobSearcher = searcher;
         //    TempData["JobSearcher"] = searcher;
         //    return RedirectToAction("Index2");
         //}        //public ActionResult Index2()
         //{
         //    return View();
         //}
         //public ActionResult Index2()
         //{
         //    return View();
         //}