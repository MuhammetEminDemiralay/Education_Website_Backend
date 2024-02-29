using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class VideoSubTitleManager : IVideoSubTitleService
    {
        IVideoSubTitleDal videoSubTitleDal;

        public VideoSubTitleManager(IVideoSubTitleDal videoSubTitleDal)
        {
            this.videoSubTitleDal = videoSubTitleDal;
        }

        public IResult Add(VideoSubTitle videoSubTitle)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(VideoSubTitle videoSubTitle)
        {
            throw new NotImplementedException();
        }

        public IDataResult<VideoSubTitle> Get(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<VideoSubTitle>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(VideoSubTitle videoSubTitle)
        {
            throw new NotImplementedException();
        }
    }
}
