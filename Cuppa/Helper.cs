using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Cuppa
{
    public class Helper
    {
        
        public int Day { get; private set; }
        public string Input { get; private set; }
        public Helper(int day)
        {
            Day = day;
            Input = GetInput(Day);
        }
        string GetInput (int day)
        {
            string cacheFile = $"cached_day_{day}.txt";
            var wc = new WebClient();
            wc.Headers.Add(HttpRequestHeader.Cookie, $"{nameof(session)}={session}");
            string contents = wc.DownloadString($"{BaseURL}/{day}/input");
            System.IO.File.WriteAllText( cacheFile, contents );
            return contents;

        }
    }
}
