using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sln_demo.Models
{
    [Table("tb_personal")]
    public class Personal
    {
        [Key]
        [Required(ErrorMessage = "Falta escribir el DNI")]
        [MinLength(8, ErrorMessage = "Dede escribir 8 dígitos")]
        [Display(Name = "Num. DNI")]
        public int dni { get; set; }

        [Required(ErrorMessage = "Falta escribir nombre")]
        [StringLength(25)]
        [Display(Name = "Nombre")]
        public String nombre { get; set; }

        [Required(ErrorMessage = "Falta escribir apellido paterno")]
        [StringLength(25)]
        [Display(Name = "Apellido Paterno")]
        public String ap_paterno { get; set; }

        [Required(ErrorMessage = "Falta escribir apellido materno")]
        [StringLength(25)]
        [Display(Name = "Apellido Materno")]
        public String ap_materno { get; set; }

        [Required(ErrorMessage = "Falta elegir fecha de nacimiento")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de nacimmiento")]
        public DateTime fecha_nacimiento { get; set; }

        [Display(Name = "Género")]
        public String genero { get; set; }

    }
}
