﻿
        Console.Write("Digite a frequência do aluno (em %): ");
        float frequencia = float.Parse(Console.ReadLine()!);

      
        Console.Write("Digite a média do aluno: ");
        float media = float.Parse(Console.ReadLine()!);

        if (frequencia < 75)
        {
            Console.WriteLine("Aluno reprovado por frequência.");
        }
        else
        {
      
            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media >= 3.0 && media < 7.0)
            {
                Console.WriteLine("Aluno em recuperação.");
            }
            else
            {
                Console.WriteLine("Aluno reprovado por média.");
            }
        
    }

