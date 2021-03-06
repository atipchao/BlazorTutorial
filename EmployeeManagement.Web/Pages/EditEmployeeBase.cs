﻿using EmployeeManagement.Models;
using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.DataProtection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EditEmployeeBase : ComponentBase
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        public Employee Employee { get; set; } = new Employee();
        [Inject]
        public IDepartmentService DepartmentService { get; set; }
        public List<Department> Departments { get; set; } = new List<Department>();

        //since we added CustomInputSelect by Overriding base class, Now we dotn need 
        //DepartmentId variable below..
        //public string  DepartmentId { get; set; }

        [Parameter]
        public string Id  { get; set; }

        protected async override Task OnInitializedAsync()
        {
            //return base.OnInitializedAsync();
            Employee = await EmployeeService.GetEmployee(int.Parse(Id));
            Departments = (await DepartmentService.GetDepartments()).ToList();
            //since we added CustomInputSelect by Overriding base class, Now we dotn need 
            //DepartmentId variable below..
            //DepartmentId = Employee.DepartmentId.ToString(); // This variable will be binded in the form in InputSelect Dept
        }

    }
}
