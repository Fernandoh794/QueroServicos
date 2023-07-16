Menu
---
[Seu projeto](#nome) | [Dicas, repositórios e materiais úteis](#dicas-repositórios-e-materiais-úteis)| [Prazo](prazo) | [Projeto Anteriores](projetos-anteriores)

---

<details>
  <summary>Detalhes do seu projeto</summary>
  
# Nome

## < Quero Serviços >

## Membros da equipe (De 3 a 5 pessoas. Identificar o líder)

- Aluno 1 Fábio Martins Júnior (líder)
- Aluno 2 Fernando Henrique Santana
- Aluno 3 Álesson Carlos Costa dos Santos

### RESUMO/JUSTIFICATIVA

Quero Serviços é um aplicativo abrangente que conecta usuários a uma ampla gama de profissionais, incluindo serviços domiciliares, mecânicos, aulas particulares e outros. Os usuários podem encontrar profissionais qualificados, verificar seus perfis e solicitar os serviços necessários de forma conveniente e confiável. O aplicativo oferece uma solução abrangente para atender às diversas necessidades dos usuários.

### OBJETIVOS

**Template de Objetivos para o Aplicativo Quero Serviços**

Objetivo principal:
Conectar usuários a profissionais qualificados e confiáveis, proporcionando uma plataforma conveniente para solicitar uma ampla gama de serviços gerais.

Objetivos específicos:
1. Facilitar a busca e contratação de serviços domiciliares, mecânicos, aulas particulares e outros serviços gerais através do aplicativo Quero Serviços.
2. Oferecer aos usuários uma seleção abrangente de profissionais verificados, com perfis detalhados que incluem experiência, qualificações e avaliações de outros usuários.
3. Garantir a conveniência e a transparência na comunicação entre usuários e profissionais, permitindo que discutam detalhes do trabalho, acordem preços e requisitos específicos diretamente pelo aplicativo.
4. Estabelecer uma reputação de confiança e qualidade, garantindo que apenas profissionais experientes e confiáveis sejam cadastrados no aplicativo Quero Serviços.
5. Continuamente melhorar e aprimorar a experiência do usuário, por meio de atualizações regulares do aplicativo e feedback dos usuários, visando fornecer um serviço cada vez mais eficiente e satisfatório.


## FUNCIONALIDADES

- [ ] Apresentar os requisitos funcionais
- [x] Apresentar os requisitos não-funcionais
- [ ] Indicar os membros da equipe
- [x] Exibir repositório e dicas que são comuns

### REQUISITOS NÃO FUNCIONAIS

- Utilizar .NET CORE 3.1+
- Utilizar [EF Core](https://docs.microsoft.com/pt-br/ef/core/) para manipução de dados
- Possuir, pelo menos três, relacionamentos 1:1 (um para um)
- Possuir, pelo menos três, relacionamentos 1:N (um para muitos)
- Possuir, pelo menos um, relacionamento M:N (muito para muitos)
- Fazer um programa, em C# com Entity Framework, para realizar carga inicial dos dados
- Utilizar campos de data, numéricos e textuais


</details>
  
<details>  
  <summary>Dicas, repositórios e materiais úteis</summary>
  
## Dicas, repositórios e materiais úteis

- https://github.com/CBSIIFSLagarto/2021_2_web2
- Documentação sobre [Diretrizes de design de estrutura] 
- [A collection of awesome **.NET CORE** libraries, tools, frameworks, and software](https://github.com/thangchung/awesome-dotnet-core)
- [A collection of awesome **.NET** libraries, tools, frameworks, and software](https://github.com/quozd/awesome-dotnet) - Referência, pois é para .NET e não .NET CORE
- Configuration
  - [Definições Gerais](https://docs.microsoft.com/en-us/dotnet/core/extensions/configuration)
  - [Configuration in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration/?view=aspnetcore-6.0)
  - [Configuration providers](https://docs.microsoft.com/en-us/dotnet/core/extensions/configuration-providers#environment-variable-configuration-provider)
- Banco de dados
  - [Sqlserver e docker: um guia instantâneo](sqlserver_e_docker.md)
  - *Migrations*
    - [Visão geral](https://docs.microsoft.com/pt-br/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli)
    - [Exemplo: aplicação de uma *migration*](https://docs.microsoft.com/pt-br/aspnet/core/data/ef-mvc/migrations?view=aspnetcore-3.1)
  - Carga de dados iniciais (*seed data*)
    - [Data seeding]
    - [migrations/seeding](https://www.learnentityframeworkcore.com/migrations/seeding)
  - [Tutorial do Entityframework + console app](https://www.tektutorialshub.com/entity-framework-core/ef-core-console-application/)
- Globalização
  - [Usar (",") como separador decimal](https://github.com/dotnet/AspNetCore.Docs/issues/4076#issuecomment-326590420)
  - [Vários idiomas](https://docs.microsoft.com/pt-br/aspnet/core/fundamentals/localization?view=aspnetcore-5.0)
- Tela
  - [Como filtrar por categoria](https://docs.microsoft.com/pt-br/aspnet/core/tutorials/first-mvc-app/search?view=aspnetcore-5.0)
  - [Gerenciamento de estado e sessão](https://docs.microsoft.com/pt-br/aspnet/core/fundamentals/app-state?view=aspnetcore-5.0)
- Upload de arquivos
  - A pasta [/UploadArquivos](/UploadArquivos/README.md) contém a cópia do código que é detalhado na [documentação](https://docs.microsoft.com/pt-br/aspnet/core/mvc/models/file-uploads?view=aspnetcore-5.0). 

### Gerenciar seu trabalho no GitHub

O github contém várias ferramentas que permitem o gerenciamento projeto, promovendo entre outros recursos a rastreabilidade e o gerenciamento das atividades. Saiba mais nos links abaixo.

- [Gerenciar seu trabalho no GitHub](https://docs.github.com/pt/free-pro-team@latest/github/managing-your-work-on-github)
- [Closing issues using keywords](https://docs.github.com/en/enterprise/2.16/user/github/managing-your-work-on-github/closing-issues-using-keywords)
- [Vinculando uma pull request a um problema](https://docs.github.com/pt/free-pro-team@latest/github/managing-your-work-on-github/linking-a-pull-request-to-an-issue)
- [GitHub: How can I close the two issues with commit message?](https://stackoverflow.com/questions/60027222/github-how-can-i-close-the-two-issues-with-commit-message) 

  </details>
  
  <details>  
    <summary> Prazo</summary>
    
## Prazo

Data | Descrição
:---:|:---
??/?? | Definição do projeto a ser executado
??/?? | Apresentar o modelo conceitual da solução proposta
??/?? | [Modelo implementado](https://docs.microsoft.com/pt-br/ef/core/modeling/) no EF Core
??/?? | Aplicação que permite a [carga incial/teste][Data seeding] do modelo implementado com EF Core
??/?? | Entrega de [protótipos](prototipos/prototipos.md) das principais telas do sistema proposto (e que atendam aos itens descritos no REQUISITOS NÃO FUNCIONAIS)

  </details>
  
## Project status
Este projeto é um *template* para a definição da avaliação da disciplina programação web 2, do período de 2021.2 (aulas remotas), do IFS

## Projetos anteriores

- [Turma 2021_1](https://github.com/CBSIIFSLagarto/2021_1_web2/network/members)

[Diretrizes de design de estrutura]: https://docs.microsoft.com/pt-br/dotnet/standard/design-guidelines/
[Data seeding]: https://docs.microsoft.com/en-us/ef/core/modeling/data-seeding
