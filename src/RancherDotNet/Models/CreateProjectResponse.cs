using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rancher.DotNet.Models
{
    public class CreateProjectResponse
    {
        public string id { get; set; }
        public string type { get; set; }
        public ProjectLinks links { get; set; }
        public string baseType { get; set; }
        public ActionLinks actionLinks { get; set; }
        public string name { get; set; }
        public string state { get; set; }
        public bool allowSystemRole { get; set; }
        public string created { get; set; }
        public long createdTS { get; set; }
        public Object data { get; set; }
        public object defaultNetworkId { get; set; }
        public string description { get; set; }
        public string healthState { get; set; }
        public string kind { get; set; }
        public List<object> members { get; set; }
        public string orchestration { get; set; }
        public string projectTemplateId { get; set; }
        public object removeTime { get; set; }
        public object removed { get; set; }
        public object servicesPortRange { get; set; }
        public string transitioning { get; set; }
        public string transitioningMessage { get; set; }
        public object transitioningProgress { get; set; }
        public string uuid { get; set; }
        public string version { get; set; }
        public bool virtualMachine { get; set; }
    }
    public class ProjectLinks
    {
        public string self { get; set; }
        public string agents { get; set; }
        public string auditLogs { get; set; }
        public string backupTargets { get; set; }
        public string backups { get; set; }
        public string certificates { get; set; }
        public string configItemStatuses { get; set; }
        public string containerEvents { get; set; }
        public string credentials { get; set; }
        public string externalEvents { get; set; }
        public string genericObjects { get; set; }
        public string healthcheckInstanceHostMaps { get; set; }
        public string hosts { get; set; }
        public string images { get; set; }
        public string instanceLinks { get; set; }
        public string instances { get; set; }
        public string ipAddresses { get; set; }
        public string labels { get; set; }
        public string mounts { get; set; }
        public string networkDrivers { get; set; }
        public string networks { get; set; }
        public string physicalHosts { get; set; }
        public string ports { get; set; }
        public string projectMembers { get; set; }
        public string projectTemplate { get; set; }
        public string projectTemplates { get; set; }
        public string serviceConsumeMaps { get; set; }
        public string serviceEvents { get; set; }
        public string serviceExposeMaps { get; set; }
        public string serviceLogs { get; set; }
        public string services { get; set; }
        public string snapshots { get; set; }
        public string stacks { get; set; }
        public string storageDrivers { get; set; }
        public string storagePools { get; set; }
        public string subnets { get; set; }
        public string userPreferences { get; set; }
        public string volumeTemplates { get; set; }
        public string volumes { get; set; }
        public string accounts { get; set; }
        public string apiKeys { get; set; }
        public string azureadconfigs { get; set; }
        public string clusterMemberships { get; set; }
        public string composeProjects { get; set; }
        public string composeServices { get; set; }
        public string configItems { get; set; }
        public string containers { get; set; }
        public string databasechangeloglocks { get; set; }
        public string databasechangelogs { get; set; }
        public string dnsServices { get; set; }
        public string extensionPoints { get; set; }
        public string externalDnsEvents { get; set; }
        public string externalHandlerExternalHandlerProcessMaps { get; set; }
        public string externalHandlerProcesses { get; set; }
        public string externalHandlers { get; set; }
        public string externalHostEvents { get; set; }
        public string externalServiceEvents { get; set; }
        public string externalServices { get; set; }
        public string externalStoragePoolEvents { get; set; }
        public string externalVolumeEvents { get; set; }
        public string haConfigInputs { get; set; }
        public string haConfigs { get; set; }
        public string hostApiProxyTokens { get; set; }
        public string identities { get; set; }
        public string kubernetesServices { get; set; }
        public string kubernetesStacks { get; set; }
        public string ldapconfigs { get; set; }
        public string loadBalancerServices { get; set; }
        public string localAuthConfigs { get; set; }
        public string machineDrivers { get; set; }
        public string machines { get; set; }
        public string networkDriverServices { get; set; }
        public string openldapconfigs { get; set; }
        public string passwords { get; set; }
        public string processDefinitions { get; set; }
        public string processExecutions { get; set; }
        public string processInstances { get; set; }
        public string projects { get; set; }
        public string pullTasks { get; set; }
        public string register { get; set; }
        public string registrationTokens { get; set; }
        public string registries { get; set; }
        public string registryCredentials { get; set; }
        public string resourceDefinitions { get; set; }
        public string schemas { get; set; }
        public string serviceProxies { get; set; }
        public string settings { get; set; }
        public string storageDriverServices { get; set; }
        public string taskInstances { get; set; }
        public string tasks { get; set; }
        public string typeDocumentations { get; set; }
        public string virtualMachines { get; set; }
        public string hostStats { get; set; }
    }

    public class ActionLinks
    {
    }

    
}
