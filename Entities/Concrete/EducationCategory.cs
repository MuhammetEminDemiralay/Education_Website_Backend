using Core.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class EducationCategory : IEntity
    { 
        public int Id { get; set; }
        public int EducationCategoryName { get; set; }
    }
}
