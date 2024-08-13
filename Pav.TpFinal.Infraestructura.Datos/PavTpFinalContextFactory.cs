using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
namespace Pav.TpFinal.Infraestructura.Datos;
internal class PavTpFinalContextFactory : IDesignTimeDbContextFactory<PavTpFinalContext>
{
    public PavTpFinalContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<PavTpFinalContext>();
        optionsBuilder.UseSqlServer(PavTpFinalContext.CadenaDeConexion);

        return new PavTpFinalContext(optionsBuilder.Options);
    }
}
