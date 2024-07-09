using Business.Dtos.DutyDtos.Request;
using Business.Dtos.DutyDtos.Response;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts;

public interface IDutyService
{
    Task<IDataResult<List<DutyGetAllResponse>>> GetAllAsync();
    Task<IDataResult<DutyGetByIdResponse>> GetByIdAsync(int id);
    Task<IResult> DeleteAsync(DutyDeleteRequest request);
    Task<IDataResult<DutyUpdatedResponse>> UpdateAsync(DutyUpdateRequest request);
    Task<IDataResult<DutyCreatedResponse>> AddAync(DutyCreateRequest request);
}
