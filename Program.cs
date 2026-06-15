Console.WriteLine("Informe o número inicial da contagem regressiva:");

        int numero = Convert.ToInt32(Console.ReadLine());

        for (int i = numero; i >= 0; i--)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Fim da contagem.");