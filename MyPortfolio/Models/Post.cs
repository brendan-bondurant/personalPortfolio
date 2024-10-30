namespace MyPortfolio.Models
{
    public class Post
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Date { get; set; }


        public string? FeaturedImageUrl { get; set; }

        public string? FeaturedImage { get; set; }
        public PostThumbnail? PostThumbnail { get; set; }  
    }

    public class PostThumbnail
    {
        public string URL { get; set; }  
    }
}
