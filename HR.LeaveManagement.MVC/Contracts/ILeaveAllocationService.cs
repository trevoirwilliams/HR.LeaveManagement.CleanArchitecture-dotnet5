using HR.LeaveManagement.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR.LeaveManagement.MVC.Contracts
{
    public interface ILeaveAllocationService
    {
        Task<List<ViewLeaveAllocationsVM>> GetLeaveAllocations();
        Task<List<LeaveAllocationVM>> GetLeaveAllocationDetails(int id);
        Task CreateLeaveAllocation(CreateLeaveAllocationVM leaveAllocation);
        Task UpdateLeaveAllocation(UpdateLeaveAllocationVM leaveAllocation);
        Task DeleteLeaveAllocation(int id);
    }
}
