# 🎯 O que é esse repositório?
Repositório de código aberto, que serve para estudo do DDD em uma aplicação .NET, utilizando Repository Pattern, Entity Framework e Migrations.

# 🎯 Layers

### 1. Application
Camada destinada para armazenamento das aplicações. Nela, suportamos nossa aplicação do tipo Web API, porém, poderia ser uma aplicação MVC. Não há limite de aplicações nessa camada.

### 2. Domain

Camada destinada para armazenamento das entidades de domínio. Observe que nela armazeno a entidade "Todo", que é a nossa entidade principal no contexto dessa stack.

### 3. Service
Nossa camada de serviço, responsável por realizar as validações necessárias nos objetos. Atente que, por boa prática, essa camada de serviço deverá ser injetada na camada de aplicação e não instanciada.

### 4. Infra

Camada responsável por armazenar os itens que dão apoio as camadas acima.

#### 4.1 Data

A camada de Data assume a responsabilidade de "linkar" o nosso banco de dados. Observe que nele armazeno o Contexto (do Entity Framework, no projeto Persistence) e o Repository, onde aplico o Repository Pattern.
Por boa prática, tanto o Repository, quanto o Context, não devem ser instanciados e sim injetados.

#### 4.2. Cross Cutting

A camada de Cross Cutting, por enquanto sem projetos, é responsável por armazenar itens que "cruzam" a nossa stack. Como por exemplo: Envios de E-mail, Logging, Upload/Download de Arquivos. 
Itens que na sua maioria das vezes, serão consumidos por toda a sua stack.

# 🎯 Como executar?
1. Fork
2. Vá até 1. Application > WebAPI > Startup.cs > Informe sua connection string na linha 34.
3. Rode um Update-Database no Console do Nugget.
4. F5 para debugar.
