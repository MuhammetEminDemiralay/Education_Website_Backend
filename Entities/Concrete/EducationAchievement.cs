using Core.Entites.Abstract;

namespace Entities.Concrete
{
    public class EducationAchievement : IEntity
    {
        public int Id { get; set; }
        public int EducationId { get; set; }
        public string Achievement { get; set; }
    }

}
