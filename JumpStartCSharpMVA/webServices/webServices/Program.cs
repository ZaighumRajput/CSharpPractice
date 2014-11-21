using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webServices
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = new Uri("http://localhost:1234/MyService.svc/json/4");
            var client = new System.Net.WebClient();
            var json = await client.DownloadStringTaskAsync(url);

            var serializer = new JavaScriptSerializer();
            
        }
    }
}
