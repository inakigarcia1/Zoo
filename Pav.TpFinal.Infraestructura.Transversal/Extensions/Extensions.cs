namespace Pav.TpFinal.Infraestructura.Transversal.Extensions;
public static class Extensions
{
    public static bool IsDouble(this string value)
    {
        if (!value.All(c => char.IsDigit(c) || c is '.' or ',')) return false;
        return true;
    }
    public static bool IsInt(this string value)
    {
        if (!value.All(c => char.IsDigit(c))) return false;
        return true;
    }

    public static bool IsPhrase(this string value)
    {
        if (!value.All(c => char.IsLetter(c) || char.IsWhiteSpace(c))) return false;
        return true;
    }

    public static void AddMultiple(this List<string?> value, params string?[] cadenas)
    {
        List<string?> palabras = cadenas.ToList();
        value.AddRange(palabras);
    }
}
