using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoEmergencias.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorID { get; set; }
        public string NombreDoc { get; set; }
        public string Especialidad{ get; set; }

        public IEnumerable<Sintoma> Sintomas { get; set; }

    }
}
