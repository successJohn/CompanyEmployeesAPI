using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyEmployee.Repository.Interfaces
{
    public interface IUnitOfWork
    {
        ICompanyRepository Company { get; }
        IEmployeeRepository Employee { get; }

        void Save();

        
    }
}
