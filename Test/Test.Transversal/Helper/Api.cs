using Newtonsoft.Json;
using RestSharp;

namespace Test.Transversal.Helper
{
    public static class Api
    {
        public static T CallApi<T>(string api)
        {
            var Client = new RestClient();
            var Request = new RestRequest(api);
            IRestResponse Response = Client.Execute(Request);
            if (Response.IsSuccessful)
                return JsonConvert.DeserializeObject<T>(Response.Content);
            return default;
        }
    }
}
