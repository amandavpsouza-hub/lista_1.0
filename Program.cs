  // Solicita a nota final do estudante
        Console.WriteLine("Informe a nota final:");

        // Lê a nota digitada
        int nota = int.Parse(Console.ReadLine());

        // Verificação a situação do estudante
        if (nota >= 7)
        {
            Console.WriteLine("Estudante aprovado.");
        }
        else if (nota >= 5)
        {
            Console.WriteLine("Estudante em recuperação.");
        }
        else
        {
            Console.WriteLine("Estudante reprovado.");
        }
