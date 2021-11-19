using CompanyEmployee.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyEmployee.Services.Interfaces
{
    public interface ICompanyService
    {
        public IEnumerable<Company> GetAllCompanies();
    }
}
