using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestCoreApp.ViewModels.API;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TestCoreApp.Controllers.API
{
    [Route("api/tasks")]
    public class TaskController : Controller
    {
        // GET: api/values
        [HttpGet]
        public async Task<IEnumerable<TaskResponse>> Get()
        {
            List<TaskResponse> tasks = new List<TaskResponse>()
            {
                new TaskResponse
                {
                    Id = 1,
                    Name = "Task 1"
                },
                new TaskResponse
                {
                    Id = 2,
                    Name = "Task 2"
                },
                new TaskResponse
                {
                    Id = 3,
                    Name = "Task 3"
                }
            };

            await Task.Delay(0);
            return tasks;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
