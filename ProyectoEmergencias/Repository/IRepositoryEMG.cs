using ProyectoEmergencias.Models;
using System.Collections.Generic;

namespace ProyectoEmergencias.Repository
{
    public interface IRepositoryEMG
    {
        Paciente Find(int id);
        List<Paciente> Getall();

        Paciente Add(Paciente emergencia);
        Paciente Update(Paciente emergencia);
        void Delete(int id);
    }

}
