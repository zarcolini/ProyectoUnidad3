using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoEmergencias.Models
{
    public class Sintoma
    {
        [Key]
        public int SintomasID { get; set; }
        public string Sintomas { get; set; }
        public string Presion { get; set; }
        public string Frecuencia_Cardiaca { get; set; }
        public string Pulso { get; set; }
        public int Temperatura { get; set; }
        public int PacienteID { get; set; }

        [Display(Name = "Paciente")]
        [ForeignKey("PacienteID")]
        public Paciente Paciente { get; set; }
        public int DoctorID { get; set; }

        [Display(Name = "Doctor")]
        [ForeignKey("DoctorID")]
        public Doctor Doctor { get; set; }
    }
}
