public static class Constants
{
    public static string RecipeNameLabel = "Recipe Name";
    public static string CookTimeLabel = "Cook Time";
    public static string IngredientsLabel = "Ingredients";
    public static string DirectionsLabel = "Directions";
    public static string NumberOfServingsLabel = "Number of Servings";

    public static Thickness PickerMargin = new Thickness(15, 0);

    public static AllServingOptions NumberOfServingsOptions = new AllServingOptions
    {
        new ServingOption { Description = "Individual", Servings = 1 },
        new ServingOption { Description = "Family Sized", Servings = 4 },
        new ServingOption { Description = "Buffet", Servings = 12 }
    };
}

public class AllServingOptions : List<ServingOption>
{
    public AllServingOptions(params ServingOption[] args)
    {
        this.AddRange(args);
    }

    public AllServingOptions() { }
}

public class ServingOption
{
    public string Description { get; set; }
    public int Servings { get; set; }
}