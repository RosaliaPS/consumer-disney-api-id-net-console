using System.Text.Json;
using ConsumerDisneyIdApi;

string url = "https://api.disneyapi.dev/character/423";

using HttpClient client = new HttpClient();

string json = await client.GetStringAsync(url);

DisneyResponse? resposta = JsonSerializer.Deserialize<DisneyResponse>(json);

Console.WriteLine("Nome:");
Console.WriteLine(resposta?.Data?.Name);

Console.WriteLine();

Console.WriteLine("Imagem:");
Console.WriteLine(resposta?.Data?.ImageUrl);