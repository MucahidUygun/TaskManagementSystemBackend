using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes;

public class Duty:IEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreationDate { get; set; }
    public int StatusId { get; set; }
    public int UserId { get; set; }
    public virtual Status Status { get; set; }
    public virtual User User { get; set; }
}
