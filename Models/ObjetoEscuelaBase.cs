using System;
using System.ComponentModel.DataAnnotations;

namespace ASP_NetCore.Models
{
    public abstract class ObjetoEscuelaBase
    {
        [Key]
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }

        public ObjetoEscuelaBase()
        {
            UniqueId = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return $"{Nombre},{UniqueId}";
        }
    }
}