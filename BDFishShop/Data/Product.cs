using System.ComponentModel.DataAnnotations.Schema;

namespace BDFishShop.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TypeProductId {  get; set; }
        public TypeProduct TypeProducts { get; set; }
        public string ImageURL {  get; set; }
        [Column(TypeName ="decimal(10,2)")]
        public decimal Price {  get; set; }
        public DateTime DateCreated { get; set; }
        public ICollection<Order> Orders { get; set; }

    }
}
