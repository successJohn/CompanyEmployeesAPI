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
    [Route("api/companies")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CompaniesController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetCompanies()
        {
            try
            {
                var companies = _unitOfWork.Company.GetAllCompanies();
                var companiesDto = _mapper.Map<IEnumerable<CompanyDTO>>(companies);
                return Ok(companiesDto);
            }catch(Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}
