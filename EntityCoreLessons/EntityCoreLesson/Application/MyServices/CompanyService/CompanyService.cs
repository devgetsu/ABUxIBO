using EntityCoreLesson.Domain.DTOs;
using EntityCoreLesson.Domain.Models;
using EntityCoreLesson.Infastructure;
using Microsoft.EntityFrameworkCore;

namespace EntityCoreLesson.Application.MyServices.CompanyService
{
    public class CompanyService : ICompanyService
    {
        public ApplicationDbContext _context;
        public CompanyService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<string> CreateCompanyAsync(CompanyDTO cmp)
        {
            try
            {
                var model = new Company()
                {
                    Name = cmp.Name,
                    Description = cmp.Description,
                    Employee_count = cmp.Employee_count,
                };
                await _context.Companys.AddAsync(model);
                _context.SaveChanges();
                return "Yaratildi";
            }
            catch
            {
                return "Error";
            }
        }

        public Task<bool> DeleteCompanyByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Company>> GetAllCompanysAsync()
        {
            try
            {
                var x = await _context.Companys.ToListAsync();
                return x;
            }
            catch
            {
                return Enumerable.Empty<Company>();
            }
        }

        public Task<Company> GetCompanyByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateCompanyById(int id, CompanyDTO company)
        {
            throw new NotImplementedException();
        }
    }
}
