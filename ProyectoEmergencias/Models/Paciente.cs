using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoEmergencias.Models
{
    public class Paciente
    {

        [Key]
        public int PacienteID { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Identity { get; set; }
        public  DateTime Fecha_Nacimiento { get; set; }
        public string Sexo { get; set; }
        public string Direccion { get; set; }
        public string Estado_Civil { get; set; }
        public string Peso { get; set; }
        public string Altura { get; set; }
        public IEnumerable<Sintoma> Sintomas { get; set; }

    }
}
