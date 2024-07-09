using AutoMapper;
using Business.Abstracts;
using Business.Dtos.UserDtos.Requests;
using Business.Dtos.UserDtos.Responses;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class UserManager : IUserService
{
    private readonly IUserRepository _repository;
    private readonly IMapper _mapper;

    public UserManager(IUserRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IDataResult<UserCreatedResponse>> AddAsync(UserCreateReqeust reqeust)
    {
        User user = _mapper.Map<User>(reqeust);
        await _repository.AddAsync(user);
        UserCreatedResponse response = _mapper.Map<UserCreatedResponse>(user);
        return new SuccessDataResult<UserCreatedResponse>(response);
    }

    public async Task<IDataResult<List<UserGetAllResponse>>> GetAllAsync()
    {
        List<UserGetAllResponse> responses = _mapper.Map<List<UserGetAllResponse>>(await _repository.GetAllAsync());

        return new SuccessDataResult<List<UserGetAllResponse>>(responses);
    }

    public async Task<IDataResult<UserGetByIdResponse>> GetByIdAsync(int id)
    {
        UserGetByIdResponse response = _mapper.Map<UserGetByIdResponse>(await _repository.GetAsync(x=>x.Id==id));

        return new SuccessDataResult<UserGetByIdResponse>(response);
    }
}
