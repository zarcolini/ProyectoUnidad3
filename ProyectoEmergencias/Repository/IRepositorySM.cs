using ProyectoEmergencias.Models;
using System.Collections.Generic;

namespace ProyectoEmergencias.Repository
{

    public interface IRepositorySM
    {
        Sintoma Find(int ID);
        List<Sintoma> Getall();

        Sintoma Add(Sintoma emergencia);
        Sintoma Update(Sintoma emergencia);
        void Delete(int ID);
    }
   
    
}
