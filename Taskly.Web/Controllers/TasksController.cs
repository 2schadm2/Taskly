using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Taskly.Shared.Models;
using Taskly.Shared.Services;

namespace Taskly.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ITasksService tasksService;

        public TasksController(ITasksService tasksService)
        {
            this.tasksService = tasksService;
        }
        [HttpGet]
        [Route("gtl")]
        public async Task<ResultResponse<List<Tasks>>>GetTaskList()
        {
            try
            {
                var result = await tasksService.GetTasksAsync();
                return result;
                
            }
            catch (Exception)
            {
                var response = new ResultResponse<List<Tasks>>()
                {
                    ResponseStatusCode = HttpStatusCode.NotFound,
                    Errors = new List<string>() { "Internal Server error" }
                };

                return response;
            }  
        }
        [HttpGet]
        [Route("gst")]
        public async Task<ResultResponse<Tasks>> GetSingleTask()
        {
            try
            {
                var response = await tasksService.GetSingleTaskAsync();
                return response;
            }
            catch (Exception)
            {
                var response = new ResultResponse<Tasks>()
                {
                    ResponseStatusCode = HttpStatusCode.BadRequest,
                    Errors = new List<string>() { "Internal Server error" }
                };
                return response;
            }
            
        }
    }
}
