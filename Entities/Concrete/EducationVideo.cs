using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class EducationVideo
    {
        public int Id { get; set; }
        public int VideoSubTitleId { get; set; }
        public string EducationVideoPath { get; set; }
        public DateTime Date { get; set; }
    }
}
