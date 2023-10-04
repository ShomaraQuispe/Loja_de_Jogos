using Loja_de_Games.Model;

namespace Loja_de_Games.Service
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAll();
        Task<User?> GetById(long id);
        Task<User> GetByUsuario(string usuario);
        Task<User?> Create(User usuario);
        Task<User?> Update(User usuario);
    }
}
