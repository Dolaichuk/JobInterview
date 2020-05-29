using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.PL.Controllers
{
    public class JobInterviewController : Controller
    {
        private IJobInterviewService jobInterviewService;
        public JobInterviewController(IJobInterviewService service)
        {
            jobInterviewService = service;
        }
        public ActionResult JobInterview()
        {
            jobInterviewService.CreateJobInterview(new BLL.DTO.JobInterviewDTO { Id = 2 });
            ViewBag.JobInterview = jobInterviewService.GetJobInterview(2);
            return View();
        }
    }
}