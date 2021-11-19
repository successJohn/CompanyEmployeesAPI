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
    [Route("api/companies")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public CompaniesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult GetCompanies()
        {
            try
            {
                var companies = _unitOfWork.Company.GetAllCompanies();
                var companiesDto = companies.Select(c => new CompanyDTO
                {
                    Id = c.Id,
                    Name = c.Name,
                    FullAddress = string.Join(" ", c.Address, c.Country)
                }).ToList();
                return Ok(companiesDto);
            }catch(Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}
