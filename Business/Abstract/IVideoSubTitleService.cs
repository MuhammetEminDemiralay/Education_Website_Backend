using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IVideoSubTitleService
    {
        IDataResult<List<VideoSubTitle>> GetAll();
        IDataResult<VideoSubTitle> Get(int id);
        IResult Add(VideoSubTitle videoSubTitle);
        IResult Update(VideoSubTitle videoSubTitle);
        IResult Delete(VideoSubTitle videoSubTitle);
    }
}
