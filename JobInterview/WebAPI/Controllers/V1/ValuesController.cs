using BLL.Interfaces;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Contracts;

namespace WebAPI.Controllers
{
    public class ValuesController : ApiController
    {
        private IJobInterviewService jobInterviewService = new JobInterviewService();

        [Route(ApiRoutes.JobInterviews.GetAll)]
        public IEnumerable<string> GetJobInterviews()
        {
            return new string[] { "jobInterview1", "jobInterview2" };
        }
        //public IHttpActionResult GetJobInterviews()
        //{
        //    return Ok(jobInterviewService.GetAllJobInterviews());
        //}

        [Route(ApiRoutes.JobInterviews.Get)]
        public string Get(int id)
        {
            return "jobInterview";
        }

        public void Post([FromBody] string value) { }

        public void Put(int id, [FromBody] string value) { }

        public void Delete(int id) { }
    }
}
