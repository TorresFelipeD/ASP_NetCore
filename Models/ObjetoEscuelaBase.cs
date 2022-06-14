using System;
using System.ComponentModel.DataAnnotations;

namespace ASP_NetCore.Models
{
    public abstract class ObjetoEscuelaBase
    {
        [Key]
        public string Id { get; private set; }
        public string Nombre { get; set; }

        public ObjetoEscuelaBase()
        {
            Id = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return $"{Nombre},{Id}";
        }
    }
}