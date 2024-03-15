
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Models
{
    public class Product
    {
        public Product () { }
        public Product(int id, string name, int price, string details, string image)
        {
            Name = name;
            Price = price;
            Details = details;
            Image = image;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; } 
        public string Details { get; set; }
        public string Image { get; set; }

    }
}
