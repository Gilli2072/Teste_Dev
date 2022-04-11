using System;

namespace Entity
{
    /// <summary>
    /// Entidade relacionada ao candidato/cliente.
    /// </summary>
    public class EntityCliente : ErrorEntity
    {
        public long IdCliente { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public int Idade { get; set; }
        public Boolean MaiorDeIdade { get; set; }

        public EntityVaga entityVaga;

        public EntityCliente()
        {
            IdCliente = long.MinValue;
            Nome = string.Empty;
            Sobrenome = string.Empty;
            Cpf = string.Empty;
            DataDeNascimento = DateTime.MinValue;
            Idade = int.MinValue;
            MaiorDeIdade = false;
            entityVaga = new EntityVaga();
        }

    }
}
