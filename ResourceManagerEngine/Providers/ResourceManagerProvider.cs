using Neo4j.Driver.V1;
using ResourceManagerEngine.Repository;
using ResourceManagerEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManagerEngine.Providers
{
    public class ResourceManagerProvider : IResourceManagerProvider
    {
        IResourceManagerRepository repository = null;

        public ResourceManagerProvider() {
            repository = new ResourceManagerRepository();
        }


        //provider method for getting the data connected to repository
        public ResourceManagerResponseModel.ResourceDetails GetDemo(ISession session)
        {
            var result = new ResourceManagerResponseModel.ResourceDetails();
            result = repository.GetAnswer(session);
            return result;
        }

        public List<ResourceManagerResponseModel.ResourceDetails> GetFetchedDetails(ISession session)
        {
            var result = new List<ResourceManagerResponseModel.ResourceDetails>();
            result = repository.GetFetchedData(session);
            return result;
        }
    }
}
