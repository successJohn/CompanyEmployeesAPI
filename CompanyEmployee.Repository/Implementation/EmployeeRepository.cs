using CompanyEmployee.Entities;
using CompanyEmployee.Entities.Models;
using CompanyEmployee.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyEmployee.Repository.Implementation
{
    public class EmployeeRepository: Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(RepositoryContext repositoryContext)
                : base(repositoryContext)
        {
        }
    }
}
