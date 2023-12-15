using Task_WaitAll;

try
{
    string[] cidades = ["1 - Nova York, Estados Unidos",
        "2 - Tóquio, Japão",
        "3 - Bay Area, Califórnia, Estados Unidos",
        "4 - Londres, Reino Unido",
        "5 - Singapura, Singapura"];

    string[] Paises = ["1 - Estados Unidos", "2 - China", "3 - Japão", "4 - Alemanha", "5 - Índia"];

    // <===== Em versões anteriores do .NET pode ser necessário declarar as tasks desta forma dentro do array =====> //
    // Task.Run(() => Exemplos.EscreveCidades_async(cidades));
    // Task.Run(() => Exemplos.EscrevePaises_async(Paises));

    Task[] tasks =
    [
        Exemplos.EscreveCidades_async(cidades),
        Exemplos.EscrevePaises_async(Paises)
    ];

    // Array de tasks + TimeOut que encerra as Tasks; é possível adicionar um CancellationToken para encerrar a Task
    if (Task.WaitAll(tasks, 6000))
        Console.WriteLine("\n\nTasks completadas com sucesso!");
    else
        Console.WriteLine("\n\nNão foi possível completar as Tasks!");
}
catch (AggregateException ae)
{
    Console.WriteLine("\n\nNão foi possível completar as Tasks!");
    foreach (var ex in ae.InnerExceptions)
        Console.WriteLine($"\n\nErro inesperado: {ex.Message}");
}