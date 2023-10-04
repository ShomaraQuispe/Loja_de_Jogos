using FluentValidation;
using Loja_de_Games.Model;

namespace Loja_de_Games.Validator
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator() {

            RuleFor(u => u.Nome)
                .NotEmpty()
                .MaximumLength(255);

            RuleFor(u => u.Usuario)
               .NotEmpty()
               .EmailAddress();

            RuleFor(u => u.Senha)
                .NotEmpty()
                .MinimumLength(8);

            RuleFor(u => u.Foto)
                .MaximumLength(5000);
        }
    }
}
