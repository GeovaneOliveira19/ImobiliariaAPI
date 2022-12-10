using Microsoft.EntityFrameworkCore;

namespace ImobiliariaAPI.Dados
{
    public class DadosBase : DbContext
    {
        public DadosBase(DbContextOptions<DadosBase> options) : base(options)
        {

        }

        public DbSet<Imovel> Imoveis { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<TipoImovel> TipoImoveis { get; set; }
    }
}
