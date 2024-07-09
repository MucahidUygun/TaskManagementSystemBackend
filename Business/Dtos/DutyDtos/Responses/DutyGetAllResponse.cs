using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.DutyDtos.Response;

public class DutyGetAllResponse
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreationDate { get; set; }
    public int StatusId { get; set; }
    public int UserId { get; set; }
}
