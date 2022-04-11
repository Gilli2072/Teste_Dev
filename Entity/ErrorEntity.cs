using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    /// <summary>
    /// Entidade que será utilizada para saber se houve erro e qual mensagem que deverá ser mostrada no form.
    /// </summary>
    public class ErrorEntity
    {
        public string MensagemDeErro { get; set; }
        public bool ErroNaOperacao { get; set; }

        public ErrorEntity()
        {
            this.MensagemDeErro = string.Empty;
            this.ErroNaOperacao = false;
        }
    }
}
