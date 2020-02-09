using Neo4j.Driver.V1;
using ResourceManagerEngine.Models;

namespace ResourceManagerEngine.Repository
{
    public interface IResourceManagerRepository
    {
        ResourceManagerResponseModel.ResourceDetails GetAnswer(Neo4j.Driver.V1.ISession session);
        ResourceManagerResponseModel.ResourceDetails GetFetchedData(ISession session);
    }
}