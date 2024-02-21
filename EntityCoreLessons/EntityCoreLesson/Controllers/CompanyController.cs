using EntityCoreLesson.Application.MyServices.CompanyService;
using EntityCoreLesson.Domain.DTOs;
using EntityCoreLesson.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntityCoreLesson.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        public ICompanyService _comService;
        public CompanyController(ICompanyService comS)
        {
            _comService = comS;
        }
        [HttpPost]
        public async Task<string> Create(CompanyDTO cmp)
        {
            try
            {
                return await _comService.CreateCompanyAsync(cmp);
            }
            catch
            {
                return "Error";
            }
        }
        [HttpGet]
        public async Task<IEnumerable<Company>> GetAllCompaniesAsync()
        {
            try
            {
                return await _comService.GetAllCompanysAsync();
            }
            catch
            {
                return Enumerable.Empty<Company>();
            }
        }
        [HttpGet]
        public async Task<Company> GetCompanyByIdAsync(int id)
        {
            try
            {
                return await _comService.GetCompanyByIdAsync(id);
            }
            catch
            {
                return new Company() { };
            }
        }
        [HttpDelete]
        public async Task<bool> DeleteCompanyByIdAsync(int id)
        {
            try
            {
                return await _comService.DeleteCompanyByIdAsync(id);
            }
            catch
            {
                return false;
            }
        }
        [HttpPut]
        public async Task<bool> UpdateCompanyByIdAsync(int id,CompanyDTO company)
        {
            try
            {
                return await _comService.UpdateCompanyById(id, company);
            }
            catch
            {
                return false;
            }
        }
    }
}
