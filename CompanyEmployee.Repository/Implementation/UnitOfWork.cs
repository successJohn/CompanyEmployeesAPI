using CompanyEmployee.Entities;
using CompanyEmployee.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyEmployee.Repository.Implementation
{
    public class UnitOfWork: IUnitOfWork
    {
        private RepositoryContext _repositoryContext;

        private ICompanyRepository _companyRepository;

        private IEmployeeRepository _employeeRepository;

        public UnitOfWork(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public ICompanyRepository Company
        {
            get
            {
                return _companyRepository ??= new CompanyRepository(_repositoryContext);
              
            }
        }
        public IEmployeeRepository Employee
        {
            get
            {
                if (_employeeRepository == null)
                    _employeeRepository = new EmployeeRepository(_repositoryContext);
                return _employeeRepository;
            }
        }

        public void Save() => _repositoryContext.SaveChanges();
    }
}
