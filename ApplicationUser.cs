public class Recipe
{
    public int RecipeId { get; set; }
    public string UserId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string CookingInstructions { get; set; }
    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<Ingredient> Ingredients { get; set; }
}
