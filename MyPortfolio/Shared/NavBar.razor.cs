// NavBar.razor.cs
using Microsoft.AspNetCore.Components;

namespace MyPortfolio.Shared  // Make sure to replace with the correct namespace
{
    public class NavBarBase : ComponentBase
    {

        // Dark mode toggle state
        public bool IsDarkMode { get; set; } = false;

        // Method to toggle dark mode
        public void ToggleDarkMode()
        {
            IsDarkMode = !IsDarkMode;
        }
    }
}
