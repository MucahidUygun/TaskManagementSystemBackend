using AutoMapper;
using Business.Abstracts;
using Business.Dtos.DutyDtos.Request;
using Business.Dtos.DutyDtos.Response;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using DataAccess.Concretes.Repository;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class DutyManager : IDutyService
{
    private readonly IDutyRepository _repository;
    private readonly IMapper _mapper;

    public DutyManager(IDutyRepository repository,IMapper mapper)
    {
        _repository = repository;
        _mapper=mapper;
    }

    public async Task<IDataResult<DutyCreatedResponse>> AddAync(DutyCreateRequest request)
    {
        Duty duty = _mapper.Map<Duty>(request);
        duty.CreationDate = DateTime.Now;
        await _repository.AddAsync(duty);
        DutyCreatedResponse response = _mapper.Map<DutyCreatedResponse>(duty);

        return new SuccessDataResult<DutyCreatedResponse>(response,"Başarılı");
    }

    public async Task<IResult> DeleteAsync(DutyDeleteRequest request)
    {
        Duty duty = await _repository.GetAsync(x=>x.Id==request.Id);
        await _repository.DeleteAsync(duty);

        return new SuccessResult("Başarılı");
    }

    public async Task<IDataResult<List<DutyGetAllResponse>>> GetAllAsync()
    {
        List<DutyGetAllResponse> duties = _mapper.Map<List<DutyGetAllResponse>>(await  _repository.GetAllAsync());

        return new SuccessDataResult<List<DutyGetAllResponse>>(duties);
    }

    public async Task<IDataResult<DutyGetByIdResponse>> GetByIdAsync(int id)
    {
        DutyGetByIdResponse duties = _mapper.Map<DutyGetByIdResponse>(await _repository.GetAsync(x=>x.Id==id));

        return new SuccessDataResult<DutyGetByIdResponse>(duties);
    }

    public async Task<IDataResult<DutyUpdatedResponse>> UpdateAsync(DutyUpdateRequest request)
    {
        Duty duty = await _repository.GetAsync(x=>x.Id==request.Id);
        _mapper.Map(request, duty);
        await _repository.UpdateAsync(duty);

        DutyUpdatedResponse dutyUpdated = _mapper.Map<DutyUpdatedResponse>(duty);
        return new SuccessDataResult<DutyUpdatedResponse>(dutyUpdated,"Güncellendi.");
    }
}
