using Core.DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.Abstract
{
    public interface IEducationDal : IEntityRepository<Education>
    {
        List<EducationDto> GetAllEducationDetails(Expression<Func<EducationDto, bool>> filter = null);
        EducationDto GetEducationDetail(Expression<Func<EducationDto, bool>> filter);
    }
}
