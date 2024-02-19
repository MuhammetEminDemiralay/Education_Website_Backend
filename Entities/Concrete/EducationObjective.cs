using Core.Entites.Abstract;

namespace Entities.Concrete
{
    public class EducationObjective : IEntity
    {
        public int Id { get; set; }
        public int EducationId { get; set; }
        public string Objective { get; set; }
    }

}
