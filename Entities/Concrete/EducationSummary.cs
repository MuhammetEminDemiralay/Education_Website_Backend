using Core.Entites.Abstract;

namespace Entities.Concrete
{
    public class EducationSummary : IEntity
    {
        public int Id { get; set; }
        public int EducationId { get; set; }
        public string Summary { get; set; }
    }

}
