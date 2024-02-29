using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IVideoTitleService
    {
        IDataResult<List<VideoTitle>> GetAll();
        IDataResult<VideoTitle> Get(int id);
        IResult Add(VideoTitle videoTitle);
        IResult Update(VideoTitle videoTitle);
        IResult Delete(VideoTitle videoTitle);
    }
}
