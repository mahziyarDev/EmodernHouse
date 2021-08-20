using Microsoft.AspNetCore.Http;

namespace EModernHouse.Web.PresentationExtentions
{
    public static class HttpExtensions
    {
        public static string GetUserIp(this HttpContext httpContext)
        {
            return httpContext.Connection.RemoteIpAddress.ToString();
        }
    }
}