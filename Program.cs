    { int quantidadeClientes;
        int tempoAtendimento;
        int tempoTotal = 0;
        int tempoMedio;

        Console.WriteLine("Informe a quantidade de clientes atendidos:");
        quantidadeClientes = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= quantidadeClientes; i++)
        {
            Console.WriteLine("Informe o tempo do atendimento:");
            tempoAtendimento = Convert.ToInt32(Console.ReadLine());

            tempoTotal = tempoTotal + tempoAtendimento;
        }

        tempoMedio = tempoTotal / quantidadeClientes;

        Console.WriteLine("Tempo total de atendimento: " + tempoTotal + " minutos");
        Console.WriteLine("Tempo médio por cliente: " + tempoMedio + " minutos");
    }