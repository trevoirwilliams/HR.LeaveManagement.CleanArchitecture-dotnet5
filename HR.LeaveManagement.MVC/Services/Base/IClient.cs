using System.Net.Http;

namespace HR.LeaveManagement.MVC.Services.Base
{
    public partial interface IClient
    {
        public HttpClient HttpClient { get; }

    }
}
