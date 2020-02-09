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
        public const string query2 = "MATCH(E:Employee),(S:Skill),(P:Project),(P1:Project),(P)<-[:CurrentProject]-(E)-[:HAS_SKILL]->(S)<-[:Skills_Required]-(P1) WHERE duration.inDays(date(),P.EndDate).days <15 AND duration.inDays(date(),P.EndDate).days >0 AND P1<>P RETURN E.EmployeeId as EmployeeId,E.Name as EmployeeName,P.ProjectName as OldProject,P.EndDate as OldProjectEndDate,P1.ProjectName as NewProject,P1.StartDate as NewProjectStartDate,Collect(distinct(S.SkillName))as SkillsMatching";
    }
}
