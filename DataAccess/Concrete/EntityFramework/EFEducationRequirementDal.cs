﻿using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFEducationRequirementDal : EFEntityRepositoryBase<EducationRequirement, EducationContext>, IEducationRequirementDal
    {
    }
}
