using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage="O nome da categoria é obrigatório")]
        [StringLength(100, ErrorMessage="O tamnho máximo é 100 caractéres")]
        [Display(Name="Nome")]
        public string CategoriaNome { get; set; }

        [Required(ErrorMessage = "A descrição da categoria é obrigatório")]
        [StringLength(100, ErrorMessage = "O tamnho máximo é 200 caractéres")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public List<Lanche> Lanches { get; set; }
    }
}
