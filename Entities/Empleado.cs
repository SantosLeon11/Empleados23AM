using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados23AM.Entities
{
    public class Empleado
    {
        //"[Key]" hara el incremento de la llave primaria automaticamente
        //La llave primaria nunca se muestra
        [Key]
        public int PkEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Correo { get; set; }
    }
}
