using System.ComponentModel.DataAnnotations;

namespace BlazorDemo.Models
{
    public class Article
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Price { get; set; }
    }

   
}
