using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendasLanches03.Models
{
    [Table("Lanche")]
    public class Lanche
    {
        

        [Key]
        public int LancheId { get; set; }
        //-------------------------------------------------------------------------------------------------

        [Required(ErrorMessage="O nome do lanche deve ser informado")]
        [StringLength(80, MinimumLength =10,
                       ErrorMessage ="O {0} deve ser {1} e o maximo {2} caracteres")]
        [Display(Name = "Nome do lanche")]
        public string NomeLanche { get; set; }
        //-------------------------------------------------------------------------------------------------

        [Required(ErrorMessage = "O preço do lanche deve ser informado")]
        [Display(Name = "Preço do lanche")]
        [Column(TypeName= "decimal(10,3)")]
        [Range(1,999.99, ErrorMessage ="O preço do lanche deve estar entre R$ 1,00 e R$ 999,99")]
        public decimal Preco { get; set; }
        //------------------------------------------------------------------------------------------------

        [Required (     ErrorMessage = "A descrição do lanche deve ser informado")]
        [MinLength(10,  ErrorMessage = "A Descrição deve ter no minimo {1} caracters")]
        [MaxLength(100, ErrorMessage = "A descrição deve ter no maximo {1} caracteres")]
        [Display(Name = "Descrição do lanche")]
        public string DescricaoCurta { get; set; }
        //-----------------------------------------------------------------------------------------------

        [Required (     ErrorMessage = "A descrição detalhada do lanche deve ser informado")]
        [MinLength(10,  ErrorMessage = "A Descrição detalhada deve ter no minimo {1} caracters")]
        [MaxLength(200, ErrorMessage = "A descrição detalhada deve ter no maximo {1} caracteres")]
        [Display(Name = "Descrição detalhada do lanche")]
        public string DescricaoDetalhada { get; set; }
        //----------------------------------------------------------------------------------------------

        [MinLength(10,  ErrorMessage = "A imagem deve ter no minimo {1} caracters")]
        [MaxLength(100, ErrorMessage = "A imagem deve ter no maximo {1} caracteres")]
        [Display(Name = "Url da imagem")]
        public string ImagemUrl { get; set; }
        //---------------------------------------------------------------------------------------------

        [MinLength(10,  ErrorMessage = "A imagem pequena deve ter no minimo {1} caracters")]
        [MaxLength(100, ErrorMessage = "A imagem pequena deve ter no maximo {1} caracteres")]
        [Display(Name = "Url da imagem pequena")]
        public string ImagemThumbnailUrl { get; set; }
        //-------------------------------------------------------------------------------------------

        [Display(Name ="Preferido?")]
        public bool IsPreferido { get; set; }

        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }

        public Categoria Categoria { get; set; }
    }
}
