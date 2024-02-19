using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class EducationObjectiveManager : IEducationObjectiveService
    {
        IEducationObjectiveDal _educationObjectiveDal;

        public EducationObjectiveManager(IEducationObjectiveDal educationObjectiveDal)
        {
            _educationObjectiveDal = educationObjectiveDal;
        }

        public IResult Add(EducationObjective educationObjective)
        {
            _educationObjectiveDal.Add(educationObjective);
            return new SuccessResult(); 

        }

        public IResult Delete(EducationObjective educationObjective)
        {
            _educationObjectiveDal.Delete(educationObjective);
            return new SuccessResult();
        }

        public IDataResult<EducationObjective> Get(int id)
        {

            return new SuccessDataResult<EducationObjective>(_educationObjectiveDal.Get(p => p.Id == id));
        }

        public IDataResult<List<EducationObjective>> GetAll()
        {
            return new SuccessDataResult<List<EducationObjective>>(_educationObjectiveDal.GetAll());
        }

        public IResult Update(EducationObjective educationObjective)
        {
            _educationObjectiveDal.Update(educationObjective);
            return new SuccessResult();
        }
    }
}
