using System;
using System.Collections.Generic;
using Fundamentos_ASP_NetCore.Models;

namespace ASP_NetCore.Models
{
    public class Escuela: ObjetoEscuelaBase
    {
        public string NombreEscuela { get; set; }
        public int AñoGraduacion { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }

        public string Address { get; set; }

        public TiposEscuela TipoEscuela { get; set; }
        public List<Curso> Cursos { get; set; }
        /*
            Existen dos tipos de contructores
            • El constructor común:
                public Escuela(string NombreEscuela, int AñoGraduacion)
                {
                    this.NombreEscuela = NombreEscuela;
                    this.AñoGraduacion = AñoGraduacion;
                }

            • El constructor por tuplas:
                public Escuela(string NombreEscuela, int AñoGraduacion) => (this.NombreEscuela,this.AñoGraduacion) = (NombreEscuela,AñoGraduacion);
        */
        public Escuela(
            string NombreEscuela,
            int AñoGraduacion,
            string Pais = "",
            string Ciudad = "",
            TiposEscuela TipoEscuela = TiposEscuela.NoDefinida
        )
        {
            (this.NombreEscuela, this.AñoGraduacion) = (NombreEscuela, AñoGraduacion);
            this.Pais = Pais;
            this.Ciudad = Ciudad;
            this.TipoEscuela = TipoEscuela;
        }

        public override string ToString()
        {
            string strEscuela = $"Nombre Escuela: {NombreEscuela}";
            strEscuela += Environment.NewLine;
            strEscuela += $"Año de Graduación: {AñoGraduacion}";
            strEscuela += Environment.NewLine;
            strEscuela += $"País: {Pais}";
            strEscuela += Environment.NewLine;
            strEscuela += $"Ciudad: {Ciudad}";
            strEscuela += Environment.NewLine;
            strEscuela += $"Tipo de Escuela: {TipoEscuela}";
            return strEscuela;
        }
    }
}