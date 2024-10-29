using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace MyPortfolio.Shared
{
    public partial class PhilosDBL : ComponentBase
    {
        protected List<string> TechLogos { get; set; }

        protected override void OnInitialized()
        {
            TechLogos = new List<string>
            {
                "images/Logos/C#.png"
                //"images/Logos/Blazor.png"
            };
        }
    }
}

