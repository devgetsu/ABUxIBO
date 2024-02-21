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

        public async Task<bool> DeleteCompanyByIdAsync(int id)
        {
            try
            {
                var md = await _context.Companys.FirstOrDefaultAsync(x => x.Id == id);
                if (md != null)
                {
                    _context.Companys.Remove(md);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
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

        public async Task<Company> GetCompanyByIdAsync(int id)
        {
            try
            {
                var md = await _context.Companys.FirstOrDefaultAsync(x => x.Id == id);
                if (md != null)
                {
                    return md;
                }
                return new Company() { };
            }
            catch
            {
                return new Company() { };
            }
        }

        public async Task<bool> UpdateCompanyById(int id, CompanyDTO company)
        {
            try
            {
                var md = await _context.Companys.FirstOrDefaultAsync(x => x.Id == id);
                if (md != null)
                {
                    md.Name = company.Name;
                    md.Description = company.Description;
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
