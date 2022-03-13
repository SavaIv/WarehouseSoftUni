﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Infrastructure.Data
{
    // това не е свързваща таблица
    public class DealSubject
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid DealId { get; set; }

        [ForeignKey(nameof(DealId))]
        public Deal Deal { get; set; }

        public Guid ItemId { get; set; }

        [ForeignKey(nameof(ItemId))]
        public Item Item { get; set; }

        public int ItemCount { get; set; }
    }
}
