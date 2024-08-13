using Pav.TpFinal.Dominio.Excepciones;

namespace Pav.TpFinal.Dominio.Entidades;

public class Pais : EntityBase
{
    private string? _nombre;
    public string? Nombre
    {
        get => _nombre;
        init
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new DominioException("Nombre de país inválido.");
            }
            _nombre = value;
        }
    }
}
