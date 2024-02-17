using Core.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Education : IEntity
    {
        public int Id { get; set; }
        public int EducationCategoryId { get; set; }
        public int EducationSubCategoryId { get; set; }
        public int InstructorId { get; set; }
        public string EducationName { get; set; }
        public int Like { get; set; }
        public int Dislike { get; set; }
        public int Participants { get; set; }
        public int Time { get; set; }
    }
}
