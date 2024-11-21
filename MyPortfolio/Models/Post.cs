namespace MyPortfolio.Models
{
    public class Post
    {
        // Non-nullable properties assigned default values
        public string Title { get; set; } = string.Empty; 
        public string Content { get; set; } = string.Empty;
        public string Date { get; set; } = string.Empty;

        // Nullable properties for optional fields
        public string? FeaturedImageUrl { get; set; }
        public string? FeaturedImage { get; set; }
        public PostThumbnail? PostThumbnail { get; set; }
    }

    public class PostThumbnail
    {
        // Non-nullable property assigned a default value
        public string URL { get; set; } = string.Empty;
    }
}
