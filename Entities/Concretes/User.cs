using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes;

public class User:IEntity
{
    public string UserName { get; set; }
    public string Password { get; set; }
    public int RoleId { get; set; }

    public virtual Role Role { get; set; }
}
