Console.WriteLine("Informe o primeiro valor:");
        int valor1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe o segundo valor:");
        int valor2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe o terceiro valor:");
        int valor3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe o quarto valor:");
        int valor4 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe o quinto valor:");
        int valor5 = Convert.ToInt32(Console.ReadLine());

        int soma = valor1 + valor2 + valor3 + valor4 + valor5;

        double media = soma / 5.0;

        Console.WriteLine("Soma dos valores: " + soma);
        Console.WriteLine("Média dos valores: " + media);
    