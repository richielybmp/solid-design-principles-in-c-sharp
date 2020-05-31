# Liskov Substitution Principle

Esse é o princípio da substituição de Liskov. Pode ser considrado um dos princípios mais confusos de se entender ou de se exemplificar. Ele nos diz basicamente que:

> Devemos ser capaz de usar qualquer classe derivada no lugar da classe pai e fazer com que ela se comporte da mesma forma sem modificações

Em outras palavras, esse princípio é uma extensão do princípio Aberto/Fechado. Aqui, uma classe derivada não afeta o comportamento da classe base. Dessa forma, podemos utilizar a classe base para representar qualquer classe derivada.

Imagine que um pai é um motorista de ônibus e seu filho quer ser jogador de futebol. Dessa forma, o filho não consegue substituir o pai, mesmo que eles sejam da mesma família.

## Explicando o exemplo

No código de exemplo, utilizamos um plano de assinaturas que possui diferentes níveis de acessos: artigos, cursos e mentoria.
  
No exemplo [ruim](https://github.com/richielybmp/solid-design-principles-in-c-sharp/tree/master/LSP.LiskovSubstitutionPrinciple/Bad), o gerenciador de assinaturas permite obter os detalhes de todos os níveis de acessos. 

A implementação de cada nível, sobreescreve a forma de obtenção dos níveis e, se não oferecer algum tipo de nível, simplesmente não o implementa, deixando um método não implementado.

Ao coletarmos as informações de todas as assinaturas, ao tentar obter um detalhe de algum recurso que uma assinatura derivada mais básica não possui em relação à uma assinatura mais complexa, então uma exceção será disparada em tempo de execução, pois tentará acessar aquele método que não foi implementado.

Já no exemplo [bom](https://github.com/richielybmp/solid-design-principles-in-c-sharp/tree/master/LSP.LiskovSubstitutionPrinciple/Good), conseguimos extender nossa classe base e separar as características (nível de acesso) que cada assinatura deve oferecer.

Dessa forma, caso tente realizar a mesma operação no exemplo ruim, de listar os detalhes de todos tipos de assinatura, ao criarmos a coleção que contêm as assinaturas, de acordo com a classe base, pode ser que tenhámos uma assinatura derivada da base que não implementa a obternção dos detalhes mais complexos que outra classe possui.

Sendo assim, o editor já exibe uma mensagem de erro falando que o tipo não pertence ao tipo definido na coleção e não conseguirá executar algum método mais complexo que a classe base desconhece. Isso impede que a exeção anteriormente disparada, aconteça e surpreenda o usuário com um erro em tempo de execução.
