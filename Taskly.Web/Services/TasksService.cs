using Microsoft.AspNetCore.Server.HttpSys;
using Microsoft.EntityFrameworkCore;
using System.Net;
using Taskly.Shared.Models;
using Taskly.Shared.Services;

namespace Taskly.Web.Services
{
    public class TasksService : ITasksService
    {
        private readonly AppDbContext db;
        public TasksService()
        {
            
        }
        public TasksService(AppDbContext db)
        {
            this.db = db;
        }

        public async Task<ResultResponse<Tasks>> GetSingleTaskAsync()
        {
            var model = await db.Tasks.FirstOrDefaultAsync(x=>x.Id==1);
            var result = new ResultResponse<Tasks>();
            if (model == null)
            {
                result = new ResultResponse<Tasks>()
                {
                    Errors = new List<string>() { "No single tasks found" },
                    ResponseStatusCode = HttpStatusCode.OK,
                };
            }
            else
            {
                result = new ResultResponse<Tasks>
                {
                    ResponseStatusCode = HttpStatusCode.BadRequest,
                    Result = model
                };
            }
            return result;

        }

        public async Task<ResultResponse<List<Tasks>>> GetTasksAsync()
        {
            var model = await db.Tasks.ToListAsync();
            var result = new ResultResponse<List<Tasks>>();

            if (model != null && model.Any())
            {
                result = new ResultResponse<List<Tasks>>
                {
                    ResponseStatusCode = HttpStatusCode.OK,
                    Result = model
                };
            }
            else
            {
                result = new ResultResponse<List<Tasks>>
                {
                    ResponseStatusCode = HttpStatusCode.BadRequest,
                    Errors = new List<string> { "No tasks list found" }
                };
            }

            return result;
        }
        
    }
}
