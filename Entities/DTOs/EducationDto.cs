using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class EducationDto
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string SubCategoryName { get; set; }
        public string EducationName { get; set; }
        public int Like { get; set; }
        public int Dislike { get; set; }
        public int Participants { get; set; }
        public List<string> Objective { get; set; }
        public List<string> Summary { get; set; }
        public List<string> TargetAudience { get; set; }
        public List<string> Requirement { get; set; }
        public List<string> Achievement { get; set; }
    }
}
