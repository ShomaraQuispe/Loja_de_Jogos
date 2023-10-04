﻿using Loja_de_Games.Model;
using Microsoft.EntityFrameworkCore;

namespace Loja_de_Games.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){ }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().ToTable("tb_produtos");
            modelBuilder.Entity<Categoria>().ToTable("tb_categorias");
            modelBuilder.Entity<User>().ToTable("tb_usuarios");

            _ = modelBuilder.Entity<Produto>()
         .HasOne(_ => _.Categoria)
         .WithMany(t => t.Produto)
         .HasForeignKey("CategoriaId")
         .OnDelete(DeleteBehavior.Cascade);
        }
        public DbSet<Produto> Produtos { get; set; }=null!;
        public DbSet<Categoria> Categorias { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
    }
}
