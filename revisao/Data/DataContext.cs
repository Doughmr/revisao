using Microsoft.EntityFrameworkCore;
using revisao.Models;

namespace revisao.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }   

        public DbSet<Conta> Contas { get; set; }
    }
}
