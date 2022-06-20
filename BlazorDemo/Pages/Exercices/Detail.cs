using BlazorDemo.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorDemo.Pages.Exercices
{
    public partial class Detail : ComponentBase
    {
        [Inject]
        private ArticleData dataset { get; set; }
        
        [Parameter]
        public int Id { get; set; }
        public Article Selected { get; set; }

        protected override void OnParametersSet()
        {
            Selected = dataset.GetById(Id);
        }

    }
}
