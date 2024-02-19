using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IEducationTargetAudienceService
    {
        IDataResult<List<EducationTargetAudience>> GetAll();
        IDataResult<EducationTargetAudience> Get(int id);
        IResult Add(EducationTargetAudience targetAudience);
        IResult Update(EducationTargetAudience targetAudience);
        IResult Delete(EducationTargetAudience targetAudience);

    }

}
