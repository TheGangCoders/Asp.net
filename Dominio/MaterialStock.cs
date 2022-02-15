using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class MaterialStock
    {
        public Guid MaterialStockId { get; set; }
        public Guid MaterialId { get; set; }
        public Material Material { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Cantidad { get; set; }
        public bool Activo {get; set;}
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }

    }
}