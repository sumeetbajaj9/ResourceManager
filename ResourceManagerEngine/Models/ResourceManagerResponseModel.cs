using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceManagerEngine.Models
{
    public class ResourceManagerResponseModel
    {
           //public class CastResult
           //  {
           //     public string name { get; set; }
           //     public string job { get; set; }
           //     public IEnumerable<string> role { get; set; }
           // }

           // public class MovieResult
           // {
           //     public string title { get; set; }
           //     public IEnumerable<CastResult> cast { get; set; }
           // }

            public class ResourceDetails { 
                
                public string EmployeeID { get; set; }
                public string EmployeeName { get; set; }
                public string OldProject { get; set; }
                public string OldProjectDate { get; set; }
                public string NewProject{ get; set; }
                public string NewProjectStartDate { get; set; }
                public List<string> SkillsMatching { get; set; }
            }
    }
}
