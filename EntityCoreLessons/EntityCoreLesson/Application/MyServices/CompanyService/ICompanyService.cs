using EntityCoreLesson.Domain.DTOs;
using EntityCoreLesson.Domain.Models;

namespace EntityCoreLesson.Application.MyServices.CompanyService
{
    public interface ICompanyService
    {
        public Task<string> CreateCompanyAsync(CompanyDTO cmp);
        public Task<IEnumerable<Company>> GetAllCompanysAsync();
        public Task<Company> GetCompanyByIdAsync(int id);
        public Task<bool> DeleteCompanyByIdAsync(int id);
        public Task<bool> UpdateCompanyById(int id, CompanyDTO company);
    }
}
