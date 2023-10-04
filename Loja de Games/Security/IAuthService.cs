using Loja_de_Games.Model;

namespace Loja_de_Games.Security
{
    public interface IAuthService
    {
        Task<UserLogin?> Autenticar(UserLogin userLogin);
    }
}
