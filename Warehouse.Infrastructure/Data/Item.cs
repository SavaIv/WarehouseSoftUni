using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Warehouse.Infrastructure.Data
{
    public class Item
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(30)]
        public string Barcode { get; set; }

        [Required]
        [StringLength(100)]
        public string Lable { get; set; }

        // възможно е някой item да се изчерпа временно => трябва да можем да ги спираме/пускаме
        // във времето може да се променят => е добре да са валидни в някакъв период от време
        // дори да спрем някой item е добре да пазим старите items, които са се предлагали
        // DateFrom - от кога започва това нещо
        // DateOnly няма DateOnly.Today - затова се налага това "парсване" с .FromDateTime
        // в description може да на направим описание на тази item
        [StringLength(500)]
        public string? Description { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime DateFrom { get; set; } = DateTime.Today;

        [Column(TypeName = "date")]
        public DateTime? DateTo { get; set; }

        [Required]
        public Guid CategoryId { get; set; }

        // Стамо го пише така ForeignKey-я
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }

        public IList<Rack> Racks { get; set; } = new List<Rack>();
    }
}
