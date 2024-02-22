using Business.Abstract;
using Business.Constant;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class EducationManager : IEducationService
    {
        IEducationDal _educationDal;

        public EducationManager(IEducationDal educationDal)
        {
            _educationDal = educationDal;
        }

        public IResult Add(Education education)
        {
            _educationDal.Add(education);
            return new SuccessResult(Messages.EducationAdd);
        }

        public IResult Delete(Education education)
        {
            _educationDal.Delete(education);
            return new SuccessResult(Messages.EducationDelete);
        }

        public IDataResult<Education> Get(int educationId)
        {
            return new SuccessDataResult<Education>(_educationDal.Get(p => p.Id == educationId), Messages.EducationGet);
        }

        public IDataResult<List<Education>> GetAll()
        {
            return new SuccessDataResult<List<Education>>(_educationDal.GetAll(), Messages.EducationListed);
        }

        public IDataResult<List<EducationDto>> GetAllEducationDetails()
        {
            return new SuccessDataResult<List<EducationDto>>(_educationDal.GetAllEducationDetails(), Messages.GetAllEducationDetails)
        }

        public IDataResult<EducationDto> GetEducationDetail(int educationId)
        {
            return new SuccessDataResult<EducationDto>(_educationDal.GetEducationDetail(p => p.Id == educationId), Messages.GetEducationDetail)
        }

        public IResult Update(Education education)
        {
            _educationDal.Update(education);
            return new SuccessResult(Messages.EducationUpdate);
        }
    }
}
