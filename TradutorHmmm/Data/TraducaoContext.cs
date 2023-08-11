using Microsoft.EntityFrameworkCore;
using TradutorHmmm.Models;

namespace TradutorHmmm.Data

{
    public class TraducaoContext : DbContext
    {
        public TraducaoContext(DbContextOptions<TraducaoContext> options) : base(options)
        {
        }

        public DbSet<Traducao> Traducaos { get; set; }
    }
}
