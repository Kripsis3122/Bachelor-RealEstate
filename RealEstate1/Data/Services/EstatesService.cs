using Microsoft.EntityFrameworkCore;
using RealEstate1.Models;

namespace RealEstate1.Data.Services
{
    public class EstatesService : IEstatesService
    {
        private readonly AppDbContext _context;
        public EstatesService(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Estate estate)
        {
            await _context.Estates.AddAsync(estate);
            await _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Estate>> GetAllAsync()
        {
            var result = await _context.Estates.ToListAsync();
            return result;
        }

        public async Task<Estate> GetByIdAsync(int id)
        {
            var result = await _context.Estates.FirstOrDefaultAsync(e => e.Id == id);
            return result;
        }

        public async Task<Estate> EditAsync(int id, Estate newEstate)
        {
            _context.Update(newEstate);
            await _context.SaveChangesAsync();
            return newEstate;
        }
    }
}
