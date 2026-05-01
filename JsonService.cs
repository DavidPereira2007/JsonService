using System;
using System.Text.Json;

namespace HandlerJson
{
    public static class JsonService
    {
        public static void Save<T>(string path, T dados) // salva os dados em um arquivo json
        {
            
            string json = JsonSerializer.Serialize(dados, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(path, json);
        }

        public static T? Read<T>(string path) // Lê um arquivo Json  (Transforma um arquivo json em um objeto C# de acordo com o tipo passado)
        {
            if (!File.Exists(path))
                return default;

            string json = File.ReadAllText(path);

            return JsonSerializer.Deserialize<T>(json);
        }

    }
}
