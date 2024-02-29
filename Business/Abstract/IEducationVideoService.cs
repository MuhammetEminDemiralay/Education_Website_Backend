using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface IEducationVideoService
    {
        IDataResult<List<EducationVideo>> GetAll();
        IDataResult<EducationVideo> Get(int id);
        IResult Add(IFormFile file,EducationVideo educationVideo);
        IResult AddCollection(IFormFile[] files, EducationVideo educationVideo);
        IResult Update(EducationVideo educationVideo);
        IResult Delete(EducationVideo educationVideo);
    }
}
