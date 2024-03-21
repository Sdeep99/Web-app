public class ApplicationUser : IdentityUser
{
    public virtual ICollection<Recipe> Recipes { get; set; }
}
