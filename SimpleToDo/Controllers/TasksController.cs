using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SimpleToDo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Task>> Get()
        {
            return new[]
            {
                new Task {Title = "Task 1", Completed = true, },
                new Task {Title = "Task 2", Completed = false,},
                new Task {Title = "Task 3", Completed = true, },
                new Task {Title = "Task 4", Completed = false,},
                new Task {Title = "Task 5", Completed = true, },
            };
        }
    }

    public class Task
    {
        public string Title { get; set; }
        public bool Completed { get; set; }
    }
}