using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Cliente
    {
        //Atributos de la clase Cliente
        [Column(Order = 0)]
        public int Id  { get; set; }

        [Key, Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public required int Numero_Identificacion { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máxim {1} caractéres.")]
        public required string Primer_Nombre { get; set; }

        [MaxLength(50)]
        public string Segundo_Nombre { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máxim {1} caractéres.")]
        public required string Primer_Apellido { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máxim {1} caractéres.")]
        public required string Segundo_Apellido { get; set; }

        [MaxLength(20, ErrorMessage = "El campo {0} debe tener máxim {1} números.")]
        public required string Telefono { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máxim {1} caractéres.")]
        public required string Email { get; set; }

        public required DateOnly Fecha_nacimiento { get; set; }

        [Column(TypeName = "money")]
        public required decimal Valor_Estimado_Seguro { get; set; }

        [DataType(DataType.MultilineText)]
        [MaxLength(500, ErrorMessage = "El campo {0} debe tener máxim {1} caractéres.")]
        public string Observaciones { get; set; }
    }
}
