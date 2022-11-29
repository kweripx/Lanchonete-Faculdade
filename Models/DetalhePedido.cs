using System.ComponentModel.DataAnnotations.Schema;

namespace VendasLanches03.Models
{
  
    public class DetalhePedido
    {
        public int DetalhePedidoId { get; set; }
        public int Quantidade { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Preco { get; set; }

        public virtual Lanche Lanche { get; set; }
        public int LancheId { get; set; }

        public virtual Pedido Pedido { get; set; }
        public int PedidoId { get; set; }
    }
}
