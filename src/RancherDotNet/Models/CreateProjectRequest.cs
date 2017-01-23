using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rancher.DotNet.Models
{
    public class CreateProjectRequest : IRequestObject
    {
        public string name { get; set; }
        public string description { get; set; }
        public bool allowSystemRole { get; set; }
        public bool virtualMachine { get; set; }
        public string type { get; set; }
        public string projectTemplateId { get; set; }
        public List<object> projectMembers { get; set; }
        public object created { get; set; }
        public object healthState { get; set; }
        public object kind { get; set; }
        public object removeTime { get; set; }
        public object removed { get; set; }
        public object uuid { get; set; }
        public object version { get; set; }
        public List<object> members { get; set; }

        public CreateProjectRequest(string name, string description, string projectTemplateId = Lookup.CattleProjectTemplateId, string type = "project")
        {
            this.name = name;
            this.description = description;
            this.projectTemplateId = projectTemplateId;
            this.type = type;
        }
    }
}
