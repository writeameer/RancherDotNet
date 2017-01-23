using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rancher.DotNet.Models
{
    public class DeactivateProjectRequest : IRequestObject
    {
        public string description { get; set; }
        public string name { get; set; }
        public string projectId { get; set; }

        public DeactivateProjectRequest(string projectId)
        {
            this.projectId = projectId;
        }
    }
}
