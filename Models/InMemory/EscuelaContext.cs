using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ASP_NetCore.Models.InMemory
{
    public class EscuelaContext : DbContext
    {
        public DbSet<Escuela> Escuelas { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Evaluacion> Evaluaciones { get; set; }

        public EscuelaContext(DbContextOptions<EscuelaContext> options): base (options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            
            base.OnModelCreating(modelBuilder);

            Random rdm = new Random();
            Escuela escuela = new Escuela(
                NombreEscuela: "Diego's School",
                AñoGraduacion: DateTime.Now.AddYears(-rdm.Next(5)).Year,
                Pais: "Colombia",
                Ciudad: "Bogota"
            );
            escuela.Nombre = "Academia de Aprendizaje Online";
            escuela.Address = "Av Cll 55 # 84 - 66";
            escuela.TipoEscuela = TiposEscuela.PreEscolar;

            modelBuilder.Entity<Escuela>().HasData(escuela);
            modelBuilder.Entity<Asignatura>().HasData(
                new Asignatura(){Nombre = "Programación"},
                new Asignatura(){Nombre = "Algebra"},
                new Asignatura(){Nombre = "Historia"},
                new Asignatura(){Nombre = "Ciencias"});

            modelBuilder.Entity<Alumno>().HasData(GenerarAlumnos(10).ToArray());
        }

        private List<Alumno> GenerarAlumnos(int cantidad = 20)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno() { Nombre = $"{n1} {n2} {a1}" };

            return listaAlumnos.OrderBy((x) => x.UniqueId).Take(cantidad).ToList();
        }

    }
}