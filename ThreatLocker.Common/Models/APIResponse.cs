using System.Net;

namespace ThreatLockerCommon.Models
{
    public class APIResponse<T>
    {
        public bool Success { get; set; }
        public HttpStatusCode HttpStatusCode { get; set; }
        public string ErrorMessage { get; set; }
        public T ResponseObject { get; set; }
    }
}
