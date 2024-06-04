using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class StorageEntity
    {
        [Key]
        [StringLength(50)]
        public string StorageId { get; set; }

        [Required]
        public DateTime LastUpdate { get; set; }

        [Required]
        public int PartialQuantity { get; set; }

        //Relación con produtos (ProductEntity)
        public string ProductId { get; set; }
        public ProductEntity Product { get; set; }


        //Relacion con bodegas (WherehouseEntity)
        public string WarehouseId { get; set; }
        public WarehouseEntity Warehouse { get; set; }


        //Relación con movimientos (InputOutputEntity)
        public ICollection<InputOutputEntity> InputOutputs { get; set; }
    }
}
