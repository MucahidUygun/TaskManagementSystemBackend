using AutoMapper;
using Business.Dtos.DutyDtos.Request;
using Business.Dtos.DutyDtos.Response;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.Dutys;

public class MappingProfiles:Profile
{
    public MappingProfiles()
    {
        CreateMap<Duty,DutyCreateRequest>().ReverseMap();
        CreateMap<Duty, DutyUpdateRequest>().ReverseMap();
        CreateMap<Duty, DutyDeleteRequest>().ReverseMap();

        CreateMap<Duty, DutyCreatedResponse>().ReverseMap();
        CreateMap<Duty, DutyUpdatedResponse>().ReverseMap();
        CreateMap<Duty, DutyDeletedResponse>().ReverseMap();
        CreateMap<Duty, DutyGetAllResponse>().ReverseMap();
        CreateMap<Duty, DutyGetByIdResponse>().ReverseMap();
    }
}
