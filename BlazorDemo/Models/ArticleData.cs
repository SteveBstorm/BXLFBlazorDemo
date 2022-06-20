namespace BlazorDemo.Models
{
    public class ArticleData
    {
        public List<Article> ArticleList { get; set; }

        private int currentId;
        public ArticleData()
        {
            ArticleList = new List<Article>();
            ArticleList.Add(new Article { Id = 1, Name = "Coca", Price = 1 });
            ArticleList.Add(new Article { Id = 2, Name = "Fanta", Price = 1 });
            ArticleList.Add(new Article { Id = 3, Name = "RTX 3090", Price = 1800 });
            ArticleList.Add(new Article { Id = 4, Name = "I7 12700K", Price = 450 }); 
            ArticleList.Add(new Article { Id = 5, Name = "Coca", Price = 1 });
            ArticleList.Add(new Article { Id = 6, Name = "Fanta", Price = 1 });
            ArticleList.Add(new Article { Id = 7, Name = "RTX 3090", Price = 1800 });
            ArticleList.Add(new Article { Id = 8, Name = "I7 12700K", Price = 450 }); 
            ArticleList.Add(new Article { Id = 9, Name = "Coca", Price = 1 });
            ArticleList.Add(new Article { Id = 10, Name = "Fanta", Price = 1 });
            ArticleList.Add(new Article { Id = 11, Name = "RTX 3090", Price = 1800 });
            ArticleList.Add(new Article { Id = 12, Name = "I7 12700K", Price = 450 }); 
            ArticleList.Add(new Article { Id = 13, Name = "Coca", Price = 1 });
            ArticleList.Add(new Article { Id = 14, Name = "Fanta", Price = 1 });
            ArticleList.Add(new Article { Id = 15, Name = "RTX 3090", Price = 1800 });
            ArticleList.Add(new Article { Id = 16, Name = "I7 12700K", Price = 450 });

        }

        public Article GetById(int Id)
        {
            return ArticleList.FirstOrDefault(x => x.Id == Id);
        }

        public List<Article> Getall()
        {
            return ArticleList;
        }

        public void Add(Article a)
        {
            currentId = ArticleList.Max(x => x.Id) + 1;
            a.Id = currentId;
            ArticleList.Add(a);
        }
    }
}
