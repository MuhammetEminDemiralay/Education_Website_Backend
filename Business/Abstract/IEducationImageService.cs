using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IEducationImageService
    {
        IDataResult<List<EducationImage>> GetAll();
        IDataResult<EducationImage> Get(int educationId);
        IResult Add(IFormFile file, EducationImage educationImage);
        IResult AddCollection(IFormFile[] files, EducationImage educationImage);
        IResult Update(EducationImage educationImage);
        IResult Delete(EducationImage educationImage);
    }
}
