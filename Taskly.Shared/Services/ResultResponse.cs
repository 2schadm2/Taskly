using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Taskly.Shared.Services
{
    public class ResultResponse<T>
    {
        //public int ResponseStatusCode { get; set; }
        //public string ResponseMessage { get; set; } = string.Empty;
        //public T? Result { get; set; }

        //public ResultResponse() { }

        //public ResultResponse(int statusCode, string message, T? result)
        //{
        //    ResponseStatusCode = statusCode;
        //    ResponseMessage = message;
        //    Result = result;
        //}
        public HttpStatusCode ResponseStatusCode { get; set; }
        public T? Result { get; set; }

        public List<string>? Errors { get; set; }

        public bool IsSuccess =>
            ResponseStatusCode == HttpStatusCode.OK;
    }
}
