# Desafio de RPA-Alura

Esse projeto foi desenvolvido para um teste técnico e a finalidade do código é automatizar uma pesquisa de um curso de "RPA" para capturar as informações do mesmo.

De Acordo com as informações solicitadas nesse teste, segue um breve conteúdo:

1. Sua aplicação preenche os requisitos básicos;

>
    Sim,a aplicação executa todos os passos solicitados neste desafio.

2. Manutenabilidade, clareza e limpeza de código, resultado funcional, entre outros fatores;

>   
    Sim,Código claro de fácil manutenção.

3. Explique as decisões técnicas tomadas, as escolhas por bibliotecas e ferrramentas;
   
*  [.NET 7](https://dotnet.microsoft.com/download) - O .NET 7 é a mais recente iteração da plataforma .NET e nos fornece suporte a várias plataformas com desempenho nativo.

* [Visual Studio Community](visualstudio.microsoft.com/vs/community/) - O Visual Studio é a IDE líder da Microsoft, conhecida por sua robustez e conjunto de recursos avançados.

* [SQLite](https://sqlitestudio.pl/)- o SQLite é um banco de dados fácil de transportar e manusear os dados nessa aplicação, por ser temporária.
     
4. Fluxo da aplicação; 

>
        * Inicia a aplicação com abertura  do site da Alura;
        * Executa uma pesquisa dentro do site com as siglas "RPA";
        * Seleciona o Primeiro curso exibido na página;
        * Captura as informações de "Título, Nome Professor, Carga Horária, Descrição";
        * Executa a gravação no banco de dados SQLite;

5. Se você tratou bem com erros e casos inesperados;

>
    Sim, Tratei apenas situações do cotidiano.

6. Se usou Webdriver;

>   
    Sim, Utilizei o Webdriver pois é uma parte fundamental para o selenium, o webdriver é um componente que permite automação de testes de aplicações web.

7. Se fez uso do GitFlow;

>
    Não utilizei pois a aplicação não requer muitos commits pelo nivel de complexidade.
