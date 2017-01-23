using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rancher.DotNet.Models
{
    public class CreateAPIKeyResponse : BaseApiResponse
    {
        public string publicValue { get; set; }
        public string secretValue { get; set; }
    }
}
