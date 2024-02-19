using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class EducationRequirementManager : IEducationRequirementService
    {
        IEducationRequirementDal _educationRequirementDal;

        public EducationRequirementManager(IEducationRequirementDal educationRequirementDal)
        {
            _educationRequirementDal = educationRequirementDal;
        }

        public IResult Add(EducationRequirement requirement)
        {
            _educationRequirementDal.Add(requirement);
            return new SuccessResult();
        }

        public IResult Delete(EducationRequirement requirement)
        {
            _educationRequirementDal.Delete(requirement);
            return new SuccessResult();
        }

        public IDataResult<EducationRequirement> Get(int id)
        {
            return new SuccessDataResult<EducationRequirement>(_educationRequirementDal.Get(p => p.Id == id));
        }

        public IDataResult<List<EducationRequirement>> GetAll()
        {
            return new SuccessDataResult<List<EducationRequirement>>(_educationRequirementDal.GetAll());
        }

        public IResult Update(EducationRequirement requirement)
        {
            _educationRequirementDal.Update(requirement);
            return new SuccessResult();
        }
    }
}
