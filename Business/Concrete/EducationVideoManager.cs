using Business.Abstract;
using Business.Constant;
using Core.Utilities.Helper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Concrete
{
    public class EducationVideoManager : IEducationVideoService
    {
        IEducationVideoDal _educationVideoDal;

        public EducationVideoManager(IEducationVideoDal educationVideoDal)
        {
            _educationVideoDal = educationVideoDal;
        }

        public IResult Add(IFormFile file, EducationVideo educationVideo)
        {
            educationVideo.EducationVideoPath = ImageAndVideoHelper.Add(file);
            educationVideo.Date = DateTime.Now;
            _educationVideoDal.Add(educationVideo);
            return new SuccessResult();
        }

        public IResult AddCollection(IFormFile[] files, EducationVideo educationVideo)
        {
            foreach(var file in files)
            {
                educationVideo = new EducationVideo { VideoSubTitleId = educationVideo.VideoSubTitleId };
                Add(file, educationVideo);
            }

            return new SuccessResult(Messages.EducationVideoAdded);
        }

        public IResult Delete(EducationVideo educationVideo)
        {
            throw new NotImplementedException();
        }

        public IDataResult<EducationVideo> Get(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<EducationVideo>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(EducationVideo educationVideo)
        {
            throw new NotImplementedException();
        }
    }
}
