using System;
using System.Collections.Generic;
using ASP_NetCore.Models;

namespace ASP_NetCore.Models
{
    public class Curso : ObjetoEscuelaBase
    {
        public TiposJornada TipoJornada { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
        public List<Alumno> Alumnos { get; set; }
        public string Address { get; set; }
        public string EscuelaId { get; set; }
        public Escuela Escuela { get; set; }
    }
}