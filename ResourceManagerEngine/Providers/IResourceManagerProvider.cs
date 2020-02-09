using ResourceManagerEngine.Models;

namespace ResourceManagerEngine.Providers
{
    public interface IResourceManagerProvider
    {
        ResourceManagerResponseModel.ResourceDetails GetDemo(Neo4j.Driver.V1.ISession session);
        ResourceManagerResponseModel.ResourceDetails GetFetchedDetails(Neo4j.Driver.V1.ISession session);
    }
}