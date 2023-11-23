using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ForensicBones5.Models
{
    [Table("DescricoesCranios")]
    public class DescricaoCranio
    {
        [ForeignKey("InventarioCranio")]
        public int DescricaoCranioId { get; set; }

        public string FrontalDesc { get; set; }
        public string OcipitalDesc { get; set; }
        public string EsfenoideDesc { get; set; }
        public string MaxilarDesc { get; set; }
        public string VomerDesc { get; set; }
        [Display(Name = "Parietal Esquerdo")]
        public string ParietalEsqDesc { get; set; }
        [Display(Name = "Temporal Esquerdo")]
        public string TemporalEsqDesc { get; set; }
        [Display(Name = "Concha Nasal Esquerda")]
        public string ConchaNasalEsqDesc { get; set; }
        [Display(Name = "Etmoide Esquerdo")]
        public string EtmoideEsqDesc { get; set; }
        [Display(Name = "Lacrimal Esquerdo")]
        public string LacrimalEsqDesc { get; set; }
        [Display(Name = "Nasal Esquerdo")]
        public string NasalEsqDesc { get; set; }
        [Display(Name = "Zigomatico Esquerdo")]
        public string ZigomaticoEsqDesc { get; set; }
        [Display(Name = "Parietal Direito")]
        public string ParietalDirDesc { get; set; }
        [Display(Name = "Temporal Direito")]
        public string TemporalDirDesc { get; set; }
        [Display(Name = "Concha Nasal Direito")]
        public string ConchaNasalDirDesc { get; set; }
        [Display(Name = "Etmoide Direito")]
        public string EtmoideDirDesc { get; set; }
        [Display(Name = "Lacrimal Direito")]
        public string LacrimalDirDesc { get; set; }
        [Display(Name = "Zigomático Direito")]
        public string ZigomaticoDirDesc { get; set; }
        public string HioideDesc { get; set; }

        [Display(Name = "Cartilagem Tireóide")]
        public string CartilagemTireoideDesc { get; set; }

        [Display(Name = "Mandíbula")]
        public string MandibulaDesc { get; set; }

        public InventarioCranio InventarioCranio { get; set; }
    }
}
