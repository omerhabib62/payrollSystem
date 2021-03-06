﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PayrollSystem.model;

namespace PayrollSystem.service
{
    public interface RequestServiceInterface
    {
        List<Request> fetchOvertimeRequests(Employee employee, DateTime startDatePeriod, DateTime endDatePeriod);

        List<Request> fetchLeaveRequest(Employee employee, DateTime startDatePeriod, DateTime endDatePeriod);

        List<Request> fetchAllPendingRequests();

        Request fetchPendingRequestById(int requestId);

        Request updateRequestStatusById(int requestId, string status);

        Request fetchById(int requestId);

        List<Request> fetchAllApprovedRequests();

        Request createRequest(Request request);

        List<Request> fetchPendingRequestByEmployee(Employee employee);

        List<Request> fetchApprovedRequestByEmployee(Employee employee);

        Request fetchEmployeeApprovedOvertimeRequestByDate(Employee employee, DateTime date);

        TimeSpan fetchTotalHoursOvertimeSpent(DateTime startDatePeriod, DateTime endDatePeriod, Employee employee);

        List<Request> fetchAllApprovedCashAdvanceRequests(DateTime startDatePeriod, DateTime endDatePeriod, Employee employee);
    }
}
