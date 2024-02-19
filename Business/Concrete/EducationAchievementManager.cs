using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Business.Concrete
{
    public class EducationAchievementManager : IEducationAchievementService
    {
        IEducationAchievementDal _educationAchievementDal;

        public EducationAchievementManager(IEducationAchievementDal educationAchievementDal)
        {
            _educationAchievementDal = educationAchievementDal;
        }

        public IResult Add(EducationAchievement achievement)
        {
            _educationAchievementDal.Add(achievement);
            return new SuccessResult();
        }

        public IResult Delete(EducationAchievement achievement)
        {
            _educationAchievementDal.Delete(achievement);
            return new SuccessResult();
        }

        public IDataResult<EducationAchievement> Get(int id)
        {
            return new SuccessDataResult<EducationAchievement>(_educationAchievementDal.Get(p => p.Id == id));
        }

        public IDataResult<List<EducationAchievement>> GetAll()
        {
            return new SuccessDataResult<List<EducationAchievement>>(_educationAchievementDal.GetAll());
        }

        public IResult Update(EducationAchievement achievement)
        {
            _educationAchievementDal.Update(achievement);
            return new SuccessResult();
        }
    }
}
