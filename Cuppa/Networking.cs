using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Cuppa
{
    public class Networking
    {
        async string GetInput(int day)
        { }
        
            async string GetInput(int day)
            {
                string cacheFile = $"cached_day_{day}.txt";

                if (File.Exists(cacheFile))
                {
                    return File.ReadAllText(cacheFile);
                }
                else
                {

                    HttpResponseMessage response = await httpClient.GetAsync($"{BaseURL}/{day}/input");

                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();
                        File.WriteAllText(cacheFile, content);
                        return content;
                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");

                    }
                }
                return null;


                //var wc = new WebClient();
                //wc.Headers.Add(HttpRequestHeader.Cookie, $"{nameof(session)}={session}");
                //string contents = wc.DownloadString($"{BaseURL}/{day}/input");
                //System.IO.File.WriteAllText( cacheFile, contents );
                //return contents;

            }

        }
    }
}
