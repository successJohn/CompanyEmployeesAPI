using AutoMapper;
using CompanyEmployee.Entities.DTO;
using CompanyEmployee.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyEmployee.API.Controllers
{
    [Route("api/companies/{companyId}/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;



        public EmployeesController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        [HttpGet]

        public IActionResult GetEmployeesForCompany(Guid companyId)
        {
            var company = _unitOfWork.Company.GetCompany(companyId);
            if(company == null)
            {
                return NotFound();
            }

            var employees = _unitOfWork.Employee.GetEmployees(companyId);

            var employeesDto = _mapper.Map<IEnumerable<EmployeeDTO>>(employees);
            return Ok(employeesDto);

        }
    }
}
