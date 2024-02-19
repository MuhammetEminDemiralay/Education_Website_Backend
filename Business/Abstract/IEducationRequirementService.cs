using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IEducationRequirementService
    {
        IDataResult<List<EducationRequirement>> GetAll();
        IDataResult<EducationRequirement> Get(int id);
        IResult Add(EducationRequirement requirement);
        IResult Update(EducationRequirement requirement);
        IResult Delete(EducationRequirement requirement);

    }

}
