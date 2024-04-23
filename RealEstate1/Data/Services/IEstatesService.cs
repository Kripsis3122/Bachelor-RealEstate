using RealEstate1.Models;

namespace RealEstate1.Data.Services
{
    public interface IEstatesService
    {
        Task<IEnumerable<Estate>> GetAllAsync();
        Task<Estate> GetByIdAsync(int id);
        Task AddAsync(Estate estate);
        Estate Update(int id, Estate newEstate);
        void Delete(int id);
    }
}
