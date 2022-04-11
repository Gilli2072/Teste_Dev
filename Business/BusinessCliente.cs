using System;
using System.Collections.Generic;
using Entity;
using Data;

namespace Business
{
    public class BusinessCliente
    {
        /// <summary>
        /// Método de validação dos dados informados do cliente/candidato.
        /// </summary>
        /// <param name="listaEntityCliente">Lista de clientes/candidatos que já pode conter dados.</param>
        /// <param name="entityCliente">Cliente/candidato com dados que foram preenchidos na tela.</param>
        /// <returns>EntityCliente que é o cliente/candidato já validado e pronto para ser isnerido na lista.</returns>
        public EntityCliente ValidarCliente(List<EntityCliente> listaEntityCliente, EntityCliente entityCliente)
        {
            entityCliente = ValidarCamposPreenchidos(entityCliente);

            if (entityCliente.ErroNaOperacao == true)
            {
                return entityCliente;
            }

            entityCliente = ValidarMesmoCPFNaLista(listaEntityCliente, entityCliente);

            if (entityCliente.ErroNaOperacao == true)
            {
                return entityCliente;
            }

            entityCliente = ValidarQuantidadeTotalDeCandidatosPorVaga(listaEntityCliente, entityCliente);

            if (entityCliente.ErroNaOperacao == true)
            {
                return entityCliente;
            }

            entityCliente = ValidarQuantidadeDeCandidatosTotal(listaEntityCliente, entityCliente);

            if (entityCliente.ErroNaOperacao == true)
            {
                return entityCliente;
            }

            return entityCliente;
        }
        
        /// <summary>
        /// Método que irá adicionar o cliente/candidato já validado na lista.
        /// </summary>
        /// <param name="listaEntityCliente">Lista de clientes/candidatos.</param>
        /// <param name="entityCliente">Candidato/cliente a ser inserido na lista</param>
        /// <returns>Lista de cliente/candidato com 1 elemento a mais contido nela.</returns>
        public List<EntityCliente> AdicionarNaListaDeCandidatos(List<EntityCliente> listaEntityCliente, EntityCliente entityCliente)
        {
            listaEntityCliente.Add(entityCliente);
            return listaEntityCliente;
        }
        
        /// <summary>
        /// Método que irá chamar a funcionalidade de inserir os dados no banco de dados.
        /// </summary>
        /// <param name="listaEntityClientes">Lista de cliente/candidato a ser inserida no banco.</param>
        /// <returns>ErrorEntity entidade que irá conter a informação de que a operação foi realizada com sucesso ou não.</returns>
        public ErrorEntity InserirNoBancoDeDados(List<EntityCliente> listaEntityClientes)
        {
            ErrorEntity errorEntity = new ErrorEntity();

            DataCliente dataCliente = new DataCliente();

            errorEntity = dataCliente.GravarClienteBancoDeDados(listaEntityClientes);

            return errorEntity;
        }
        
        /// <summary>
        /// Método que irá validar se os campos foram corretamentes preenchidos na tela.
        /// </summary>
        /// <param name="entityCliente">Entidade com os dados informados.</param>
        /// <returns>Entidade que irá conter o reasultado da operação (erro ou sucesso).</returns>
        private EntityCliente ValidarCamposPreenchidos(EntityCliente entityCliente)
        {
            if(entityCliente.Nome == string.Empty || entityCliente.Nome == "")
            {
                entityCliente.ErroNaOperacao = true;
                entityCliente.MensagemDeErro = "O nome deve ser preenchido. O Cliente não foi adicionado à lista.";
            }
            else if(entityCliente.Sobrenome == string.Empty || entityCliente.Sobrenome == "")
            {
                entityCliente.ErroNaOperacao = true;
                entityCliente.MensagemDeErro = "O sobrenome deve ser preenchido. O Cliente não foi adicionado à lista.";
            }
            else if(entityCliente.Cpf == string.Empty || entityCliente.Cpf == "")
            {
                entityCliente.ErroNaOperacao = true;
                entityCliente.MensagemDeErro = "O cpf deve ser preenchido. O Cliente não foi adicionado à lista.";
            }
            else if (entityCliente.entityVaga.IdVaga == long.MinValue)
            {
                entityCliente.ErroNaOperacao = true;
                entityCliente.MensagemDeErro = "A vaga deve ser preenchida. O Cliente não foi adicionado à lista.";
            }

            return entityCliente;
        }
        
        /// <summary>
        /// Validação se já existe na Lista um candidato com o mesmo CPF informado no cadastro.
        /// </summary>
        /// <param name="listaEntityCliente">Lista que contém os clientes já adicionados.</param>
        /// <param name="entityCliente">Novo cliente a ser adicionado.</param>
        /// <returns>Entidade com o cliente e se a operação foi sucesso ou não.</returns>
        private EntityCliente ValidarMesmoCPFNaLista(List<EntityCliente> listaEntityCliente, EntityCliente entityCliente)
        {
            for (int i = 0; i < listaEntityCliente.Count; i++)
            {
                if(entityCliente.Cpf == listaEntityCliente[i].Cpf)
                {
                    entityCliente.ErroNaOperacao = true;
                    entityCliente.MensagemDeErro = "Este CPF já está cadastrado na lista. O Cliente não foi adicionado à lista.";
                }
            }

            return entityCliente;
        }
        
        /// <summary>
        /// Validação referente ao total de candidatos por vaga. Se já houver 3 candidatos
        /// na mesma vaga, um novo candidato não será aceito nesta vaga.
        /// </summary>
        /// <param name="listaEntityCliente">Lista com os clientes já adicionados.</param>
        /// <param name="entityCliente">Novo cliente a ser validado para ser inserido na lista.</param>
        /// <returns>Entidade de cliente validada se houve sucesso ou não.</returns>
        private EntityCliente ValidarQuantidadeTotalDeCandidatosPorVaga(List<EntityCliente> listaEntityCliente, EntityCliente entityCliente)
        {
            int QuantidadeDeCandidatosVaga = 0;
            long IdVaga = entityCliente.entityVaga.IdVaga;

            for (int i = 0; i < listaEntityCliente.Count; i++)
            {
                if (listaEntityCliente[i].entityVaga.IdVaga == IdVaga)
                {
                    QuantidadeDeCandidatosVaga ++ ;
                }
            }

            if(QuantidadeDeCandidatosVaga >= 3)
            {
                entityCliente.ErroNaOperacao = true;
                entityCliente.MensagemDeErro = "O número máximo de candidatos para esta vaga já foi atingido. O Cliente não foi adicionado à lista.";
            }

            return entityCliente;
        }
        
        /// <summary>
        /// Validação referente ao máximo de candidatos ser 15. São 5 vagas com no máximo 3 candidatos por vaga.
        /// </summary>
        /// <param name="listaEntityCliente">Lista que posssui os clientes já adicionados.</param>
        /// <param name="entityCliente">Candidato a ser validado se poderá ou não ser adicionado na lista.</param>
        /// <returns>Entidade com validações de sucesso ou não.</returns>
        private EntityCliente ValidarQuantidadeDeCandidatosTotal(List<EntityCliente> listaEntityCliente, EntityCliente entityCliente)
        {
            if(listaEntityCliente.Count >= 15)
            {
                entityCliente.ErroNaOperacao = true;
                entityCliente.MensagemDeErro = "O número máximo de candidatos já foi atingido.  O Cliente não foi adicionado à lista.";
            }

            return entityCliente;
        }
    }
}
