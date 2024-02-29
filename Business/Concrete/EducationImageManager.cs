using Business.Abstract;
using Business.Constant;
using Core.Utilities.Helper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class EducationImageManager : IEducationImageService
    {
        IEducationImageDal _educationImageDal;

        public EducationImageManager(IEducationImageDal educationImageDal)
        {
            _educationImageDal = educationImageDal;
        }

        public IResult Add(IFormFile file, EducationImage educationImage)
        {

            educationImage.EducationImagePath = ImageAndVideoHelper.Add(file);
            educationImage.Date = DateTime.Now;
            _educationImageDal.Add(educationImage);
            return new SuccessResult(Messages.EducationImageAdd);
        }

        public IResult AddCollection(IFormFile[] files, EducationImage educationImage)
        {
            foreach (var file in files)
            {
                educationImage = new EducationImage { EducationId = educationImage.EducationId };
                Add(file, educationImage);
            }
            return new SuccessResult(Messages.EducationImageAdd);
        }

        public IResult Delete(EducationImage educationImage)
        {
            _educationImageDal.Delete(educationImage);
            return new SuccessResult(Messages.EducationImageDelete);
        }

        public IDataResult<EducationImage> Get(int educationId)
        {
            return new SuccessDataResult<EducationImage>(_educationImageDal.Get(p => p.EducationId == educationId), Messages.GetEducationImage);
        }

        public IDataResult<List<EducationImage>> GetAll()
        {
            return new SuccessDataResult<List<EducationImage>>(_educationImageDal.GetAll(), Messages.EducationImageListed);
        }

        public IResult Update(EducationImage educationImage)
        {
            _educationImageDal.Update(educationImage);
            return new SuccessResult(Messages.EducationImageUpdated);
        }
    }
}
