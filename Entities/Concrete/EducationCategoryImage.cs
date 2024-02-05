using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class EducationCategoryImage
    {
        public int Id { get; set; }
        public int EducationCategoryId { get; set; }
        public string EducationCategoryImagePath { get; set; }
        public DateTime Date { get; set; }
    }
}
