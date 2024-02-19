using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class EducationTargetAudienceManager : IEducationTargetAudienceService
    {
        IEducationTargetAudienceDal _educationTargetAudienceDal;

        public EducationTargetAudienceManager(IEducationTargetAudienceDal educationTargetAudienceDal)
        {
            _educationTargetAudienceDal = educationTargetAudienceDal;
        }

        public IResult Add(EducationTargetAudience targetAudience)
        {
            _educationTargetAudienceDal.Add(targetAudience);
            return new SuccessResult();
        }

        public IResult Delete(EducationTargetAudience targetAudience)
        {
            _educationTargetAudienceDal.Delete(targetAudience);
            return new SuccessResult();
        }

        public IDataResult<EducationTargetAudience> Get(int id)
        {
            return new SuccessDataResult<EducationTargetAudience>(_educationTargetAudienceDal.Get(p => p.Id == id));
        }

        public IDataResult<List<EducationTargetAudience>> GetAll()
        {
            return new SuccessDataResult<List<EducationTargetAudience>>(_educationTargetAudienceDal.GetAll());
        }

        public IResult Update(EducationTargetAudience targetAudience)
        {
            _educationTargetAudienceDal.Update(targetAudience);
            return new SuccessResult();
        }
    }
}
