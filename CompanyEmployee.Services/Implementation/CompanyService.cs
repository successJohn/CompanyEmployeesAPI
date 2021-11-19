using CompanyEmployee.Entities.Models;
using CompanyEmployee.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyEmployee.Services.Implementation
{
    public class CompanyService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IRepository<Company> _companyRepo;


        public CompanyService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
           // _companyRepo = unitOfWork.GetRepository<Company>();
        }

        public IEnumerable<Company> GetAllEmployees()
        {
            return _companyRepo.GetAll().AsEnumerable();
        }
    }
}
