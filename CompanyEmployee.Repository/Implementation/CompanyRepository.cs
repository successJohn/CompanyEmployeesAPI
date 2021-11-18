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
    public class CompanyRepository : Repository<Company> , ICompanyRepository
    {
        public CompanyRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {

        }
    }
}
