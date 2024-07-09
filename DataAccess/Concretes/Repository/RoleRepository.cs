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

public class RoleRepository: EfRepositoryBase<Role,int,BaseDbContext>,IRoleRepository
{
    public RoleRepository(BaseDbContext context):base(context)
    {
        
    }
}
