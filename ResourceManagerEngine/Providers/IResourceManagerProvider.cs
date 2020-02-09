using ResourceManagerEngine.Models;
using System.Collections.Generic;

namespace ResourceManagerEngine.Providers
{
    public interface IResourceManagerProvider
    {
        ResourceManagerResponseModel.ResourceDetails GetDemo(Neo4j.Driver.V1.ISession session);
        List<ResourceManagerResponseModel.ResourceDetails> GetFetchedDetails(Neo4j.Driver.V1.ISession session);
    }
}