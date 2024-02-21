using EntityCoreLesson.Application.MyServices.CompanyService;
using EntityCoreLesson.Domain.DTOs;
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
    }
}
