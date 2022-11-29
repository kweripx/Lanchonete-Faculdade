using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendasLanches03.Models
{
    [Table("Pedidos")]
    public class Pedido
    {
        [Key]
        public int PedidoId { get; set; }
        //------------------------------------------------------------------

        [Required(ErrorMessage = "Informe o nome") ]
        [StringLength(50)]
        public string Nome { get; set; }
        //------------------------------------------------------------------

        [Required(ErrorMessage = "Informe o endereço")]
        [StringLength(100)]
        public string Endereco { get; set; }
        //------------------------------------------------------------------

        [StringLength(100)]
        [Display(Name ="Complemento")]
        public string Complemento { get; set; }
        //------------------------------------------------------------------

        [Required(ErrorMessage = "Informe o CEP")]
        [StringLength(10, MinimumLength = 8)]
        [Display(Name ="CEP")]
        public string Cep { get; set; }
        //------------------------------------------------------------------

        [Required(ErrorMessage = "Informe o Estado")]
        [StringLength(10)]
        public string Estado { get; set; }
        //------------------------------------------------------------------

        [Required(ErrorMessage = "Informe a Cidade")]
        [StringLength(50)]
        public string Cidade { get; set; }
        //------------------------------------------------------------------

        [Required(ErrorMessage = "Informe o Telefone")]
        [StringLength(25)]
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }
        //------------------------------------------------------------------

        [Required(ErrorMessage = "Informe o E-mail")]
        [StringLength(100)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        //------------------------------------------------------------------

        [ScaffoldColumn(false)] //não seja visivel
        [Column(TypeName = "Decimal(10,2)")]
        [Display(Name = "Total do pedido")]
        public decimal TotalPedido { get; set; }
        //------------------------------------------------------------------

        [ScaffoldColumn(false)] //não seja visivel
        [Display(Name = "Itens do pedido")]
        public int TotalItensPedido { get; set; }
        //------------------------------------------------------------------

        [DataType(DataType.Text)]
        [DisplayFormat(DataFormatString = "{0: dd/mm/yyyy hh:mm",
                       ApplyFormatInEditMode =true)]
        [Display(Name = "Data do pedido")]
        public DateTime PedidoSolicitadoEm { get; set; }
        //------------------------------------------------------------------

        [DataType(DataType.Text)]
        [DisplayFormat(DataFormatString = "{0: dd/mm/yyyy hh:mm",
                       ApplyFormatInEditMode = true)]
        [Display(Name = "Data envio do pedido")]
        public DateTime PedidoEntregueEm { get; set; }

        public List<DetalhePedido> PedidoItens { get; set; }
    }
}
