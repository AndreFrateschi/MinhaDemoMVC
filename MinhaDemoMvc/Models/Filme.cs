using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinhaDemoMvc.Models
{
    public class Filme
    {
        [Key]
        public int Id  { get; set; }
        [Required(ErrorMessage = "campo titulo eh obrigatorio")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "o texto precisa ter entre 3 e 60 caracteres")]
        public string Titulo { get; set; }

        [DataType(DataType.DateTime, ErrorMessage ="formato incorreto")]
        [Required(ErrorMessage = "campo data de lancamento eh obrigatorio")]
        [Display(Name = "Data de lancamento")]
        public DateTime DataLancamento { get; set; }

        [StringLength(30, ErrorMessage = "maximo de 30 caracteres")]
        public string Genero { get; set; }

        [Range(1, 1000, ErrorMessage = "valor de 1 a 1000")]
        [Required(ErrorMessage = "campo valor eh obrigatorio")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "campo avaliar eh obrigatorio")]
        [Display(Name ="avaliacao")]
        public string Avaliacao { get; set; }
    }
}
