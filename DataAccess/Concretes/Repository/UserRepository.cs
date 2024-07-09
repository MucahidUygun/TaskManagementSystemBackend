using Core.DataAccess.EntityFramework.EfRespositoryBase;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework.Contexts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.Repository;

public class UserRepository : EfRepositoryBase<User,int,BaseDbContext>,IUserRepository
{
    public UserRepository(BaseDbContext context):base(context)
    {
        
    }
}
