using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace MyPortfolio.Shared
{
    public partial class MainLayout : LayoutComponentBase
    {
        [Inject] private IJSRuntime JS { get; set; }

        private bool IsDarkMode { get; set; }

        protected override async Task OnInitializedAsync()
        {
            // Initialize dark mode on page load from JavaScript
            IsDarkMode = await JS.InvokeAsync<bool>("initializeDarkMode");
        }

        private async Task ToggleDarkMode()
        {
            // Toggle dark mode state
            IsDarkMode = !IsDarkMode;
            // Update dark mode setting in JavaScript and localStorage
            await JS.InvokeVoidAsync("toggleDarkMode", IsDarkMode);
        }
    }
}
