using System;
using System.Collections.Generic;

namespace ASP_NetCore.Models
{
    public class Alumno : ObjetoEscuelaBase
    {
        public List<Evaluacion> Evaluaciones { get; set; }
        public Alumno()
        {
            Evaluaciones = new List<Evaluacion>();
        }
    }
}