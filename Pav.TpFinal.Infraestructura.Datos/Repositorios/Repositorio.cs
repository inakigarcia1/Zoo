using Microsoft.EntityFrameworkCore;
using Pav.TpFinal.Dominio.Entidades;
using Pav.TpFinal.Dominio.Repositorios;
using System.Linq.Expressions;

namespace Pav.TpFinal.Infraestructura.Datos.Repositorios;

public class Repositorio : IRepositorio
{
    private readonly PavTpFinalContext _dbContext;
    public Repositorio(PavTpFinalContext context)
    {
        ArgumentNullException.ThrowIfNull(context);
        _dbContext = context;
    }

    public void Actualizar<TEntity>(TEntity entidad) where TEntity : EntityBase
    {
        _dbContext.Update(entidad);
        _dbContext.SaveChanges();
    }

    public void Agregar<TEntity>(TEntity entidad) where TEntity : EntityBase
    {
        _dbContext.Set<TEntity>().Add(entidad);
        _dbContext.SaveChanges();
    }

    public void Dispose()
    {
        _dbContext.Dispose();
        GC.SuppressFinalize(this);
    }

    public void Eliminar<TEntity>(TEntity entidad) where TEntity : EntityBase
    {
        _dbContext.Set<TEntity>().Remove(entidad);
        _dbContext.SaveChanges();
    }

    public List<TEntity> Listar<TEntity>(Expression<Func<TEntity, bool>> predicado, params string[] incluidos)
        where TEntity : EntityBase
    {
        return Incluir(_dbContext.Set<TEntity>(), incluidos).Where(predicado).ToList();
    }

    public List<TEntity> ListarTodos<TEntity>(params string[] incluidos) where TEntity : EntityBase
    {
        return Incluir(_dbContext.Set<TEntity>(), incluidos).ToList();
    }

    public TEntity? ObtenerElPrimero<TEntity>(Expression<Func<TEntity, bool>> predicado, params string[] incluidos)
         where TEntity : EntityBase
    {
        return Incluir(_dbContext.Set<TEntity>(), incluidos).FirstOrDefault(predicado);
    }

    public TEntity? ObtenerPorId<TEntity>(Guid? id, params string[] incluidos) where TEntity : EntityBase
    {
        return Incluir(_dbContext.Set<TEntity>(), incluidos).SingleOrDefault(e => e.Id == id);
    }

    private IQueryable<TEntity> Incluir<TEntity>(IQueryable<TEntity> consulta, string[] incluidos)
        where TEntity : EntityBase
    {
        var incluidosConsulta = consulta;

        foreach (var incluido in incluidos)
        {
            incluidosConsulta = incluidosConsulta.Include(incluido);
        }
        return incluidosConsulta;
    }
}
