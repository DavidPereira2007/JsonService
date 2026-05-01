# JsonService

A simple and generic service for reading and writing JSON files in C#.

## 🚀 Features

- Save any type as JSON
- Read data generically
- Supports lists and objects

## 🛠️ Technologies

- C#
- System.Text.Json

## 📦 How to use

```csharp
using HandlerJson; // Namespace

string path = @"C:\Projetos\DevTecs\Tecnologias\NumerosSave.json";

// Example using a list (works with any type: classes, dictionaries, etc.)
var numeros = new List<int> {1, 2, 3, 4, 5, 6, 7};

// Save data
JsonService.Save(path, numeros);

// Read data
var resultado = JsonService.Read<List<int>>(path);

// Modify data (example: adding new values)
var numeros2 = new List<int> {8, 9, 10, 11, 12, 13};

if (resultado != null)
{
    resultado.AddRange(numeros2);
}

// Save again
JsonService.Save(path, resultado);