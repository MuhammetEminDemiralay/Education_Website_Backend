using Core.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class EducationVideo : IEntity
    {
        public int Id { get; set; }
        public int VideoSubTitleId { get; set; }
        public string EducationVideoPath { get; set; }
        public DateTime Date { get; set; }
    }
}
