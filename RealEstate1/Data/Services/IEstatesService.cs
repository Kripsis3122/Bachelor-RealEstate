using RealEstate1.Models;

namespace RealEstate1.Data.Services
{
    public interface IEstatesService
    {
        Task<IEnumerable<Estate>> GetAll();
        Estate GetById(int id);
        void Add(Estate estate);
        Estate Update(int id, Estate newEstate);
        void Delete(int id);
    }
}
