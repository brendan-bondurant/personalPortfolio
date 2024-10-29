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

        protected override async Task OnInitializedAsync()
        {
            posts = await WordPressService.GetLatestPostsAsync();
        }

        private async Task ShowPost(Post post)
        {
            selectedPost = post;
        }
    }
}
