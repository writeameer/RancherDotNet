using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rancher.DotNet.Models
{
    public class DeleteApiKeyRequest 
    {
        public string id { get; set; }

        public DeleteApiKeyRequest(string id)
        {
            this.id = id;
        }
    }
}
