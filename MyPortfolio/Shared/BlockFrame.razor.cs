using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace MyPortfolio.Shared
{
    public partial class BlockFrame : ComponentBase
    {
        protected List<string> TechLogos { get; set; }

        protected override void OnInitialized()
        {
            TechLogos = new List<string>
            {
                "images/Logos/Go-Logo_Blue.png",
                "images/Logos/Docker.png"
            };
        }
    }
}

