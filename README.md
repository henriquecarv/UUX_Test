O teste a seguir tem como fundamento validar conhecimentos técnicos obrigatórios e desejáveis.

O teste é constituído por uma solução/projeto em .NET usando framework 4.5 e MVC usando um template padrão do Visual Studio.

No projeto já estão implementados as seguintes classes:

 - Models/Category.cs: Classe de categoria de produtos;
 - Models/Product.cs: Classe de produto;
 - DAL/MockProductDao.cs: Classe de acesso a dados (dados mockados) para obter informações de produtos;
 
Objetivo do teste:

Utilizando as classes acima, exibir em uma view os dados da listagem de produtos obtida através do método GetAllProducts() da classe MockProductDao.

Funcionalidades/implementações obrigatórias:

- Utilizar arquitetura MVC;
- Exibição da listagem em forma de tabela e de todos os dados possíveis do produto;
- Exibição da listagem com paginação de 10 em 10 itens;
- Implementar paginação considerando a melhor performance possível;

Funcionalidades/implementações extras, que serão consideradas diferenciais:

- Seleção da quantidade de registros por página (5,10,15);
- Seleção da ordenação por qualquer um dos campos;
- Seleção de colunas visíveis/ocultas;
 
 
 

