using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IEducationObjectiveService
    {
        IDataResult<List<EducationObjective>> GetAll();
        IDataResult<EducationObjective> Get(int id);
        IResult Add(EducationObjective objective);
        IResult Update(EducationObjective objective);
        IResult Delete(EducationObjective objective);

    }

}
