using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using VendasLanches03.Models;

namespace VendasLanches03.Context
{
    public class APPDbContext: DbContext
    {
        public APPDbContext(DbContextOptions<APPDbContext> options) : base(options) 
        { 
        
        }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Lanche> Lanches { get; set; }

        public DbSet<CarrinhoCompraItem> CarrinhoCompraItems { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }

        public DbSet<DetalhePedido> DetalhePedidos { get; set; }


    }
}
