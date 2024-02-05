using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class EducationSubCategoryImage
    {
        public int Id { get; set; }
        public int EducationSubCategoryId { get; set; }
        public string EducationSubCategoryImagePath { get; set; }
        public DateTime Date { get; set; }
    }
}
