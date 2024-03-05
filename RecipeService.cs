public class RecipeService : IRecipeService
{
    private readonly IRecipeRepository _recipeRepository;

    public RecipeService(IRecipeRepository recipeRepository)
    {
        _recipeRepository = recipeRepository;
    }

    public async Task<Recipe> CreateRecipe(Recipe recipe)
    {
        return await _recipeRepository.AddAsync(recipe);
    }

    // Add methods for Update, Delete, GetRecipe(s) as needed.
}
