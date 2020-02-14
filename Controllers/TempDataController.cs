using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JobPortal_Data;
using JobPortal_Repository;
namespace WebApplication1.Controllers
{
    public class TempDataController : Controller
    {
        JobSearcherRepository jobSearcherRepository;
        public TempDataController()
        {
            jobSearcherRepository = new JobSearcherRepository();
        }
        // GET: TempData
        public ActionResult Index2()
        {
            IEnumerable<JobSearcher> searcher = jobSearcherRepository.GetJobSearchers();
            TempData["JobSearcher"] = searcher ;
            return View("ModelView",searcher);
        }
        public ActionResult Index1()
        {

            return View();
        }
    }
}