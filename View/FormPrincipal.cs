using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Entity;


namespace View
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            CarregarComboBoxVagas();
        }

        /// <summary>
        /// Lista de clientes para adição de cada cliente/candidato.
        /// </summary>
        List<EntityCliente> listaEntityClientes = new List<EntityCliente>();

        /// <summary>
        /// Variável para obter o IdVaga do ComboBox.
        /// </summary>
        long IdVagaComboBoxVaga = long.MinValue;

        /// <summary>
        /// variável para obter a descrição da vaga do COmboBox.
        /// </summary>
        string DescricaoVagaComboBoxVaga = string.Empty;

        /// <summary>
        /// Funcionalidade que vai chamar os métodos para inserir um candidato na Lista se as validações estiverem corretas.
        /// </summary>
        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            EntityCliente entityCliente = new EntityCliente();

            entityCliente.Nome = textBoxNome.Text;
            entityCliente.Sobrenome = textBoxSobrenome.Text;
            entityCliente.Cpf = textBoxCPF.Text;
            entityCliente.DataDeNascimento = dateTimePickerDataDeNascimento.Value;
            entityCliente.Idade = CalcularIdade(entityCliente.DataDeNascimento);
            entityCliente.MaiorDeIdade = CalcularMaiorDeIdade(entityCliente.DataDeNascimento);
            entityCliente.entityVaga.IdVaga = IdVagaComboBoxVaga;
            entityCliente.entityVaga.Descricao = DescricaoVagaComboBoxVaga;

            ControllerCliente controllerCliente = new ControllerCliente();

            entityCliente = controllerCliente.ValidarCliente(listaEntityClientes, entityCliente);

            if(entityCliente.ErroNaOperacao == true)
            {
                MessageBox.Show(entityCliente.MensagemDeErro, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                listaEntityClientes = controllerCliente.AdicionarNaLista(listaEntityClientes, entityCliente);
                /*for (int i = 0; i < listaEntityClientes.Count; i++)
                {
                    MessageBox.Show(listaEntityClientes[i].Nome);
                    MessageBox.Show(listaEntityClientes[i].Sobrenome);
                    MessageBox.Show(listaEntityClientes[i].Cpf);
                    MessageBox.Show(listaEntityClientes[i].DataDeNascimento.ToString());
                    MessageBox.Show(listaEntityClientes[i].Idade.ToString());
                    MessageBox.Show(listaEntityClientes[i].MaiorDeIdade.ToString());
                    MessageBox.Show(listaEntityClientes[i].entityVaga.IdVaga.ToString());
                    MessageBox.Show(listaEntityClientes[i].entityVaga.Descricao);
                }*/
                MontarGrid();
                MessageBox.Show("Candidato inserido com Sucesso !!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }

        /// <summary>
        /// Cálculo de Maior de Idade utilizando como base a Data de Nascimento informada.
        /// </summary>
        /// <param name="DataDeNascimento">Data de nascimento obtida através do componente DateTimePicker</param>
        /// <returns>Boolean True (Maior de idade) ou False (Menor de idade)</returns>
        private Boolean CalcularMaiorDeIdade(DateTime DataDeNascimento)
        {
            int idade = 0;
            idade = DateTime.Today.Year - DataDeNascimento.Year;

            if (DateTime.Today.DayOfYear < DataDeNascimento.DayOfYear)
            {
                idade = idade - 1;
            }

            if(idade < 18)
            {
                return false;  
            }
            else
            {
                return true;
            }

        }

        /// <summary>
        /// Cálculo de Idade utilizando como base a Data de Nascimento informada.
        /// </summary>
        /// <param name="DataDeNascimento">Data de nascimento obtida através do componente DateTimePicker</param>
        /// <returns>Int que será a idade da pessoa obtida através do cálculo matemático</returns>
        private int CalcularIdade(DateTime DataDeNascimento)
        {
            int idade = 0;

            idade = DateTime.Today.Year - DataDeNascimento.Year;

            if (DateTime.Today.DayOfYear < DataDeNascimento.DayOfYear)
            {
                idade = idade - 1;
            }

            return idade;
        }

        /// <summary>
        /// Apenas um preenchimento simples do combo de vagas tendo em vista que não havia a funcionalidade de vagas.
        /// </summary>
        private void CarregarComboBoxVagas()
        {
            comboBoxVaga.Items.Add("Estagiário");
            comboBoxVaga.Items.Add("Programador Júnior");
            comboBoxVaga.Items.Add("Programador Pleno");
            comboBoxVaga.Items.Add("Programador Sênior");
            comboBoxVaga.Items.Add("Analista Júnior");

            // Esse último preenchimento foi para testar o número de vagas sendo 15 se validava esse aspecto.
            //comboBoxVaga.Items.Add("Analista Pleno");
        }

        /// <summary>
        /// Obtenção do IdVaga para ser inserido no banco de dados e da descrição para posterior utilizando no Grid.
        /// </summary>
        private void comboBoxVaga_TextChanged(object sender, EventArgs e)
        {
            try
            {
                IdVagaComboBoxVaga = comboBoxVaga.SelectedIndex;
                DescricaoVagaComboBoxVaga = comboBoxVaga.SelectedItem.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione a vaga usando a seta ao lado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        /// <summary>
        /// Método de montagem do Grid para visualização dos dados.
        /// </summary>
        private void MontarGrid()
        {
            dataGridViewCandidatos.Rows.Clear();

            FormatarGrid();

            var linhasGrid = new List<string[]>();
            string maiorDeIdadeConvertido = string.Empty;
            string DataDenascimentoConvertido = string.Empty;

            foreach (EntityCliente entityCliente in listaEntityClientes)
            {
                if(entityCliente.MaiorDeIdade == false)
                {
                    maiorDeIdadeConvertido = "Não";
                }
                else
                {
                    maiorDeIdadeConvertido = "Sim";
                }

                DataDenascimentoConvertido = entityCliente.DataDeNascimento.ToShortDateString();

                string[] linhaGrid = new string[] {entityCliente.Nome, entityCliente.Sobrenome,
                                                   entityCliente.Cpf, DataDenascimentoConvertido,
                                                   entityCliente.Idade.ToString(), maiorDeIdadeConvertido,
                                                   entityCliente.entityVaga.Descricao};
                linhasGrid.Add(linhaGrid);
            }

            foreach (string[] linhaArray in linhasGrid)
            {
                dataGridViewCandidatos.Rows.Add(linhaArray);
            }
        }

        /// <summary>
        /// Apenas um método de formatação do grid.
        /// </summary>
        private void FormatarGrid()
        {
            //Nome, Sobrenome, CPF, Data de Nascimento, Idade, É maior de idade? e Vaga

            dataGridViewCandidatos.ColumnCount = 7;
            dataGridViewCandidatos.Columns[0].Name = "Nome";
            dataGridViewCandidatos.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewCandidatos.Columns[1].Name = "Sobrenome";
            dataGridViewCandidatos.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewCandidatos.Columns[2].Name = "CPF";
            dataGridViewCandidatos.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewCandidatos.Columns[3].Name = "Data de Nascimento";
            dataGridViewCandidatos.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewCandidatos.Columns[4].Name = "Idade";
            dataGridViewCandidatos.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewCandidatos.Columns[5].Name = "É maior de idade?";
            dataGridViewCandidatos.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewCandidatos.Columns[6].Name = "Vaga associada";
            dataGridViewCandidatos.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;

            dataGridViewCandidatos.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCandidatos.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCandidatos.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCandidatos.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCandidatos.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCandidatos.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCandidatos.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewCandidatos.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        /// <summary>
        /// Funcionalidade Salvar as informações no banco de dados.
        /// </summary>
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if(listaEntityClientes.Count > 0)
            {
                ControllerCliente controllerCliente = new ControllerCliente();

                ErrorEntity errorEntity = new ErrorEntity();

                errorEntity = controllerCliente.InserirNoBancoDeDados(listaEntityClientes);

                if (errorEntity.ErroNaOperacao == true)
                {
                    MessageBox.Show(errorEntity.MensagemDeErro, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Os dados foram inseridos com sucesso no Banco de Dados.", "Sucesso - Dados Inseridos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MontarGrid();
                }
            }
            else
            {
                //MessageBox.Show("A lista está vazia e por isso essa funcionalidade está desabilitada.");
                MessageBox.Show("A lista está vazia e por isso essa funcionalidade está desabilitada.", "Erro - Lista Vazia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
    }
}
