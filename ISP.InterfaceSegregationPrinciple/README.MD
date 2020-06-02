# Interface Segregation Principle

Esse é o princípio da segregação de interfaces. . Aqui, temos que:

> Quem utiliza a interface não deve ser obrigado ou forçado a implementar o que não se irá utilizar. Ao invés de se ter uma interface inflada, é preferível que se tanha várias interfaces menores baseando-se em grupos de métodos, cada um correspondendo a um submódulo do domínio.

Podemos perceber que esse princípio também compartilha a caracteristica de SRP (Responsabilidade única). Não devemos criar interfaces com vários métodos e propriedades, se não é de necessidade de todos que irão implementá-la.

Uma analogia a ser feita é que atualmente possuímos diversos tipos de conectores de carregadores de celulares que na outra ponta possuem um USB. Agora imagine se existisse apenas um objeto que contenha todos os tipos de entradas para carregadores plugados em si, com 10, 20 conectores diferentes. Não é isso que queremos. Não queremos carregar esse tanto de coisa desnecessária sendo que precisamos apenas de uma.

## Explicando o exemplo

No código de exemplo, temos a separação do controle de criação, revisão e execução de tarefas em um departamento.
  
No exemplo [ruim](https://github.com/richielybmp/solid-design-principles-in-c-sharp/tree/master/ISP.InterfaceSegregationPrinciple/Bad), o nosso `Manager` está associado à atividade de criar, rever e executar tarefas assim como um líder qualquer.

O que acontece é que geralmente os gerentes não são responsáveis por executar tarefas comuns à dos líderes. O domínio em que eles atuam é diferente.

Dessa forma, o gerente tem de refugar a função de executar tarefas.

Já no exemplo [bom](https://github.com/richielybmp/solid-design-principles-in-c-sharp/tree/master/ISP.InterfaceSegregationPrinciple/Good), conseguimos separar os métodos que estavam todos agrupados na interface `ILead.cs` em outra interface chamada `IProgrammer.cs`.
Nessa nova interface, definimos que ela irá desempenhar a execução de tarefas. Sendo assim, o nosso `Manager` pode liderar sem se preocupar em executar tarefas comuns de outro domínio. Enquanto do outro lado, um líder pode sim executar tais tarefas e também liderar seus programadores.
