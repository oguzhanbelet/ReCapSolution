﻿using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
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
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        //public IResult Add(User user)
        //{
        //    _userDal.Add(user);
        //    return new SuccessResult(Messages.UserAdded);
        //}

        //public IResult Delete(User user)
        //{
        //    try
        //    {
        //        _userDal.Delete(user);
        //        return new SuccessResult(Messages.UserDeleted);
        //    }
        //    catch (Exception)
        //    {
        //        return new ErrorResult(Messages.UserCantDeleted);
        //    }
        //}

        //public IDataResult<List<User>> GetAll()
        //{
        //    return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.UsersListed);
        //}

        //public IDataResult<User> GetById(int userId)
        //{
        //    return new SuccessDataResult<User>(_userDal.Get(u => u.UserId == userId), Messages.UserListed);
        //}

        //public IResult Update(User user)
        //{
        //    try
        //    {
        //        _userDal.Update(user);
        //        return new SuccessResult(Messages.UserUpdated);
        //    }
        //    catch (Exception)
        //    {
        //        return new ErrorResult(Messages.UserCantUpdated);
        //    }
        //}
    }
}
