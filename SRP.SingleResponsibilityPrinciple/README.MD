# Single Responsibility Principle

Esse é o princípio da responsabilidade única. Ele nos diz basicamente que:

> Cada módulo/classe do software deve possuir apenas uma razão para mudar

Imagine uma ferramenta Suíça. Ela possui multiplas funções. Legal, mas as vezes você não acha que essa ferramenta é sobrecarregada com funções demais?

Então, e se eu tivesse todas essas funcionalidades em itens separados? 

Dessa forma tudo parecerá mais simples e não precisarei de me preocupar caso algum outro item for afetado por algo.

## Explicando o exemplo

No código de exemplo, precisamos inserir um usuário no banco de dados. Nosso usuário possui `nome` e `email`. Sendo assim, queremos:
  * Validar o seu `email`;
  * Inserir o registro no banco;
  * Enviar um e-mail de boas-vindas;
  
No exemplo [ruim](https://github.com/richielybmp/solid-design-principles-in-c-sharp/tree/master/SRP.SingleResponsibilityPrinciple/Bad), realizamos todos esses passos na classe `UserService.cs`.

Já no exemplo [bom](https://github.com/richielybmp/solid-design-principles-in-c-sharp/tree/master/SRP.SingleResponsibilityPrinciple/Good), separamos nossas classes fazendo com que cada parte seja responsável por realizar alguma tarefa específica.
