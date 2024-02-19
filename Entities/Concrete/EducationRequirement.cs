using Core.Entites.Abstract;

namespace Entities.Concrete
{
    public class EducationRequirement : IEntity
    {
        public int Id { get; set; }
        public int EducationId { get; set; }
        public string Requirement { get; set; }
    }

}
