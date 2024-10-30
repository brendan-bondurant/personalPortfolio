using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using MyPortfolio.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyPortfolio.Shared
{
    public partial class Writing
    {
        [Inject] private IJSRuntime JS { get; set; } // JavaScript interop

        private List<Post> posts = new();
        public Post? selectedPost { get; private set; }

        // Fetch posts on component initialization
        protected override async Task OnInitializedAsync()
        {
            posts = await WordPressService.GetLatestPostsAsync();
        }

        // Sets the selected post for display in the modal
        private async Task ShowPost(Post post)
        {
            selectedPost = post;
        }
    }
}
