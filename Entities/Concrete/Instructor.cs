using Core.Entites.Abstract;

namespace Entities.Concrete
{
    public class Instructor : IEntity
    {
        public int Id { get; set; }
        public string InstructorName { get; set; }
        public string InstructorSurname { get; set; }
    }

}
