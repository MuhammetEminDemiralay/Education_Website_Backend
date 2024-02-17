using Core.Utilities.Results;
using Entities.Concrete;


namespace Business.Abstract
{
    public interface IEducationService
    {
        IDataResult<List<Education>> GetAll();
        IDataResult<Education> Get(int educationId);
        IResult Add(Education education);
        IResult Update(Education education);
        IResult Delete(Education education);
    }
}
