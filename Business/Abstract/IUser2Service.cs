using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUser2Service
    {
        IResult Add(User2 user);
        IResult Delete(User2 user);
        IResult Update(User2 user);
        IDataResult<List<User2>> GetAll();
        IDataResult<User2> GetUserById(int userId);
    }
}
