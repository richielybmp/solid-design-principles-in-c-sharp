# Dependency Inversion Principle

Esse é o princípio da inversão de dependência e ele nos diz que:

> Módulos de alto nível não devem depender dos módulos de baixo nível. Os dois devem ser baseados em abstrações.

Em outras palavras, se uma classe necessitar de alguma ferramenta, ela irá expressar essa necessidade. Isso não deixa com que a necessidade simplesmente saia se oferecendo para ser usada pela classe.

Imagine que as pessoas todas com telefone celular viram pra você e dizem que irão te ligar à qualquer hora para conversar. Ok, para se manter um relacionamento, duas pessoas devem se comunicar. Mas suponha que você não goste muito de falar ao telefone e só utiliza esse recurso quando realmente é preciso. Então nesse caso você é o responsável por fazer a ligação para tal pessoa, com um propósito específico.

## Explicando o exemplo

No código de exemplo, queremos utilizar de um mecanismo de envio de mensagens via E-mail, Sms ou Whatsapp.
  
No exemplo [ruim](https://github.com/richielybmp/solid-design-principles-in-c-sharp/tree/master/DIP.DependencyInversionPrinciple/Bad), os meios de notificação possuem implementações dentro do serviço de notificação que depende totalmente de saber quais são os meios de envio para tratar cada um de forma independente. Isso é horrível para manutenibilidade e evolução do código pois o módulo de notiifação e as formas de envio estão fortemente amarradas.

Já no exemplo [bom](https://github.com/richielybmp/solid-design-principles-in-c-sharp/tree/master/DIP.DependencyInversionPrinciple/Good), resolvemos esse problema quando criamos um tipo `IMessageType.cs` que serve de base para todas as formas de envio da notificação, garantinfo que nossa aplicação se divida em interfaces que caracterizarão os meios existentes e também os novos, abrindo o código para extensões.
Seguindo, o mecanismo de notificação decide qual será sua estratégia de o envio. O serviço de notificação por sua vez, é criado já sabendo qual o meio de envio que deverá ser utilizado e consegue enviar a notificação sem precisar ter diferentes implementações para o envio.

Assim, o serviço de notificação só precisa saber qual é estratégia a ser utilizada para prosseguir com o envio da mensagem. Ela não depende de como o Email ou o Sms funciona, permitindo com que qualquer outra forma de envio de mensagem possa ser adicionada ao projeto e contunuar utilizando o mesmo serviço.
