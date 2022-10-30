using JSON;
using System.Text.Json;
using System.Text.Json.Serialization;
class Program
{
  public static void Main()
    {
        Food food = new Food(1, "Hotdog");

        var myJson = JsonSerializer.Serialize(food);

        Console.WriteLine(myJson);

        File.WriteAllText("C:\\Users\\Marco Alonso Benegas\\Desktop\\jsonC#.txt", myJson);

        string textJson = File.ReadAllText("C:\\Users\\Marco Alonso Benegas\\Desktop\\jsonC#.txt");

        Food foodToObject = JsonSerializer.Deserialize<Food>(textJson);
    }
}