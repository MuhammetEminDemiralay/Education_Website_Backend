using Core.Entites.Abstract;

namespace Entities.Concrete
{
    public class EducationSubCategory : IEntity
    {
        public int Id { get; set; }
        public int EducationCategoryId { get; set; }
        public string EducationSubCategoryName { get; set; }
    }
}
