using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    /// <summary>
    /// Entidade relacionada a vaga.
    /// </summary>
    public class EntityVaga
    {
        public long IdVaga { get; set; }
        public string Descricao { get; set; }

        public EntityVaga()
        {
            IdVaga = long.MinValue;
            Descricao = string.Empty;
        }
    }
}
