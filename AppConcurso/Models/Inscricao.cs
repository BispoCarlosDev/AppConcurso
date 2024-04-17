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

        [Column("candidato_id")]
        public int? CandidatoID { get; set; }

        [ForeignKey("CandidatoID")]
        public Candidato? Candidato { get; set; }

        [Column("cargo_id")]
        public int? CargoID { get; set; }

        [ForeignKey("CargoID")]
        public Cargo? Cargo { get; set; }

        public List<Inscricao>? Inscricoes { get; set; }

    }
}
