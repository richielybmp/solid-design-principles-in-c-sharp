# Open/Closed Principle

Esse é o princípio aberto/fechado. Ele nos diz basicamente que:

> Cada módulo/classe do software deve ser aberta para extensões e fechada para modificações.

Imagine um sistema que precisa gerar relatórios em formatos de saída diferentes (Word, PDF, etc). Cada um desses formatos precisa de uma lógica diferente para gerar um relatório.

Mas e se o nosso cliente pedir para adicionar um novo formato de relatório? O que vamos fazer com a nossa implementação que já está testada e funcionando? 

Devemos alterar a sua lógica para suportar a emissão do novo formato de relatório? O princípio Open/Closed afirma que **não**

## Explicando o exemplo

No código de exemplo, utilizamos este cenário onde precisamos comtemplar a emissão de relatórios em diversos formatos.
  
No exemplo [ruim](https://github.com/richielybmp/solid-design-principles-in-c-sharp/tree/master/OCP.OpenClosedPrinciple/Bad), temos toda a lógica de emissão dos relatórios concentrada em `ReportGenerationHelper.cs` apenas. Isso é terrível pois, ao chegar um novo tipo de formato, temos de alterar a classe para verificar o tipo do novo relatório e implementar sua lógica de geração ali mesmo, invalidando os testes já garantidos anteriormente na classe.

Já no exemplo [bom](https://github.com/richielybmp/solid-design-principles-in-c-sharp/tree/master/OCP.OpenClosedPrinciple/Good), trabalhamos com uma classe abstrata `ReportGenerationHelper.cs` que expõe um método para conter a implementação da geração do relatório. Dessa forma, podemos criar classes para cada tipo de relatório - assim como vimos no princípio de responsabilidade única - que herdam a nossa classe abstrata e cada uma terá sua própria lógica de como se deve gerar o relatório.
