using Azure;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using Taskly.Shared.Models;
using Taskly.Shared.Services;

namespace Taskly.Services
{
    public class TasksService : ITasksService
    {
        private readonly HttpClient httpClient;

        public TasksService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<ResultResponse<Tasks>> GetSingleTaskAsync()
        {
            var response = await httpClient.GetFromJsonAsync<ResultResponse<Tasks>>("api/tasks/gst");
            return response;
        }

        public async Task<ResultResponse<List<Tasks>>> GetTasksAsync()
        {
            var response = await httpClient.GetFromJsonAsync<ResultResponse<List<Tasks>>>("api/tasks/gtl");
            return response;
        }
    }
}
