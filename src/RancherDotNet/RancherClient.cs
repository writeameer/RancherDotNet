using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Rancher.DotNet.Models;
using System.Net;

namespace Rancher.DotNet
{
    public class RancherClient
    {
        static HttpClient HttpClient = new HttpClient();
        static HttpProxy HttpProxy;
        static string apiVersion = Lookup.APIV2Beta;
        Uri RancherUrl;

        public RancherClient(string rancherUrl)
        {
            RancherUrl = new Uri(rancherUrl);

            // Setup http client with Rancher URL
            HttpClient.BaseAddress = RancherUrl;
            HttpClient.DefaultRequestHeaders.Accept.Clear();
            HttpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            HttpProxy = new HttpProxy(rancherUrl);
        }

        public ApiKey CreateApiKey(CreateAPIKeyRequest request)
        {
            // Check for key with same name and return if found
            var existingKey = ListApiKeys(request.name).FirstOrDefault() ;

            
            if (existingKey != null )
            {
                // Key Already existing deleting
                Console.WriteLine("Key already exists, will attemp to delete");
                var delRequest = new DeleteApiKeyRequest(existingKey.id);
                DeleteApiKey(delRequest);
            }
                


            // If project ID was provided and envrionment key is created
            // else an account key is created
            string uri;

            if (request.projectId == null)
                uri = "/apikeys";
            else
                uri = $"/projects/{request.projectId}/apikeys";

            // Generate Key
            var response = HttpProxy.PostAync<CreateAPIKeyResponse>(request, apiVersion + uri);

            // Return key
            return new ApiKey(
                id: response.id,
                name: response.name,
                description: response.description,
                publicValue: response.publicValue,
                secretValue: response.secretValue
            );

        }

        public Project AddProject(CreateProjectRequest request)
        {

            // Check for existing project with same name
            var existingProject = ListProjects(request.name);

            if (existingProject != null && existingProject.Count != 0)
                return existingProject?.First();

            var response = HttpProxy.PostAync<CreateProjectResponse>(request, apiVersion + "/project");
            
            return new Project(
                id: response.id,
                name: response.name,
                description: response.description,
                projectTemplateId: response.projectTemplateId,
                type: response.type
            );

        }

        public Project DeactivateProject(DeactivateProjectRequest request)
        {

            var response = HttpProxy.PostAync<Project>(request, $"/{apiVersion}/projects/{request.projectId}/?action=deactivate");

            return new Project(
                id: response.id,
                name: response.name,
                description: response.description,
                projectTemplateId: response.projectTemplateId,
                type: response.type,
                state: response.state
            );
        }


        public Project DeactivateApiKey(DeactivateApiKeyRequest request)
        {

            var response = HttpProxy.PostAync<Project>(request, $"/{apiVersion}/apikeys/{request.id}/?action=deactivate");

            return new Project(
                id: response.id,
                name: response.name,
                description: response.description,
                projectTemplateId: response.projectTemplateId,
                type: response.type,
                state: response.state
            );
        }

        public HttpStatusCode DeleteProject(DeleteProjectRequest request)
        {
            return HttpProxy.DeleteAync($"/{apiVersion}/projects/{request.projectId}");
        }

        public HttpStatusCode DeleteApiKey(DeleteApiKeyRequest request)
        {
            return HttpProxy.DeleteAync($"/{apiVersion}/apikeys/{request.id}");
        }

        public List<Project> ListProjects(string name=null)
        {
            var projects =  HttpProxy.GetAsync<Projects>($"/{apiVersion}/projects");
            if (name == null)
                return projects.data;
            else
                return projects.data.Where( x => x.name.ToLower() == name.ToLower()).ToList();
        }

        public List<ApiKey> ListApiKeys(string name = null)
        {
            var apiKeys = HttpProxy.GetAsync<ApiKeys>($"/{apiVersion}/apikeys");
            if (name == null)
                return apiKeys.data;
            else
                return apiKeys.data.Where(x => x.name.ToLower() == name.ToLower()).ToList();
        }

    }


}
