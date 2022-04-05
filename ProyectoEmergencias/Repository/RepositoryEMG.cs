using Dapper;
using ProyectoEmergencias.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ProyectoEmergencias.Repository
{
    public class RepositoryEMG : IRepositoryEMG
    {
        public Paciente Add(Paciente emergencia)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Paciente Find(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Paciente> Getall()
        {
            throw new System.NotImplementedException();
        }

        public Paciente Update(Paciente emergencia)
        {
            throw new System.NotImplementedException();
        }
    }
}
