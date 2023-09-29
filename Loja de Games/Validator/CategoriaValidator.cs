using FluentValidation;
using Loja_de_Games.Model;

namespace Loja_de_Games.Validator
{
    public class CategoriaValidator : AbstractValidator<Categoria>
    {
        public CategoriaValidator()
        {
            RuleFor(p => p.Tipo)
                .NotEmpty()
                .MinimumLength(5)
                .MaximumLength(255);
        }
    }
}
