using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGE.Models
{
    [Table("Notas")]
    public class Notas
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [ForeignKey("MateriasId")]
        [Display(Name = "Matéria")]
        public int MateriasId { get; set; }
        public Materias? Materias { get; set; }

        [ForeignKey("AlunosId")]
        [Display(Name = "Aluno")]
        public int AlunosId { get; set; }
        public Alunos? Alunos { get; set; }

        [ForeignKey("EtapasId")]
        [Display(Name = "Etapa")]
        public int EtapasId { get; set; }
        public Etapas? Etapas { get; set; }

        [Column("NotasAlunos")]
        [Display(Name = "Notas")]
        public double NotasAlunos { get; set; }
    }
}
