# Desafio Fullstack Junior – Gerenciamento de Tarefas

* O candidato deverá desenvolver uma aplicação full stack que simule um ambiente real de trabalho. 
* O projeto consiste na criação de uma API RESTful utilizando ASP.NET Core (.NET 9.0.3) 
* que será consumida por uma interface construída em Angular (versão 19.2.5). 
* A aplicação tem como objetivo gerenciar tarefas, permitindo operações de criação, leitura, atualização e deleção (CRUD).

## Objetivo do Projeto
    
* Construir uma aplicação monolítica com arquitetura bem definida e com ênfase nas boas práticas de desenvolvimento.
* Demonstrar conhecimentos em desenvolvimento de API RESTful, 
* integração com frontend e aplicação de conceitos de SOLID, Clean Code e testes automatizados.
* Simular desafios reais como documentação, versionamento, deploy e monitoramento.

# Requisitos Funcionais

### Gerenciamento de Tarefas

Cada tarefa deve conter os seguintes campos:

* Id: Identificador único (auto gerado).

* Título: Nome breve da tarefa.

* Descrição: Detalhamento da tarefa.

* Data de Criação: Registro de data e hora.

* Data de Conclusão: Data prevista ou efetiva de conclusão.

* Status: Indicador do estado da tarefa (ex.: Pendente, Em Andamento, Concluída).

Endpoints da API (ASP.NET Core)
    GET /api/tasks

Listar todas as tarefas com opções de paginação, filtros (por status e data) e ordenação.

    GET /api/tasks/{id}

Obter os detalhes de uma tarefa específica.

    POST /api/tasks

Criar uma nova tarefa com validação dos campos.

    PUT /api/tasks/{id}

Atualizar dados de uma tarefa existente.

    DELETE /api/tasks/{id}

Remover uma tarefa do sistema.

## Requisitos Complementares

Validação e Tratamento de Erros:

* Validação robusta dos dados de entrada com feedback adequado (ex.: mensagens de erro, status HTTP 400, 404, 500).

## Documentação da API:

* Configuração do Swagger (OpenAPI) para documentação e testes.

## Testes Automatizados:

* Implementação de testes unitários para serviços e controllers.

* Testes de integração para validar a comunicação entre as camadas.

# Requisitos Técnicos

### Back-End

* Plataforma: ASP.NET Core com .NET 9.0.3.

* Banco de Dados: Uso do Entity Framework Core com SQL Server, SQLite ou outro SGBD.

* Autenticação e Autorização (Bônus):

        Implementar JWT para proteger endpoints críticos, garantindo que apenas usuários autenticados possam realizar operações de escrita.

* Logging e Monitoramento:

        Implementar logging estruturado e monitoramento para rastrear erros e eventos.

* Princípios SOLID e Clean Code:

        Organizar o código utilizando injeção de dependências, separação de responsabilidades e padrões de projeto.

* Versionamento da API:

        Estruturar endpoints para facilitar a evolução da API sem impactos imediatos na base de consumidores.

### Front-End

* Framework: Angular (versão 19.2.5).

* Componentização:

        Desenvolvimento de componentes modulares para a exibição, criação e edição de tarefas.

* Serviços de Integração:

        Criação de serviços utilizando HttpClient para integração com a API.

* Feedback e Validação:

        Formulários reativos com validação de campos, tratamento de erros e mensagens de feedback para o usuário.

* UI/UX:

        Design responsivo, usabilidade e boas práticas de interação.

## Arquitetura da Aplicação

* Aplicação Monolítica:

        Estrutura tradicional com divisão clara entre camadas de apresentação, negócio e acesso a dados.

* Camadas Sugeridas:

* Presentation: Controladores e interface Angular.

* Business: Serviços e lógica de negócio.

* Data Access: Repositórios e contexto do Entity Framework.

* Cross-Cutting: Módulos para logging, tratamento de exceções, segurança e configurações.

## Boas Práticas e Considerações Extras

* Documentação e Controle de Versão:

        Uso de Git para versionamento do código, com um README detalhado e documentação de commits.

* CI/CD:

        Configuração de pipelines de integração contínua para execução de testes automatizados e deploy.

* Testes:

        Cobertura de testes unitários e de integração para garantir a qualidade do código.

* Desempenho e Escalabilidade:

        Implementar técnicas de caching, otimização de consultas e análise de performance.

* Segurança:

        Boas práticas de segurança na API (validação de entrada, proteção contra injeção de SQL, etc.).

* Deploy e Configuração de Ambientes:

        Instruções para deploy em ambientes de desenvolvimento, homologação e produção.

* Manutenibilidade:

        Código organizado e modular, com atenção à legibilidade e facilidade de manutenção futura.

## Critérios de Avaliação

* Qualidade do Código:

        Organização, clareza e aplicação dos princípios SOLID e Clean Code.

* Funcionalidade:

        Correta implementação dos endpoints, integração entre front-end e back-end e funcionamento dos testes.

* Validação e Tratamento de Erros:

        Robustez na validação de dados e gerenciamento de exceções.

* Documentação:

        Uso adequado do Swagger, README completo e documentação do projeto.

* Boas Práticas de Desenvolvimento:

        Configuração de pipelines CI/CD, logging, monitoramento e segurança.

## Entrega

* Repositório Git:

    * Projeto versionado com commits claros e organização por branches (ex.: feature, develop, main).

* Instruções de Setup:

    * Passo a passo para instalação, execução local e deploy.

* Demonstração:

    * Vídeo curto ou instruções de uso demonstrando as funcionalidades da aplicação.
