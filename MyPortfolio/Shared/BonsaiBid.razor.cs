using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace MyPortfolio.Shared
{
    public partial class BonsaiBid : ComponentBase
    {
        protected List<string> TechLogos { get; set; }

        protected override void OnInitialized()
        {
            TechLogos = new List<string>
            {
                "images/Logos/AWS.png",
                "images/Logos/Azure.png",
                "images/Logos/Heroku.png",
                "images/Logos/CSS.png",
                "images/Logos/HTML.png",
                "images/Logos/JS.png",
                "images/Logos/Rails.png"
            };
        }
    }
}
