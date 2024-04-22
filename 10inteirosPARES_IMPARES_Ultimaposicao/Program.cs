        int[] numeros = new int[10];
        int posicaoPar = 0; 
        int posicaoImpar = 0; 

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Digite o {i + 1}º número inteiro: "); //pede para digitar o numero 1 dos 10 e vai acrescentando mais um ate o décimo)
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        // valores pares
        Console.WriteLine("\nValores pares:");
        for (int i = 0; i < 10; i++)
        {
            if (numeros[i] % 2 == 0) //faz a conta para mostrar os numeros pares, se numero dividido por dois é 0)
            {
                Console.WriteLine(numeros[i]);
                posicaoPar++; //mostra a posição impar e acresnta mais um se tiver
    }
        }

        // valores ímpares
        Console.WriteLine("\nValores ímpares:"); 
        for (int i = 0; i < 10; i++)
        {
            if (numeros[i] % 2 != 0) //faz a conta para mostrar os numeros impares, se numero dividido é diferente de 0)
    {
                Console.WriteLine(numeros[i]); //mostra o numero na tela
                posicaoImpar++; // mostra a posição impar e acresnta mais um se tiver
            }
        }

// primeira e a última posição
Console.Write("primeira e última posição:");
Console.WriteLine($"{numeros[0]} { numeros[9]}"); //mostra o valor que foi preenchido dentro da variavel 0 que seria o primeiro numero dito e ultimo dito, numero 9 ( que equivale a 10 para usuario) //"$" para mostrar jutnos a frase a variavel