O teste a seguir tem como fundamento validar conhecimentos t�cnicos obrigat�rios e desej�veis.

O teste � constitu�do por uma solu��o/projeto em .NET usando framework 4.5 e MVC usando um template padr�o do Visual Studio.

No projeto j� est�o implementados as seguintes classes:

 - Models/Category.cs: Classe de categoria de produtos;
 - Models/Product.cs: Classe de produto;
 - DAL/MockProductDao.cs: Classe de acesso a dados (dados mockados) para obter informa��es de produtos;
 
Objetivo do teste:

Utilizando as classes acima, exibir em uma view os dados da listagem de produtos obtida atrav�s do m�todo GetAllProducts() da classe MockProductDao.

Funcionalidades/implementa��es obrigat�rias:

- Utilizar arquitetura MVC;
- Exibi��o da listagem em forma de tabela e de todos os dados poss�veis do produto;
- Exibi��o da listagem com pagina��o de 10 em 10 itens;
- Implementar pagina��o considerando a melhor performance poss�vel;

Funcionalidades/implementa��es extras, que ser�o consideradas diferenciais:

- Sele��o da quantidade de registros por p�gina (5,10,15);
- Sele��o da ordena��o por qualquer um dos campos;
- Sele��o de colunas vis�veis/ocultas;
 
 
 

