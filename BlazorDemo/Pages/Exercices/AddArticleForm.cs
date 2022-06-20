using BlazorDemo.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorDemo.Pages.Exercices
{
    public partial class AddArticleForm
    {
        [Inject]
        private ArticleData dataset { get; set; }
        [Inject]
        private NavigationManager navigationManager { get; set; }

        public Article myNewArticle { get; set; }

        public AddArticleForm()
        {
            myNewArticle = new Article();
        }

        public void SubmitForm()
        {
            dataset.Add(myNewArticle);
            navigationManager.NavigateTo("/exo1");
        }
    }
}
