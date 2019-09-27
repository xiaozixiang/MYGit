using _47WebAPI.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace _47WebAPI.Controllers
{
    [RoutePrefix("api/Student")]
    public class StudentController : ApiController
    {
        exerciseEntities dbContent = new exerciseEntities();
        [Route("GetAllStudent")]
        [HttpPost]
        public JsonResult<List<Student>>  GetAllStudent()  //放回类型也可以改成-----和JsonResult一样的结果  IHttpActionResult
        {
            
           List<Student> students= (from s in dbContent.Students
                   select s).ToList();
            return Json<List<Student>>(students);
        }

        [Route("GetStudentBySno")]
        [HttpGet]
        public JsonResult<Student> GetStudentBySno(string Sno)
        {
           Student student= dbContent.Students.Where(o => o.SId == Sno).FirstOrDefault(); 
            return Json<Student>(student);
        }

        [Route("deleteStudentBySon")]
        [HttpGet]
        public OkResult Delete(string Sno) //[FromBody]  [FromUri]
        {

            Student student = dbContent.Students.Where(o => o.SId == Sno).FirstOrDefault();
            if(student!=null)
            dbContent.Students.Remove(student);
            dbContent.SaveChanges();
            return Ok();
        }
    }
}
