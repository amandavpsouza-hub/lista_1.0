 Console.WriteLine("Informe o número da tabuada:");

        int numero = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(numero + " * " + i + " = " + (numero * i));
        }