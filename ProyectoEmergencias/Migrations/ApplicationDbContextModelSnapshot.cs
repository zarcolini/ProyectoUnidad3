// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoEmergencias;

namespace ProyectoEmergencias.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProyectoEmergencias.Models.Doctor", b =>
                {
                    b.Property<int>("DoctorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Especialidad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreDoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estado_servicio")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DoctorID");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("ProyectoEmergencias.Models.Paciente", b =>
                {
                    b.Property<int>("PacienteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Altura")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Estado_Civil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha_Nacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Identity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Peso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sexo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PacienteID");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("ProyectoEmergencias.Models.Sintoma", b =>
                {
                    b.Property<int>("SintomasID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DoctorID")
                        .HasColumnType("int");

                    b.Property<string>("Frecuencia_Cardiaca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PacienteID")
                        .HasColumnType("int");

                    b.Property<string>("Presion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pulso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sintomas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Temperatura")
                        .HasColumnType("int");

                    b.HasKey("SintomasID");

                    b.HasIndex("DoctorID");

                    b.HasIndex("PacienteID");

                    b.ToTable("Sintomas");
                });

            modelBuilder.Entity("ProyectoEmergencias.Models.Sintoma", b =>
                {
                    b.HasOne("ProyectoEmergencias.Models.Doctor", "Doctor")
                        .WithMany("Sintomas")
                        .HasForeignKey("DoctorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProyectoEmergencias.Models.Paciente", "Paciente")
                        .WithMany("Sintomas")
                        .HasForeignKey("PacienteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("ProyectoEmergencias.Models.Doctor", b =>
                {
                    b.Navigation("Sintomas");
                });

            modelBuilder.Entity("ProyectoEmergencias.Models.Paciente", b =>
                {
                    b.Navigation("Sintomas");
                });
#pragma warning restore 612, 618
        }
    }
}
