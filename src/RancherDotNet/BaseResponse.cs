using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rancher.DotNet
{
    public class BaseResponse<T>
    {
        public string type { get; set; }
        public string resourceType { get; set; }
        public List<T> data { get; set; }
    }
}
