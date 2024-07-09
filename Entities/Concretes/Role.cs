using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes;

public class Role : IEntity
{
    public string Name { get; set; }
    public ICollection<User> Users { get; set; }

    public Role()
    {
        Users = new HashSet<User>();
    }
}
