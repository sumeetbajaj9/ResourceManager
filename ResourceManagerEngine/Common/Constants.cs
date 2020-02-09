using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManagerEngine.Common
{
    class Constants
    {
        public const string query = "MATCH (movie:Movie {title:{title}}) OPTIONAL MATCH (movie)<-[r]-(person:Person) RETURN movie.title as title, collect([person.name, head(split(lower(type(r)), '_')), r.roles]) as cast LIMIT 1";
    }
}
