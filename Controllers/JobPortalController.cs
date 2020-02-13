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
            ViewBag.JobSearcher = searcher;
            return View();
        }
        public ActionResult Index1()
        {
            IEnumerable<JobSearcher> searcher = jobSearcherRepository.GetJobSearchers();
            ViewData["JobSearcher"] = searcher;
            return View();
        }
        public ActionResult Index2()
        {
            IEnumerable<JobSearcher> searcher = jobSearcherRepository.GetJobSearchers();
            TempData["JobSearcher"] = searcher;
            return View();
            //  return RedirectToAction("TempData","Index1");           
        }
    }
}