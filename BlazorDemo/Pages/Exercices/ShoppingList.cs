using BlazorDemo.Models;

namespace BlazorDemo.Pages.Exercices
{
    public partial class ShoppingList
    {
        public List<Article> ArticleList { get; set; }
        public Article Selected { get; set; }

        public ShoppingList()
        {
            ArticleList = new List<Article>();
            ArticleList.Add(new Article { Id = 1, Name = "Coca", Price = 1 });
            ArticleList.Add(new Article { Id = 2, Name = "Fanta", Price = 1 });
            ArticleList.Add(new Article { Id = 3, Name = "RTX 3090", Price = 1800 });
            ArticleList.Add(new Article { Id = 4, Name = "I7 12700K", Price = 450 });
        }

        public void SetSelected(Article a)
        {
            Selected = a;
        }
    }
}
