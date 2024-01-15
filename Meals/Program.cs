using System.Text.Json;

namespace Meals
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
           
            while (true)
            {
                string url = "https://www.themealdb.com/api/json/v1/1/random.php";
                Console.ForegroundColor = ConsoleColor.Yellow;
                string header = "  ___              _            \r\n | _ \\__ _ _ _  __| |___ _ __   \r\n |   / _` | ' \\/ _` / _ \\ '  \\  \r\n |_|_\\__,_|_||_\\__,_\\___/_|_|_| \r\n | _ \\___ __(_)_ __  ___ ___    \r\n |   / -_) _| | '_ \\/ -_|_-<    \r\n |_|_\\___\\__|_| .__/\\___/__/    \r\n              |_|               ";
                Console.ResetColor();
                await Console.Out.WriteLineAsync(header);

                await Console.Out.WriteLineAsync();
                await Console.Out.WriteLineAsync("Press enter to get a random recipe:");

                Console.ReadKey();

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        MealWrapper? meal = JsonSerializer.Deserialize<MealWrapper>(jsonResponse);

                        //await Console.Out.WriteLineAsync($"{}");
                        Console.ForegroundColor = ConsoleColor.Green;
                        await Console.Out.WriteLineAsync($"{meal.meals[0].strMeal}");
                        Console.ResetColor();
                        await Console.Out.WriteLineAsync();
                        await Console.Out.WriteLineAsync("List of Ingredients:");
                        await Console.Out.WriteLineAsync();


                        for (int i = 1; i < 20; i++)
                        {
                            string ingredientPropertyName = $"strIngredient{i}";
                            string measurePropertyName = $"strMeasure{i}";

                            string ingredient = meal.meals[0].GetType().GetProperty(ingredientPropertyName)?.GetValue(meal.meals[0]) as string;
                            string measure = meal.meals[0].GetType().GetProperty(measurePropertyName)?.GetValue(meal.meals[0]) as string;

                            if (!string.IsNullOrWhiteSpace(ingredient))
                            {
                                Console.WriteLine($"{ingredient}: {measure}");
                            }
                        }
                        await Console.Out.WriteLineAsync();
                        await Console.Out.WriteLineAsync(meal.meals[0].strInstructions);

                        await Console.Out.WriteLineAsync();
                        await Console.Out.WriteLineAsync("Press ENTER to continue:");
                        Console.ReadKey();
                        Console.Clear();
                        
                    }
                    else
                    {
                        Console.WriteLine($"Failed response code: {response.StatusCode} {response.ReasonPhrase}");
                    }
                }
            }

            
        }       

    }
}
