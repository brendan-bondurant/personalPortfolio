using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using MyPortfolio.Models;

namespace MyPortfolio.Services
{
    public class WordPressService
    {
        private readonly HttpClient _httpClient;

        public WordPressService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Post>> GetLatestPostsAsync()
        {
            var response = await _httpClient.GetAsync("posts/?number=3"); // Limit to 3 posts
            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var result = JsonSerializer.Deserialize<WordPressApiResponse>(jsonResponse, options);
            
            // Map FeaturedImageUrl from post_thumbnail.URL or featured_image
            result?.Posts.ForEach(post =>
            {
                post.FeaturedImageUrl = post.PostThumbnail?.URL ?? post.FeaturedImage;
            });

            return result?.Posts ?? new List<Post>();
        }
    }

    public class WordPressApiResponse
    {
        public List<Post> Posts { get; set; }
    }

    public class PostThumbnail
    {
        public string URL { get; set; }  // URL of the thumbnail image
    }
}
