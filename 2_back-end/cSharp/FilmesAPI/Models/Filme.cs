using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo 'Titulo' deve ser preenchido")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo 'Diretor' deve ser preenchido")]
        public string Diretor { get; set; }

        [StringLength(40, ErrorMessage = "O campo 'Genero' não pode conter mais do que 40 caracteres")]
        public string Genero { get; set; }

        [Range(1, 600, ErrorMessage = "O campo 'Duracao' deve conter entre 1 e 600 minutos")]
        public int Duracao { get; set; }
    }
}
