using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rancher.DotNet.Models
{
    public class Links
    {
        public string self { get; set; }
        public string account { get; set; }
        public string images { get; set; }
        public string instances { get; set; }
        public string certificate { get; set; }
    }
}
