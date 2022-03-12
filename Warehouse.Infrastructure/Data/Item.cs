using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Infrastructure.Data
{
    public class Item
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

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
        public DateOnly DateFrom { get; set; } = DateOnly.FromDateTime(DateTime.Today);

        public DateOnly? DateTo { get; set; }

        [Required]
        public Guid CategoryId { get; set; }

        // Стамо го пише така ForeignKey-я
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }


    }
}
