using CompanyEmployee.Entities.Models;
using CompanyEmployee.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyEmployee.Services.Implementation
{
    class EmployeeService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IRepository<Employee> _employeeRepo;


        public EmployeeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _employeeRepo = unitOfWork.GetRepository<Employee>();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeRepo.GetAll().AsEnumerable();
        }

    }
}
