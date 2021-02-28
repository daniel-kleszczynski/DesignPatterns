using System;
using BuilderDemo.Services;

namespace BuilderDemo.Models
{
    public class ModuleY
    {
        private readonly IApiService _apiService;
        private readonly DateTime _issueDate;
        private readonly string _name;

        public ModuleY(string name, DateTime issueDate, IApiService apiService)
        {
            _name = name;
            _issueDate = issueDate;
            _apiService = apiService;
        }

        public string GetData(string accessToken, int id)
        {
            return _apiService.GetData(accessToken, id);
        }

        public override string ToString()
        {
            return $"ModuleY : {{ Name : {_name}, IssueDate : {_issueDate.ToString("yyyy-MM-dd")} }}";
        }
    }
}
