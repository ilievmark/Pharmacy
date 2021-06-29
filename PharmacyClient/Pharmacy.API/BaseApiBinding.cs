using System.Net.Http;
using Pharmacy.Domain;

namespace Pharmacy.API
{
    public class BaseApiBinding
    {
        protected readonly HttpClient _client;

        protected string BaseUrl => ProjectConstants.BaseUrl;

        public BaseApiBinding(
            HttpClient client)
        {
            _client = client;
        }

        protected string GetRequestUrl(string path)
        {
            return BaseUrl + "/" + path;
        }
    }
}