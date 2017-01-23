using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rancher.DotNet.Models
{
    public class Project
    {
        public string name { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public string projectTemplateId { get; set; }
        public bool kubernetes { get; set; }
        public bool mesos { get; set; }
        public bool publicDns { get; set; }
        public bool swarm { get; set; }
        public bool virtualMachine { get; set; }
        public string id { get; set; }
        public string state { get; set; }
        public Project(string id, string name, string description, string type, string projectTemplateId, string state=null)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.type = type;
            this.projectTemplateId = projectTemplateId;
            this.state = state;
        }
    }
}
