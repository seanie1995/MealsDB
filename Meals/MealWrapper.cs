using System.Text.Json.Serialization;

namespace Meals
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);


    public class Meal
    {
        [JsonPropertyName("idMeal")]
        public string idMeal { get; set; }

        [JsonPropertyName("strMeal")]
        public string strMeal { get; set; }

        [JsonPropertyName("strDrinkAlternate")]
        public object strDrinkAlternate { get; set; }

        [JsonPropertyName("strCategory")]
        public string strCategory { get; set; }

        [JsonPropertyName("strArea")]
        public string strArea { get; set; }

        [JsonPropertyName("strInstructions")]
        public string strInstructions { get; set; }

        [JsonPropertyName("strMealThumb")]
        public string strMealThumb { get; set; }

        [JsonPropertyName("strTags")]
        public object strTags { get; set; }

        [JsonPropertyName("strYoutube")]
        public string strYoutube { get; set; }

        [JsonPropertyName("strIngredient1")]
        public string strIngredient1 { get; set; }

        [JsonPropertyName("strIngredient2")]
        public string strIngredient2 { get; set; }

        [JsonPropertyName("strIngredient3")]
        public string strIngredient3 { get; set; }

        [JsonPropertyName("strIngredient4")]
        public string strIngredient4 { get; set; }

        [JsonPropertyName("strIngredient5")]
        public string strIngredient5 { get; set; }

        [JsonPropertyName("strIngredient6")]
        public string strIngredient6 { get; set; }

        [JsonPropertyName("strIngredient7")]
        public string strIngredient7 { get; set; }

        [JsonPropertyName("strIngredient8")]
        public string strIngredient8 { get; set; }

        [JsonPropertyName("strIngredient9")]
        public string strIngredient9 { get; set; }

        [JsonPropertyName("strIngredient10")]
        public string strIngredient10 { get; set; }

        [JsonPropertyName("strIngredient11")]
        public string strIngredient11 { get; set; }

        [JsonPropertyName("strIngredient12")]
        public string strIngredient12 { get; set; }

        [JsonPropertyName("strIngredient13")]
        public string strIngredient13 { get; set; }

        [JsonPropertyName("strIngredient14")]
        public string strIngredient14 { get; set; }

        [JsonPropertyName("strIngredient15")]
        public string strIngredient15 { get; set; }

        [JsonPropertyName("strIngredient16")]
        public string strIngredient16 { get; set; }

        [JsonPropertyName("strIngredient17")]
        public string strIngredient17 { get; set; }

        [JsonPropertyName("strIngredient18")]
        public string strIngredient18 { get; set; }

        [JsonPropertyName("strIngredient19")]
        public string strIngredient19 { get; set; }

        [JsonPropertyName("strIngredient20")]
        public string strIngredient20 { get; set; }

        [JsonPropertyName("strMeasure1")]
        public string strMeasure1 { get; set; }

        [JsonPropertyName("strMeasure2")]
        public string strMeasure2 { get; set; }

        [JsonPropertyName("strMeasure3")]
        public string strMeasure3 { get; set; }

        [JsonPropertyName("strMeasure4")]
        public string strMeasure4 { get; set; }

        [JsonPropertyName("strMeasure5")]
        public string strMeasure5 { get; set; }

        [JsonPropertyName("strMeasure6")]
        public string strMeasure6 { get; set; }

        [JsonPropertyName("strMeasure7")]
        public string strMeasure7 { get; set; }

        [JsonPropertyName("strMeasure8")]
        public string strMeasure8 { get; set; }

        [JsonPropertyName("strMeasure9")]
        public string strMeasure9 { get; set; }

        [JsonPropertyName("strMeasure10")]
        public string strMeasure10 { get; set; }

        [JsonPropertyName("strMeasure11")]
        public string strMeasure11 { get; set; }

        [JsonPropertyName("strMeasure12")]
        public string strMeasure12 { get; set; }

        [JsonPropertyName("strMeasure13")]
        public string strMeasure13 { get; set; }

        [JsonPropertyName("strMeasure14")]
        public string strMeasure14 { get; set; }

        [JsonPropertyName("strMeasure15")]
        public string strMeasure15 { get; set; }

        [JsonPropertyName("strMeasure16")]
        public string strMeasure16 { get; set; }

        [JsonPropertyName("strMeasure17")]
        public string strMeasure17 { get; set; }

        [JsonPropertyName("strMeasure18")]
        public string strMeasure18 { get; set; }

        [JsonPropertyName("strMeasure19")]
        public string strMeasure19 { get; set; }

        [JsonPropertyName("strMeasure20")]
        public string strMeasure20 { get; set; }

        [JsonPropertyName("strSource")]
        public string strSource { get; set; }

        [JsonPropertyName("strImageSource")]
        public object strImageSource { get; set; }

        [JsonPropertyName("strCreativeCommonsConfirmed")]
        public object strCreativeCommonsConfirmed { get; set; }

        [JsonPropertyName("dateModified")]
        public object dateModified { get; set; }

        public List<string> Ingredients
        {
            get
            {
                return new List<string>
                {
                    strIngredient1,
                    strIngredient2,
                    strIngredient3,
                    strIngredient4,
                    strIngredient5,
                    strIngredient6,
                    strIngredient7,
                    strIngredient8,
                    strIngredient9,
                    strIngredient10,
                    strIngredient11,
                    strIngredient12,
                    strIngredient13,
                    strIngredient14,
                    strIngredient15,
                    strIngredient16,
                    strIngredient17,
                    strIngredient18,
                    strIngredient19,
                    strIngredient20,
                };
            }
        }

        public List<string> Measurements
        {
            get
            {
                return new List<string>
                {
                    strMeasure1,
                    strMeasure2,
                    strMeasure3,
                    strMeasure4,
                    strMeasure5,
                    strMeasure6,
                    strMeasure7,
                    strMeasure8,
                    strMeasure9,
                    strMeasure10,
                    strMeasure11,
                    strMeasure12,
                    strMeasure13,
                    strMeasure14,
                    strMeasure15,
                    strMeasure16,
                    strMeasure17,
                    strMeasure18,
                    strMeasure19,
                    strMeasure20,
                };
            }
        }
    }

    public class MealWrapper
    {
        [JsonPropertyName("meals")]
        public List<Meal> meals { get; set; }
    }

    

}
