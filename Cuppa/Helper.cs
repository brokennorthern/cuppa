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
    public class Helper : Networking
    {
        static readonly HttpClient httpClient = new HttpClient();
        const string BaseURL = "https://adventofcode.com/2022/day";
        static readonly string session = File.ReadAllText($"{nameof(session)}.txt");
        public int Day { get; private set; }
        public string Input { get; private set; }
        public Helper(int day)
        {
            Day = day;
            Input = GetInput(Day);
        }
        
    }
}
