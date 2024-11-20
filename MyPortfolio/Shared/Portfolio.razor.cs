using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace MyPortfolio.Shared
{
    public partial class Portfolio : ComponentBase
    {
        protected List<string> TechLogos { get; set; }

        protected override void OnInitialized()
        {
            TechLogos = new List<string>
            {
                "images/Logos/Csharp.png",
                "images/Logos/Blazor.png",
                "images/Logos/Bootstrap.png",
                "images/Logos/github.png",
                "images/Logos/CSS.png",
                "images/Logos/HTML.png",
                "images/Logos/JS.png",
                "images/Logos/Azure.png"
            };
        }
    }
}

