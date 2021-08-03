using AutoMapper;
using HR.LeaveManagement.MVC.Contracts;
using HR.LeaveManagement.MVC.Models;
using HR.LeaveManagement.MVC.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR.LeaveManagement.MVC.Services
{
    public class LeaveTypeService : BaseHttpService//, ILeaveTypeService
    {
        private readonly ILocalStorageService _localStorageService;
        private readonly IMapper _mapper;
        private readonly IClient _httpclient;

        public LeaveTypeService(IMapper mapper, IClient httpclient, ILocalStorageService localStorageService) : base(httpclient, localStorageService)
        {
            this._localStorageService = localStorageService;
            this._mapper = mapper;
            this._httpclient = httpclient;
        }

        public async Task<Response<CreateLeaveTypeDto>> CreateLeaveType(LeaveTypeVM leaveType)
        {
            try
            {
                CreateLeaveTypeDto createLeaveType = _mapper.Map<CreateLeaveTypeDto>(leaveType);
                await _client.LeaveTypesPOSTAsync(createLeaveType);
                return new Response<CreateLeaveTypeDto> { Success = true };
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<CreateLeaveTypeDto>(ex);
            }
        }

        public Task DeleteLeaveType(LeaveTypeVM leaveType)
        {
            throw new NotImplementedException();
        }

        public async Task<LeaveTypeVM> GetLeaveTypeDetails(int id)
        {
            var leaveType = await _client.LeaveTypesGETAsync(id);
            return _mapper.Map<LeaveTypeVM>(leaveType);
        }

        public async Task<List<LeaveTypeVM>> GetLeaveTypes()
        {
            var leaveTypes = await _client.LeaveTypesAllAsync();
            return _mapper.Map<List<LeaveTypeVM>>(leaveTypes);
        }

        public Task UpdateLeaveType(LeaveTypeVM leaveType)
        {
            throw new NotImplementedException();
        }
    }
}
