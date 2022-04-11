using System;
using Entity;
using Business;
using System.Collections.Generic;

namespace Controller
{
    /// <summary>
    /// Classe para fazer a intermediação entre a View e as demais camadas.
    /// </summary>
    public class ControllerCliente
    {
        /// <summary>
        /// Método que irá chamar a funcionalidade de AdicionarNaLista um candidato.
        /// </summary>
        /// <param name="listaEntityClientes">Lista com candidatos (ou não) com algum dado.</param>
        /// <param name="entityCliente">Cliente/Candidato com as informações obtidas da tela.</param>
        /// <returns>Lista com os candidatos.</returns>
        public List<EntityCliente> AdicionarNaLista (List<EntityCliente> listaEntityClientes, EntityCliente entityCliente)
        {

            BusinessCliente businessCliente = new BusinessCliente();

            listaEntityClientes = businessCliente.AdicionarNaListaDeCandidatos(listaEntityClientes, entityCliente);

            return listaEntityClientes;
        }
        
        /// <summary>
        /// Método responsável por fazer a chamada da funcionalidade validar os dados do cliente inseridos na tela.
        /// </summary>
        /// <param name="listaEntityClientes">Lista de clientes.</param>
        /// <param name="entityCliente">Entidade com os dados do cliente isnerido an tela.</param>
        /// <returns>Entidade cliente com os dados validados.</returns>
        public EntityCliente ValidarCliente(List<EntityCliente> listaEntityClientes, EntityCliente entityCliente)
        {
            BusinessCliente businessCliente = new BusinessCliente();

            entityCliente = businessCliente.ValidarCliente(listaEntityClientes, entityCliente);

            return entityCliente;
        }
        
        /// <summary>
        /// Método responsável por chamar a funcionalidade de isnerir a informação no banco de dados.
        /// </summary>
        /// <param name="listaEntityClientes">Lista com todos os clientes para serem inseridos no banco de dados.</param>
        /// <returns>Entidade com informação de sucesso ou não.</returns>
        public ErrorEntity InserirNoBancoDeDados(List<EntityCliente> listaEntityClientes)
        {
            BusinessCliente businessCliente = new BusinessCliente();

            ErrorEntity errorEntity = new ErrorEntity();

            errorEntity = businessCliente.InserirNoBancoDeDados(listaEntityClientes);

            return errorEntity;
        }
    }
}
