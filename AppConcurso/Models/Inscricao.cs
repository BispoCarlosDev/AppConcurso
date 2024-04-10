using System.ComponentModel.DataAnnotations.Schema;

namespace AppConcurso.Models
{
    [Table("inscricao")]
    public class Inscricao
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("numero_insc")]
        public string? NumeroInsc { get; set; }

        [Column("data_inscricao")]
        public DateTime? DataInscricao { get; set; }

        [Column("nota_conh_gerais")]
        public decimal NotaConhGerais { get; set; }

        [Column("nota_conh_especificos")]
        public decimal NotaConhEspecificos { get; set; }

        [Column("id_candidato")]
        public int? IdCandidato { get; set; }

        [ForeignKey("IdCandidato")]
        public Candidato? Candidato { get; set; }

        [Column("id_cargo")]
        public int? IdCargo { get; set; }

        [ForeignKey("IdCargo")]
        public Cargo? Cargo { get; set; }

        public List<Inscricao>? Inscricoes { get; set; }

    }
}
