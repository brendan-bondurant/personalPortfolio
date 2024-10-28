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
            // Load initial dark mode state from JavaScript
            IsDarkMode = await JS.InvokeAsync<bool>("initializeDarkMode");
        }

        private async Task ToggleDarkMode()
        {
            // Toggle the mode
            IsDarkMode = !IsDarkMode;

            // Call JavaScript to apply the dark mode and save to local storage
            await JS.InvokeVoidAsync("toggleDarkMode", IsDarkMode);
        }
    }
}
