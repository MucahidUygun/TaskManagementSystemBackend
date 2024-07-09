using AutoMapper;
using Business.Dtos.UserDtos.Requests;
using Business.Dtos.UserDtos.Responses;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.Users;

public class MappingProfiles:Profile
{
    public MappingProfiles()
    {
        CreateMap<User,UserCreateReqeust>().ReverseMap();

        CreateMap<User,UserGetAllResponse>().ReverseMap();
        CreateMap<User,UserGetByIdResponse>().ReverseMap();
        CreateMap<User,UserCreatedResponse>().ReverseMap();
    }
}
