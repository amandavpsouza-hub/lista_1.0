   int saldo;
        int operacao;
        int valor;

        Console.WriteLine("Informe o saldo inicial:");
        saldo = Convert.ToInt32(Console.ReadLine());

        operacao = 0;

        while (operacao != 3)
        {
            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("1 - Entrada de dinheiro");
            Console.WriteLine("2 - Saída de dinheiro");
            Console.WriteLine("3 - Encerrar");

            operacao = Convert.ToInt32(Console.ReadLine());

            if (operacao == 1)
            {
                Console.WriteLine("Informe o valor da movimentação:");
                valor = Convert.ToInt32(Console.ReadLine());

                saldo = saldo + valor;

                Console.WriteLine("Entrada registrada. Saldo atual: R$ " + saldo);
            }
            else if (operacao == 2)
            {
                Console.WriteLine("Informe o valor da movimentação:");
                valor = Convert.ToInt32(Console.ReadLine());

                if (valor <= saldo)
                {
                    saldo = saldo - valor;
                    Console.WriteLine("Saída registrada. Saldo atual: R$ " + saldo);
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente.");
                }
            }
            else if (operacao == 3)
            {
                Console.WriteLine("Saldo final: R$ " + saldo);
            }
            else
            {
                Console.WriteLine("Operação inválida.");
            }
        }