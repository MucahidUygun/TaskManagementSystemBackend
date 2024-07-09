using Business.Dtos.UserDtos.Requests;
using Business.Dtos.UserDtos.Responses;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts;

public interface IUserService
{
    public Task<IDataResult<List<UserGetAllResponse>>> GetAllAsync();
    public Task<IDataResult<UserGetByIdResponse>> GetByIdAsync(int id);

    public Task<IDataResult<UserCreatedResponse>> AddAsync(UserCreateReqeust reqeust);
}
