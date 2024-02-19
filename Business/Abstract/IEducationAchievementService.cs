using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IEducationAchievementService
    {
        IDataResult<List<EducationAchievement>> GetAll();
        IDataResult<EducationAchievement> Get(int id);
        IResult Add(EducationAchievement achievement);
        IResult Update(EducationAchievement achievement);
        IResult Delete(EducationAchievement achievement);

    }

}
