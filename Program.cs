 // Solicita a idade do visitante
        Console.WriteLine("Informe a idade do visitante:");

        // Lê a idade digitada
        int idade = int.Parse(Console.ReadLine());

        // Verifica a idade
        if (idade >= 16)
        {
            Console.WriteLine("Entrada liberada.");
        }
        else
        {
            Console.WriteLine("Entrada permitida somente com responsável.");
        }
    
    
