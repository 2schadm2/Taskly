using System;
using System.Collections.Generic;
using System.Text;
using Taskly.Shared.Models;

namespace Taskly.Shared.Services
{
    public interface ITasksService
    {
        Task<ResultResponse<List<Tasks>>>GetTasksAsync();
        Task<ResultResponse<Tasks>> GetSingleTaskAsync();
    }
}
