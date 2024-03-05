// Example of a Comment model
public class Comment
{
    public int CommentId { get; set; }
    public string UserId { get; set; }
    public int RecipeId { get; set; }
    public string Text { get; set; }
    public virtual ApplicationUser User { get; set; }
    public virtual Recipe Recipe { get; set; }
}
