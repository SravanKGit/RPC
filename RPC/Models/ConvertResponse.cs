using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RPC.Models
{
    public class ConvertResponse
    {
        public string date { get; set; }
        public info info { get; set; }
        public query query { get; set; }
        public string result { get; set; }
        public string success { get; set; }
    }

    public class info
    {
        public string rate { get; set; }
        public string timestamp { get; set; }
    }
    public class query
    {
        public string amount { get; set; }
        public string from { get; set; }
        public string to { get; set; }
    }
}