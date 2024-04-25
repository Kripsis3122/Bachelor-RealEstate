using RealEstate1.Models;

namespace RealEstate1.Data.Services
{
    public interface IEstatesService
    {
        Task<IEnumerable<Estate>> GetAllAsync();
        Task<Estate> GetByIdAsync(int id);
        Task AddAsync(Estate estate);
        Task<Estate> EditAsync(int id, Estate newEstate);
        void Delete(int id);
    }
}
