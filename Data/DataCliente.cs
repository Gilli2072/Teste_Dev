using System;
using System.Collections.Generic;
using System.Data;
using Entity;
using MySql.Data.MySqlClient;

namespace Data
{
    public class DataCliente
    {
        /// <summary>
        /// Método para inserir os dados no banco de dados.
        /// </summary>
        /// <param name="listaEntityClientes">Lista com todos os candidatos validados e pronto para serem adicionados.</param>
        /// <returns>Entidade que terá a informação se a operação teve sucesso ou não.</returns>
        public ErrorEntity GravarClienteBancoDeDados(List<EntityCliente> listaEntityClientes)
        {
            ErrorEntity errorEntity = new ErrorEntity();

            try
            {
                string DataDenascimentoConvertido = string.Empty;
                int maiorDeIdadeConvertido = int.MinValue;

                for (int i = 0; i < listaEntityClientes.Count; i++)
                {
                    DataDenascimentoConvertido = listaEntityClientes[i].DataDeNascimento.ToShortDateString();
                    DateTime dataConvertidaDeVoltaDateTime = Convert.ToDateTime(DataDenascimentoConvertido);
                    string DataMYSQL = dataConvertidaDeVoltaDateTime.Year.ToString() +
                                       "-" + dataConvertidaDeVoltaDateTime.Month.ToString() +
                                       "-" + dataConvertidaDeVoltaDateTime.Day.ToString();

                    if (listaEntityClientes[i].MaiorDeIdade == false)
                    {
                        maiorDeIdadeConvertido = 0;
                    }
                    else
                    {
                        maiorDeIdadeConvertido = 1;
                    }

                    MySqlConnection connection = new MySqlConnection("Server=localhost;Database=Pessoas;Uid=root;Pwd=vertrigo;");

                    MySqlCommand command = new MySqlCommand("INSERT INTO Candidato (Nome, Sobrenome, Cpf," +
                                                            "DataDeNascimento, Idade, MaiorDeIdade, IdVaga) VALUES" +
                                                            "(?, ?, ?, ?, ?, ?, ?);", connection);

                    connection.Open();

                    command.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = listaEntityClientes[i].Nome;
                    command.Parameters.Add("@Sobrenome", MySqlDbType.VarChar).Value = listaEntityClientes[i].Sobrenome;
                    command.Parameters.Add("@Cpf", MySqlDbType.VarChar).Value = listaEntityClientes[i].Cpf;
                    command.Parameters.Add("@DataDeNascimento", MySqlDbType.Date).Value = DataMYSQL;
                    command.Parameters.Add("@Idade", MySqlDbType.Int16).Value = listaEntityClientes[i].Idade;
                    command.Parameters.Add("@MaiorDeIdade", MySqlDbType.Int16).Value = maiorDeIdadeConvertido;
                    command.Parameters.Add("@IdVaga", MySqlDbType.Int64).Value = listaEntityClientes[i].entityVaga.IdVaga;

                    command.CommandType = CommandType.Text;

                    command.ExecuteNonQuery();

                    connection.Close();
                }

            }
            catch (Exception e)
            {
                errorEntity.MensagemDeErro = e.Message;
                errorEntity.ErroNaOperacao = true;
            }

            return errorEntity;
        }

    }
}
