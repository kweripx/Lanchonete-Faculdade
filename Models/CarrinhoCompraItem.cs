using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendasLanches03.Models
{
    [Table("Carrinho")]
    public class CarrinhoCompraItem
    {
        [Key]
        public int CarrinhoCompraItensId { get; set; }
        public Lanche Lanche { get; set; }
        public int Quantidade { get; set; }

        [StringLength(100)]
        public string CarrinhoCompraId { get; set; }
    }
}
