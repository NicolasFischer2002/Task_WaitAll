# Task_WaitAll
Como trabalhar com paralelismo em C# utilizando Task.WaitAll() - método async - para aguardar a conclusão de tarefas assíncronas (await async). Task.WaitAll() comporta 3 parâmetros bem interessantes: um array de tasks, um TimeOut e um CancellationToken. No entanto a abordagem com Task.WaitAll() bloqueia a Thread Principal do programa, responsável dentre outras coisas por permitir a interação do usuário com a parte gráfica da aplicação; assim que todas as Tasks que são aguardadas pelo método Task.WaitAll() são finalizadas, a Thread Principal é desbloqueada. Task.WaitAll() é um método assíncrono, que em caso de exceções nas tasks da coleção de tasks pode retornar um AggregateException, que engloba todas as exceções do array de tasks.

=> Documentação: 
Task.WaitAll Method: https://learn.microsoft.com/pt-br/dotnet/api/system.threading.tasks.task.waitall?view=net-8.0
