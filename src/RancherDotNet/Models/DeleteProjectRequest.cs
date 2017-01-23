using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rancher.DotNet.Models
{
    public class DeleteProjectRequest
    {
        public string description { get; set; }
        public string name { get; set; }
        public string projectId { get; set; }

        public DeleteProjectRequest(string projectId)
        {
            this.projectId = projectId;
        }
    }
}
