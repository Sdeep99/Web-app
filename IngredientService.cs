public class IngredientService : IIngredientService
{
    private readonly IIngredientRepository _ingredientRepository;

    public IngredientService(IIngredientRepository ingredientRepository)
    {
        _ingredientRepository = ingredientRepository;
    }

    public async Task<Ingredient> AddIngredient(Ingredient ingredient)
    {
        return await _ingredientRepository.AddAsync(ingredient);
    }

    // Add methods for Update, Delete, GetIngredient(s) as needed.
}
