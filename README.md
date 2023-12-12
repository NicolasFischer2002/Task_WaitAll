# Task_WaitAll
Como trabalhar com paralelismo em C# utilizando Task.WaitAll() para aguardar a conclusão de tarefas assíncronas (await async). Task.WaitAll() comporta 3 parâmetros bem interessantes: um array de tasks, um TimeOut e um CancellationToken. No entanto a abordagem com Task.WaitAll() bloqueia a Thread Principal do programa, responsável por exemplo por permitir a interação do usuário com a parte gráfica da aplicação; assim que todas as Tasks que são aguardadas pelo método Task.WaitAll() são finalizadas, a Thread Principal é desbloqueada. Task.WaitAll() é um método assíncrono, que caso de exceções pode retornar um AggregateException.

Documentação: 
=> https://learn.microsoft.com/pt-br/dotnet/api/system.threading.tasks.task.waitall?view=net-8.0
