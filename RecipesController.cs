[Route("api/[controller]")]
[ApiController]
public class RecipesController : ControllerBase
{
    private readonly IRecipeService _recipeService;

    public RecipesController(IRecipeService recipeService)
    {
        _recipeService = recipeService;
    }

    // GET: api/Recipes
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Recipe>>> GetRecipes()
    {
        return Ok(await _recipeService.GetAllRecipesAsync());
    }

    // GET: api/Recipes/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Recipe>> GetRecipe(int id)
    {
        var recipe = await _recipeService.GetRecipeByIdAsync(id);

        if (recipe == null)
        {
            return NotFound();
        }

        return recipe;
    }

    // POST: api/Recipes
    [HttpPost]
    public async Task<ActionResult<Recipe>> PostRecipe(Recipe recipe)
    {
        await _recipeService.AddRecipeAsync(recipe);
        return CreatedAtAction("GetRecipe", new { id = recipe.RecipeId }, recipe);
    }

    // PUT: api/Recipes/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutRecipe(int id, Recipe recipe)
    {
        if (id != recipe.RecipeId)
        {
            return BadRequest();
        }

        try
        {
            await _recipeService.UpdateRecipeAsync(recipe);
        }
        catch (Exception)
        {
            // Handle the exception (e.g., recipe not found)
        }

        return NoContent();
    }

    // DELETE: api/Recipes/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteRecipe(int id)
    {
        var recipe = await _recipeService.GetRecipeByIdAsync(id);
        if (recipe == null)
        {
            return NotFound();
        }

        await _recipeService.DeleteRecipeAsync(recipe);

        return NoContent();
    }
}
