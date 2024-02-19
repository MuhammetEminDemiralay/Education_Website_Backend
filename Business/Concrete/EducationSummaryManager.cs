using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class EducationSummaryManager : IEducationSummaryService
    {
        IEducationSummaryDal _educationSummaryDal;

        public EducationSummaryManager(IEducationSummaryDal educationSummaryDal)
        {
            _educationSummaryDal = educationSummaryDal;
        }

        public IResult Add(EducationSummary summary)
        {
            _educationSummaryDal.Add(summary);
            return new SuccessResult();
        }

        public IResult Delete(EducationSummary summary)
        {
            _educationSummaryDal.Delete(summary);
            return new SuccessResult();
        }

        public IDataResult<EducationSummary> Get(int id)
        {
            return new SuccessDataResult<EducationSummary>(_educationSummaryDal.Get(p => p.Id == id));
        }

        public IDataResult<List<EducationSummary>> GetAll()
        {
            return new SuccessDataResult<List<EducationSummary>>(_educationSummaryDal.GetAll());
        }

        public IResult Update(EducationSummary summary)
        {
            _educationSummaryDal.Update(summary);
            return new SuccessResult();
        }
    }
}
