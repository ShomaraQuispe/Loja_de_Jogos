using FluentValidation;
using Loja_de_Games.Model;

namespace Loja_de_Games.Validator
{
    public class ProdutoValidator : AbstractValidator<Produto>
    {
        public ProdutoValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .MinimumLength(5)
                .MaximumLength(100);

            RuleFor(p => p.Descricao)
                .NotEmpty()
                .MinimumLength(5)
                .MaximumLength(255);

            RuleFor(p => p.Console)
                .NotEmpty()
                .MinimumLength(1)
                .MaximumLength(100);

            RuleFor(p => p.Preco)
                .NotEmpty()
                .GreaterThan(0)
                .PrecisionScale(20, 2, false);

            RuleFor(p => p.Foto)
                .NotEmpty()
                .MinimumLength(3)
                .MaximumLength(2000);

        }
    }
}
