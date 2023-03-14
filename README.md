# MF - My Finance

Projeto de controle das finanças pessoais

Este projeto foi criado para possibilitar que os usuários registrem suas receitas e despesas, permitindo a análise 
dos gastos e o planejamento financeiro. A aplicação deve permitir a criação de um Plano de Contas para categorizar 
todas as transações realizadas, além de disponibilizar um relatório das transações feitas por um período determinado.

## 💻 Tecnologias

O projeto utiliza as tecnologias:

- ASP .NET MVC
- SQL Server

## Banco de dados

Para o projeto utilizamos o banco de dados relacional SQL Server, seguindo a modelagem de dados apresentada:



## 💻 Arquitetura

O projeto foi divido em camadas, seguindo boas práticas de arquitetura, conforme desenho:



## 💻 Premissas

O projeto ainda não possui estrutura de deploy, neste caso utlizamos uma IDE para sua execução, sendo necessários os requisitos:

- [Git](https://git-scm.com/downloads)
- [VSCode](https://code.visualstudio.com/download)
- [.NET Core SDK](https://dotnet.microsoft.com/en-us/download)
- [SQL Server Express](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)



## 💻 Execucao

Para executar o projeto: 
- Navegar até a pasta /src via terminal (de sua preferência)
- Executar o comando `dotnet run`

## Acessando a aplicação

- HTTPS: https://localhost:7192
- HTTP: http://localhost:5228

## Navegação

- Tela de Plano de Contas

Nessa tela conseguimos criar, alterar, deletar e visualizar os planos de contas, informando uma descrição e o tipo (Receita ou Despesa):



- Tela de Transações

Nessa tela conseguimos criar, alterar, deletar e visualizar transações financeiras, informando a data, valor, histórico e selecionando qual o plano de conta relacionado a transação, além de podermos navegar para a tela de relatório:



- Tela de Relatório

Nessa tela conseguimos gerar um relatório por período, selecionando o intervalo de datas que desejamos pesquisar e clicando em filtrar:



Com o relatório gerado conseguimos em sequência gerar um gráfico clicando em "Gerar Gráfico" comparando as receitas e despesas do período:

