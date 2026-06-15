
        int nota;

        Console.WriteLine("Informe uma nota de 0 a 10:");
        nota = Convert.ToInt32(Console.ReadLine());

        while (nota < 0 || nota > 10)
        {
            Console.WriteLine("Nota inválida. Informe novamente.");
            nota = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Nota registrada: " + nota);
    