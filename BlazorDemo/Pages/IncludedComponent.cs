using Microsoft.AspNetCore.Components;

namespace BlazorDemo.Pages
{
    public partial class IncludedComponent
    {

        [Parameter]
        public int InputProp { get; set; }

        [Parameter]
        public string Toto { get; set; }
    }
}
