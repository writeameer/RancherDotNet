using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rancher.DotNet.Models
{
    public class ApiKey
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string publicValue { get; set; }
        public string secretValue { get; set; }

        public ApiKey(string id, string name, string description, string publicValue, string secretValue)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.publicValue = publicValue;
            this.secretValue = secretValue;
        }
        public void activate()
        {
            throw new NotImplementedException("** not implemented **");
        }

        public void deactivate()
        {
            throw new NotImplementedException("** not implemented **");
        }

        public bool NameIs(string name)
        {
            return this.name.ToLower() == name.ToLower();
        }
    }
}
