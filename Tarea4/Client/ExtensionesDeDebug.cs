using System.Text.Json;

namespace Tarea4.Client
{
    public static class ExtensionesDeDebug
    {
        private static JsonSerializerOptions opciones = new
       JsonSerializerOptions
        { WriteIndented = true };
        public static string ToJson(this object obj)
        => JsonSerializer.Serialize(obj, opciones);
    }
}
