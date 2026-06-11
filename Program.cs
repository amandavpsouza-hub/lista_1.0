Console.WriteLine("Informe o valor total da compra:");

        int valorCompra = int.Parse(Console.ReadLine());

        int desconto;
        int valorFinal;

        if (valorCompra >= 200)
        {
            desconto = (int)(valorCompra * 0.10);
        }
        else
        {
            desconto = 0;
        }

        valorFinal = valorCompra - desconto;

        Console.WriteLine("Valor original: R$ " + valorCompra);
        Console.WriteLine("Desconto aplicado: R$ " + desconto);
        Console.WriteLine("Valor final: R$ " + valorFinal);