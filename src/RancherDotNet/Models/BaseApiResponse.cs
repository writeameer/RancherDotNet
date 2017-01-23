using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rancher.DotNet.Models
{
    public class BaseApiResponse
    {
        public string id { get; set; }
        public string type { get; set; }
        public Links links { get; set; }
        public Actions actions { get; set; }
        public string baseType { get; set; }
        public string name { get; set; }
        public string state { get; set; }
        public string accountId { get; set; }
        public string created { get; set; }
        public long createdTS { get; set; }
        public Data data { get; set; }
        public string description { get; set; }
        public string kind { get; set; }
        public object removeTime { get; set; }
        public object removed { get; set; }
        public string transitioning { get; set; }
        public string transitioningMessage { get; set; }
        public object transitioningProgress { get; set; }
        public string uuid { get; set; }
    }
}
