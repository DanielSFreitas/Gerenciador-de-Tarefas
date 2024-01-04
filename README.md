# API Gerenciador de Tarefas
Este projeto é uma API simples para gerenciar tarefas, proporcionando operações básicas de CRUD (Criar, Ler, Atualizar e Deletar). A API foi construída usando ASP.NET Core e Entity Framework Core para interagir com um banco de dados SQL Server.

## Estrutura do Projeto
### Gerenciador_de_Tarefas.Models
#### EnumStatusTarefa 
Enumeração que define os possíveis estados de uma tarefa, como "Pendente" e "Finalizado".
#### Tarefa
Classe que representa a entidade de tarefa.
Inclui propriedades como Id, Titulo, Descricao, Data, e Status.
### Gerenciador_de_Tarefas.Context
#### OrganizadorContext
Classe que estende DbContext do Entity Framework Core.
Configura o contexto do banco de dados e define um DbSet para a entidade Tarefa.
### Gerenciador_de_Tarefas.Controllers
#### TarefaController
Controlador que gerencia as operações relacionadas às tarefas.
Inclui métodos para obter tarefas por ID, todos os títulos, por data, por status, criar, atualizar e deletar tarefas.
Utiliza injeção de dependência para acessar o contexto do banco de dados.
## Endpoints da API
GET /Tarefa/{id}: Obtém os detalhes de uma tarefa específica.
GET /Tarefa/ObterTodos: Obtém todas as tarefas.
GET /Tarefa/ObterPorTitulo?titulo={titulo}: Obtém tarefas com base no título.
GET /Tarefa/ObterPorData?data={data}: Obtém tarefas com base na data.
GET /Tarefa/ObterPorStatus?status={status}: Obtém tarefas com base no status.
POST /Tarefa/CriarTarefa: Cria uma nova tarefa.
PUT /Tarefa/{Atualizar}: Atualiza os detalhes de uma tarefa existente.
DELETE /Tarefa/{id}: Deleta uma tarefa com base no ID.
## Configuração e Execução
Clone o repositório para o seu ambiente local.
Configure a string de conexão do banco de dados no arquivo appsettings.json.
Certifique-se de ter o ambiente de desenvolvimento .NET Core instalado.
Execute o aplicativo utilizando dotnet run no terminal.
Dependências
Entity Framework Core: Para interação com o banco de dados.
Newtonsoft.Json: Para manipulação de JSON.
Swashbuckle: Para integração com Swagger/OpenAPI e documentação da API.
## Swagger e Documentação da API
A API inclui suporte para Swagger/OpenAPI. Ao executar o aplicativo, acesse /swagger no navegador para explorar e testar os endpoints.
Sinta-se à vontade para contribuir, reportar problemas ou sugerir melhorias para este projeto.
