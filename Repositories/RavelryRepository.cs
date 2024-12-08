using Capstone2.Classes;
using RestEase;
using System.Net.Http.Headers;
using System.Text;

namespace Capstone2.Repositories
{
    public class RavelryRepository
    {
        public IRavelryApi api { get; set; }
        public RavelryRepository()
        {
            api = RestClient.For<IRavelryApi>("https://api.ravelry.com");
            var value = Convert.ToBase64String(Encoding.ASCII.GetBytes("read-e253950727768fd750515aca9d2f871a:j+fwomB1pc1YB2kuFdB67XiZSh9GilKszIp9vE47"));
            api.Authorization = new AuthenticationHeaderValue("Basic", value);

        } 
    }
    public interface IRavelryApi
    {
        // The [Get] attribute marks this method as a GET request
        // The "users" is a relative path the a base URL, which we'll provide later
        // "{userId}" is a placeholder in the URL: the value from the "userId" method parameter is used
        [Get("patterns/search.json")]
        Task<PatternSearchResponse> SearchPatternsAsync([Query] string query);

        [Header("Authorization")]
        AuthenticationHeaderValue Authorization { get; set; }

       
    }
}

