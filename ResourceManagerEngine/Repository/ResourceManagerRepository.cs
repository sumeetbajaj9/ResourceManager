using Neo4j.Driver.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResourceManagerEngine.Models;

namespace ResourceManagerEngine.Repository
{
    public class ResourceManagerRepository : IResourceManagerRepository
    {
        //method for getting the data from the database using the session variable which is provided
        public ResourceManagerResponseModel.ResourceDetails GetAnswer(ISession session)
        {
            var statementTemplate = Common.Constants.query;
            var statementParameters = new Dictionary<string, object> { { "title", "The Da Vinci Code" } };
            var result = new ResourceManagerResponseModel.ResourceDetails();
            var statementResult = session.Run(statementTemplate, statementParameters);
            var record = statementResult.ToList();

            foreach (var rec in record) { 
            
            }
                //result.title = record["title"].As<string>();

                //var castResults = new List<ResourceManagerResponseModel.CastResult>();
                //List<object> cast = record["cast"].As<List<object>>();
                //foreach (IList<object> castMember in cast)
                //{
                //    var castResult = new ResourceManagerResponseModel.CastResult
                //    {
                //        name = castMember[0].As<string>(),
                //        job = castMember[1].As<string>(),
                //        role = castMember[2]?.As<List<string>>()
                //    };
                //    castResults.Add(castResult);
                //}
                //result.cast = castResults;
            return result;
        }

        public ResourceManagerResponseModel.ResourceDetails GetFetchedData(ISession session)
        {
            var result = new ResourceManagerResponseModel.ResourceDetails();

            return result;
        }
    }
}
