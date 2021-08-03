using HR.LeaveManagement.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR.LeaveManagement.MVC.Contracts
{
    public interface ILeaveRequestService
    {
        Task CreateLeaveRequest(CreateLeaveRequestVM leaveRequest);
        Task DeleteLeaveRequest(int id);
    }
}
