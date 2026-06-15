
        int senha;

        Console.WriteLine("Informe a senha:");
        senha = Convert.ToInt32(Console.ReadLine());

        while (senha != 1234)
        {
            Console.WriteLine("Senha incorreta. Tente novamente.");

            Console.WriteLine("Informe a senha:");
            senha = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Acesso permitido.");
