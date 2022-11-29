using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using VendasLanches03.Models;

namespace VendasLanches03.DTO
{
    public class CategoryDTO
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
