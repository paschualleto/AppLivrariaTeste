using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProjeto.DataProvider.Models
{
    public class LivroModel : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Preencha o campo nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Preencha o campo autor")]
        public string Autor { get; set; }
        [Required(ErrorMessage = "Preencha o campo Editora")]
        public string Editora { get; set; }

    }
}
