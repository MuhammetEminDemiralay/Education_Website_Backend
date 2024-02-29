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
    public class VideoTitleManager : IVideoTitleService
    {
        IVideoTitleDal _videoTitleDal;

        public VideoTitleManager(IVideoTitleDal videoTitleDal)
        {
            _videoTitleDal = videoTitleDal;
        }

        public IResult Add(VideoTitle videoTitle)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(VideoTitle videoTitle)
        {
            throw new NotImplementedException();
        }

        public IDataResult<VideoTitle> Get(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<VideoTitle>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(VideoTitle videoTitle)
        {
            throw new NotImplementedException();
        }
    }
}
