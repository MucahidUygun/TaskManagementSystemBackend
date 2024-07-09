﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.UserDtos.Responses;

public class UserUpdatedResponse
{
    public string UserName { get; set; }
    public string Password { get; set; }
    public DateTime UpdatedDate { get; set; }
}
