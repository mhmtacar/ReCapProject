using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramewok
{
    public class EfUser2Dal:EfEntityRepositoryBase<User2, ReCapContext>, IUser2Dal
    {
    }
}
