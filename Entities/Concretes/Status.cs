using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes;

public class Status : IEntity
{
    public string Name { get; set; }
    public ICollection<Duty> Duties { get; set; }

    public Status()
    {
        Duties = new HashSet<Duty>();
    }
}
