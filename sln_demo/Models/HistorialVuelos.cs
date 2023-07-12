using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sln_demo.Models
{
    [Table("tb_HistorialVuelos")]
    public class HistorialVuelos
    {
        [Key]
        public int id { get; set; }

        [Required]
        [Display(Name = "Fecha de vuelo")]
        public DateTime fecha_vuelo { get; set; }

        [Required]
        [StringLength(50)]
        public string origen { get; set; }

        [Required]
        [StringLength(50)]
        public string destino { get; set; }

        public int duracion { get; set; }

        [Display(Name = "ID de la aeronave")]
        public int aeronave_id { get; set; }

        [Display(Name = "ID del piloto")]
        public int piloto_id { get; set; }

        [ForeignKey("aeronave_id")]
        public Aeronaves Aeronave { get; set; }

        [ForeignKey("piloto_id")]
        public Personal Piloto { get; set; }
    }

    [Table("tb_Aeronaves")]
    public class Aeronaves
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre { get; set; }

        [StringLength(500)]
        public string descripcion { get; set; }
    }

    [Table("tb_Destinos")]
    public class Destinos
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre { get; set; }

        [StringLength(100)]
        public string ubicacion { get; set; }

        [StringLength(500)]
        public string descripcion { get; set; }
    }

    [Table("tb_PlanesVuelo")]
    public class PlanesVuelo
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "Fecha de salida")]
        public DateTime fecha_salida { get; set; }

        [Display(Name = "Fecha de llegada")]
        public DateTime fecha_llegada { get; set; }

        [Display(Name = "ID del destino")]
        public int destino_id { get; set; }

        [ForeignKey("destino_id")]
        public Destinos Destino { get; set; }
    }
}
