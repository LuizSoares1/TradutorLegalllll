using Microsoft.EntityFrameworkCore;
using TradutorHmmm.Models;

namespace TradutorHmmm.Data
    //Conexão com o banco de dados, nd mais e nd menos que isso, apenas repliquei o que aprendi no curso da Alura. ENTITYFRAMECARALHOBTW...
{
    public class TraducaoContext : DbContext
    {
        public TraducaoContext(DbContextOptions<TraducaoContext> options) : base(options)
        {
        }

        public DbSet<Traducao> Traducaos { get; set; }
    }
}
