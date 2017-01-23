using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rancher.DotNet.Models
{
    public class CreateAPIKeyRequest : IRequestObject
    {
        public string description { get; set; }
        public string name { get; set; }
        public string projectId { get; set; }


        public CreateAPIKeyRequest(string description, string name, string projectId = null)
        {
            this.description = description;
            this.name = name;
            this.projectId = projectId;
        }
    }
}
