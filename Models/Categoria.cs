using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendasLanches03.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [Required]
        [Display(Name = "Preencha a categoria do lanche")]
        [StringLength(100, ErrorMessage = "Nome da categoria deve ter no maximo 100 caracteres")]
        public string NomeCategoria { get; set; }

        [Required]
        [Display(Name = "Preencha a Descrição do lanche")]
        [StringLength(100, ErrorMessage = "Descrição deve ter no maximo 100 caracteres")]
        public string Descricao { get; set; }

        [NotMapped]
        public DateTime DataCriacao { get; set; }

        public List<Lanche> Lanche { get; set; }
    }
}
