using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class VideoSubTitle
    {
        public int Id { get; set; }
        public int VideoTitleId { get; set; }
        public int EducationSubTitleNumber { get; set; }
        public string EducationSubTitleName { get; set; }
    }
}
