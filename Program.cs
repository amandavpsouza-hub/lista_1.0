   Console.WriteLine("Informe a idade do passageiro:");
        int idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe o valor normal da passagem:");
        double valorPassagem = Convert.ToDouble(Console.ReadLine());

        double valorPagar;

        if (idade <= 5)
        {
            valorPagar = 0;
        }
        else if (idade >= 60)
        {
            valorPagar = valorPassagem / 2;
        }
        else
        {
            valorPagar = valorPassagem;
        }

        Console.WriteLine("Valor normal da passagem: R$ " + valorPassagem);
        Console.WriteLine("Valor a pagar: R$ " + valorPagar);
    