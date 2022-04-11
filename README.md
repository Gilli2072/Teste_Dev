# Teste_Dev
Considerações iniciais

A interpretação da tarefa estará a seguir. Eu acredito que as informações passadas possuem algum conflito ou relativa dificuldade tendo em vista uma tentativa de obter uma abstração da forma de pensar a respeito dos candidatos. Enviar muitos e-mails ou um e-mail grande, poderia impactar a pessoa que estivesse recebendo para tirar as dúvidas. Se a forma falada estivesse disponível, talvez fosse mais rápido e ágil mas, decidi tomar as decisões de desenvolvimento usando o que foi passado de forma explícita. O problema a ser desenvolvido se encontra dentro do projeto.

Explicações do desenvolvimento

ErrorEntity - essa entidade possui apenas dois campos que são MensagemDeErro e ErroNaOperacao. A entidade EntityCliente herda essses atributos da ErrorEntity para ajudar quando ocorre um erro de, por exemplo, o CPF não ser preenchido. O ErroNaOperação receberá o valor true e aí a mensagem de "O cpf deve ser preenchido.". Essa foi a forma de interpretação que eu quis implementar para ajudar a obter os erros e levar as respectivas mensagens dentro das camadas do desenvolvimento. Ela se encontra dentro do projeto Entity.

EntityVaga - essa entidade faz referência as vagas que o candidato pode ser associado. A solicitação por e-mail informa que o candidato deve estar associado a uma vaga então, essa foi a decisão que tomei de implementar essa funcionalidade baseado no e-mail, é informado que "A tabela que irá agrupar os candidatos vai conter as informações Nome, Sobrenome, CPF, Data de Nascimento, Idade, É maior de idade? e Vaga (ao qual o candidato foi associado).". Ela se encontra dentro do projeto Entity.

EntityCliente - essa entidade possui os atributos IdCliente, Nome, Sobrenome, Cpf, DataDeNascimento, Idade, MaiorDeIdade e entityVaga. Em um primeiro momento, é informado poucos campos a serem preeenchidos e outros que serão preenchidos utilziando contas como, saber a idade da pessoa e se é maior de idade usando apenas como base a data de nascimento. O campo IdCliente é usado como chave primária no banco e por isso foi adicionada a Entidade. Ela se encontra dentro do projeto Entity. A informação desta entidade, foi obtida com relação a este trecho do e-mail: "A tabela que irá agrupar os candidatos vai conter as informações Nome, Sobrenome, CPF, Data de Nascimento, Idade, É maior de idade? e Vaga (ao qual o candidato foi associado)".

Obter Idade - A idade é obtida através do método CalcularIdade que se encontra na classe FormPrincipal.cs, dentro do projeto View.

Obter informação de ser Maior de Idade ou não - Isso é obtido através do método CalcularMaiorDeIdade que se encontra na classe FormPrincipal.cs, dentro do projeto View.

Inserir candidato na Lista - Eu preferi, conforme minha interpretação, antes de inserir na lista de candidatos, realizar todas as validações necessárias e se forem atendidas, aí sim os dados irão para a lista. A Lista de candidatos foi declarada na classe FormPrincipal.cs, dentro do projeto View. As validações serão informadas posteriormente.

Validações - Tudo ocorre no projeto Business, classe BusinessCliente.cs com o método ValidarCliente. Esse método, utiliza outros métodos privados que são o ValidarCamposPreenchidos, ValidarMesmoCPFNaLista, ValidarQuantidadeTotalDeCandidatosPorVaga e ValidarQuantidadeDeCandidatosTotal.

Cadastro ser feito em dois momentos na mesma tela - A pessoa preenche os dados corretamente e, ao clicar no botão "Adicioanr na Lista", a lista é preenchida e o Grid é montado com os dados. Se a pessoa clicar no botão "Salvar no Banco de Dados", os dados que estão na lista irão para a inserção no banco de dados. Isso pdoe ser conferido no projeto View, classe FormPrincipal.cs e no método buttonAdicionar_Click (adiciona na lista) e no método buttonSalvar_Click (salva a lista no banco de dados).

Inserir no Banco de dados - Foi utilizado o banco de dados MYSQL com apenas uma tabela conforme interpretação das funcionalidades.
