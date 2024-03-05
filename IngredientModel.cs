public class Ingredient
{
    public int IngredientId { get; set; }
    public string Name { get; set; }
    public string Quantity { get; set; } // To accommodate various units
    public int RecipeId { get; set; }
    public virtual Recipe Recipe { get; set; }
}
