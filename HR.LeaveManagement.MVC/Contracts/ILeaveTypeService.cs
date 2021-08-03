using HR.LeaveManagement.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR.LeaveManagement.MVC.Contracts
{
    public interface ILeaveTypeService
    {
        Task<List<LeaveTypeVM>> GetLeaveTypes();
        Task<LeaveTypeVM> GetLeaveTypeDetails(int id);
        Task CreateLeaveType(LeaveTypeVM leaveType);
        Task UpdateLeaveType(LeaveTypeVM leaveType);
        Task DeleteLeaveType(LeaveTypeVM leaveType);
    }
}
