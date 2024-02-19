using Core.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class VideoTitle : IEntity
    {
        public int Id { get; set; }
        public int EducationId { get; set; }
        public int EducationTitleNumber { get; set; }
        public string EducationTitleName { get; set; }
    }
}
