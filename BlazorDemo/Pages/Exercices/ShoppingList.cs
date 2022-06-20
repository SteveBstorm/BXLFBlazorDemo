using BlazorDemo.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorDemo.Pages.Exercices
{
    public partial class ShoppingList
    {
        [Inject]
        private ArticleData dataset { get; set; }

        public List<Article> ArticleList { get; set; }
        public Article Selected { get; set; }

        public int SelectedId { get; set; }

        //public ShoppingList()
        //{
        //    ArticleList = dataset.Getall();
        //}

        public void SetSelected(Article a)
        {
            Selected = a;
        }

        public void SetId(int Id)
        {
            SelectedId = Id;
        }

        protected override void OnInitialized()
        {
            ArticleList = dataset.Getall();

        }
    }
}
