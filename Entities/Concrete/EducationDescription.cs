using Core.Entites.Abstract;

namespace Entities.Concrete
{
    public class EducationDescription : IEntity
    {
        public int Id { get; set; }
        public int EducationId { get; set; }
        public string? Objective { get; set; }
        public string? Summary { get; set; }
        public string? TargetAudince { get; set; }
        public string? Requirements { get; set; }
        public string? Achievement { get; set; }
    }

}
