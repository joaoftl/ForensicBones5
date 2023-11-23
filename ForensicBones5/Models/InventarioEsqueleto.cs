using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ForensicBones5.Models
{
    [Table("InventariosEsqueleto")]
    public class InventarioEsqueleto
    {
        [Key]        
        public int InventarioEsqueletoId { get; set; }

        [Display(Name = "Código do Relatório")]
        [ForeignKey("Relatorio")]
        public string RelatorioId { get; set; }

        [Display(Name = "Fotos do Esqueleto")]
        public string FotoEsqueleto { get; set; }

        [Display(Name = "Observações")]
        public string Observacoes { get; set; }

        public Relatorio Relatorio { get; set; }

        //public InventarioCranio InventarioCranio { get; set; }
    }
}
