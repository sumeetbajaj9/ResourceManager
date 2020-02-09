using Neo4j.Driver.V1;
using ResourceManagerEngine.Models;
using System.Collections.Generic;

namespace ResourceManagerEngine.Repository
{
    public interface IResourceManagerRepository
    {
        ResourceManagerResponseModel.ResourceDetails GetAnswer(Neo4j.Driver.V1.ISession session);
        List<ResourceManagerResponseModel.ResourceDetails> GetFetchedData(ISession session);
    }
}