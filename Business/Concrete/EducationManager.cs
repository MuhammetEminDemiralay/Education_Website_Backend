using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class EducationManager : IEducationService
    {
        public IResult Add(Education education)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Education education)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Education> Get(int educationId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Education>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Education education)
        {
            throw new NotImplementedException();
        }
    }
}
