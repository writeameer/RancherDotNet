using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rancher.DotNet.Models
{
    public class DeactivateApiKeyRequest : IRequestObject
    {
        public string description { get; set; }
        public string name { get; set; }
        public string id { get; set; }

        public DeactivateApiKeyRequest (string id)
        {
            this.id = id;
        }
    }
}
