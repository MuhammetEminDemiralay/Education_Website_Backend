using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Education
    {
        public int Id { get; set; }
        public int EducationCategoryId { get; set; }
        public int EducationSubCategoryId { get; set; }
        public string EducationName { get; set; }
        public List<string> EducationObjective { get; set; }
        public List<string> EducationSummary { get; set; }
        public List<string> TargetAudience { get; set; }
        public List<string> UserRequirements { get; set; }
        public List<string> Achievements { get; set; }
    }
}
