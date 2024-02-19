using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFEducationObjectiveDal : EFEntityRepositoryBase<EducationObjective, EducationContext>, IEducationObjectiveDal
    {
    }
}
