using System.ComponentModel.DataAnnotations;

namespace Alura.RPA.Domain.Entities
{
    public class Cursos
    {
        [Key] 
        public virtual int Id { get; set; }
        public virtual string Titulo { get; set; }
        public virtual string Professor { get; set; }
        public virtual string Descricao { get; set; }
        public virtual string CargaHoraria { get; set; }
    }
}
