using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
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
    public class User2Manager:IUser2Service
    {
        IUser2Dal _userdal;

        public User2Manager(IUser2Dal userDal)
        {
            _userdal = userDal;
        }

        [SecuredOperation("user.add,admin")]
        [ValidationAspect(typeof(UserValidator))]
        public IResult Add(User2 user)
        {
            _userdal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Delete(User2 user)
        {
            _userdal.Delete(user);
            return new SuccessResult(Messages.UserDeleted);
        }

        public IDataResult<List<User2>> GetAll()
        {
            return new SuccessDataResult<List<User2>>(_userdal.GetAll(), Messages.UserListed);
        }

        public IDataResult<User2> GetUserById(int userId)
        {
            return new SuccessDataResult<User2>(_userdal.Get(c => c.UserId == userId), Messages.UserGetById);
        }

        public IResult Update(User2 user)
        {
            _userdal.Update(user);
            return new SuccessResult(Messages.UserUpdated);
        }
    }
}
