using BlazorDemo.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorDemo.Pages.Exercices
{
    public partial class Detail
    {
        
        
        [Parameter]
        public Article Selected { get; set; }

        //protected override void OnParametersSet()
        //{
        //    base.OnParametersSet();
        //}

    }
}
