using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IEducationSummaryService
    {
        IDataResult<List<EducationSummary>> GetAll();
        IDataResult<EducationSummary> Get(int id);
        IResult Add(EducationSummary summary);
        IResult Update(EducationSummary summary);
        IResult Delete(EducationSummary summary);

    }

}
