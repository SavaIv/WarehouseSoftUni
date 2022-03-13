using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Warehouse.Infrastructure.Data
{
    public class Category
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(100)]
        public string Lable { get; set; }        

        // възможно е някоя категория да се изчерпа временно => трябва да можем да ги спираме/пускаме
        // във времето може да се променят => е добре да са валидни в някакъв период от време
        // дори да спрем някой продукт е добре да пазим старите категории, които са се предлагали
        // DateFrom - от кога започва това нещо
        // DateOnly няма DateOnly.Today - затова се налага това "парсване" с .FromDateTime
        // в description може да на направим описание на тази категория
        [StringLength(500)]
        public string? Description { get; set; }
        
        [Required]
        [Column(TypeName = "date")]
        public DateTime DateFrom { get; set; } = DateTime.Today;

        [Column(TypeName = "date")]
        public DateTime? DateTo { get; set; }

        public ICollection<Item> Items { get; set; } = new List<Item>();
    }
}
