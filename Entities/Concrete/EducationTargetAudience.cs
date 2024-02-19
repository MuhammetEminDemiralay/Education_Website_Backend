using Core.Entites.Abstract;

namespace Entities.Concrete
{
    public class EducationTargetAudience : IEntity
    {
        public int Id { get; set; }
        public int EducationId { get; set; }
        public string TargetAudience { get; set; }
    }

}
