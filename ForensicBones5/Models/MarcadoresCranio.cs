using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForensicBones5.Models
{
    [Table("MarcadoresCranios")]
    public class MarcadoresCranio
    {
        [Key]
        public int MarcadoresCranioId { get; }

        [ForeignKey("InventarioCranio")]
        public int InventarioCranioId { get; set; }

        [Display(Name = "Crista Nucal")]
        public char CristaNucal { get; set; }

        [Display(Name = "Processo Mastoide")]
        public char ProcessoMastoide { get; set; }

        [Display(Name = "Eminência Mentoniana")]
        public char EminenciaMentoniana { get; set; }

        [Display(Name = "Supra Orbital")]
        public char SupraOrbital { get; set; }

        [Display(Name = "Área da Glabela")]
        public char AreaGlabela { get; set; }

        [Display(Name = "Observações")]
        public string Observacoes { get; set; }
                    
        public InventarioCranio InventarioCranio { get; set; }
    }
}
