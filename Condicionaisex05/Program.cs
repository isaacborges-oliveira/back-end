
        Console.Write("Digite o número de maçãs compradas: ");
        int quantidade = int.Parse(Console.ReadLine()!);

        float preco;

        if (quantidade < 12)
            preco = 0.30f;
        else
            preco = 0.25f;

        float total = quantidade * preco;

        Console.WriteLine($"O valor total da compra é: R$ {total:F2}");
    
