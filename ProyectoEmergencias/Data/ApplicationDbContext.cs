using ProyectoEmergencias.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;

namespace ProyectoEmergencias
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Sintoma> Sintomas { get; set; }

        public static implicit operator ApplicationDbContext(SqlConnection v)
        {
            throw new NotImplementedException();
        }
    }
}

