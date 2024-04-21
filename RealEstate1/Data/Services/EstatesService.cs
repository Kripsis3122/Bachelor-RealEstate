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
        public void Add(Estate estate)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Estate>> GetAll()
        {
            var result = await _context.Estates.ToListAsync();
            return result;
        }

        public Estate GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Estate Update(int id, Estate newEstate)
        {
            throw new NotImplementedException();
        }
    }
}
