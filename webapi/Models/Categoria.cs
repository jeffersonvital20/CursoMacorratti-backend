using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace webapi.Models
{
    [Table("Categorias")]
    public class Categoria : IValidatableObject
    {
        public Categoria()
        {
            Produtos = new Collection<Produto>();
        }
        [Key]
        public int CategoriaId { get; set; }
        [Required]
        [MaxLength(80)]
        public string Nome { get; set; }
        [Required]
        [MaxLength(300)]
        public string ImagemUrl { get; set; }
        public ICollection<Produto> Produtos { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (!string.IsNullOrEmpty(this.Nome.ToString()))
            {

                var firstLetter = this.Nome.ToString()[0].ToString();
                if (firstLetter != firstLetter.ToUpper())
                {
                   yield return new ValidationResult("A primeira letra da categória deve ser maiúscula!",
                       new[]
                       { nameof(this.Nome)
                       });
                }
                
            }
        }
    }
}
