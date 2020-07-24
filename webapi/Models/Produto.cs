using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using webapi.Validations;

namespace webapi.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }
        [Required(ErrorMessage ="O nome é obrigatório")]
        [StringLength(80, ErrorMessage ="O nome deve ter no máximo {1} e no mínimo {2} caracteres", MinimumLength = 5)]
        [FirstLetter]
        public string Nome { get; set; }
        [Required]
        [StringLength(300, ErrorMessage ="A descrição deve ter no máximo {1} caracteres")]
        public string Descricao { get; set; }
        [Required]
        [Range(1, 1000, ErrorMessage = "O preço deve estar entre {1} 2 {2}")]
        public decimal preco { get; set; }
        [Required]
        [MaxLength(300)]
        public string ImagemUrl { get; set; }
        public float Estoque { get; set; }
        public DateTime DataCadastro { get; set; }
        public Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }

    }
}
