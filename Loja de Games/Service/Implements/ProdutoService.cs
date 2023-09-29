using Loja_de_Games.Model;
using Loja_de_Games.Data;
using Microsoft.EntityFrameworkCore;

namespace Loja_de_Games.Service.Implements
{
    public class ProdutoService : IProdutoService
    {
        public readonly AppDbContext _context;

        public ProdutoService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Produto?> Create(Produto produto)
        {
            if (produto.Categoria is not null)
            {
                var BuscaCategoria = await _context.Categorias.FindAsync(produto.Categoria.Id);

                if (BuscaCategoria is null)
                    return null;
            }

            produto.Categoria = produto.Categoria is not null ? _context.Categorias.FirstOrDefault(t => t.Id == produto.Categoria.Id) : null;
            await _context.Produtos.AddAsync(produto);
            await _context.SaveChangesAsync();

            return produto;
        }

        public async Task Delete(Produto produto)
        {
            _context.Produtos.Remove(produto);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Produto>> GetAll()
        {
            return await _context.Produtos.ToListAsync();
        }

        public async Task<IEnumerable<Produto>> GetByConsole(string console)
        {
            var Produto = await _context.Produtos
                .Where(p => p.Console.Contains(console))
                .ToListAsync();
            return Produto;
        }

        public async Task<Produto?> GetById(long id)
        {
            try
            {
                var Produto = await _context.Produtos.FirstOrDefaultAsync(i => i.Id == id);
                return Produto;
            }
            catch

            {
                return null;
            }
        }

        public async Task<Produto?> Update(Produto produto)
        {
            var produtoUpdate = await _context.Produtos.FindAsync(produto.Id);

            if (produtoUpdate is null)
            {
                return null;
            }
            if (produto.Categoria is not null)
            {
                var BuscaCategoria = await _context.Produtos.FindAsync(produto.Categoria.Id);

                if (BuscaCategoria is null)
                    return null;
            }

            _context.Entry(produtoUpdate).State = EntityState.Detached;
            _context.Entry(produto).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return produto;
        }
    }
}
