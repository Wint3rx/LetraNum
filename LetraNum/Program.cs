using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un número del 1 al 5 en letra (uno, dos, tres, cuatro, cinco): ");
        string numeroEnLetra = Console.ReadLine().ToLower(); // Convertir a minúsculas para manejar entradas mixtas

        int numeroEnDigito = ConvertirLetraANumero(numeroEnLetra);

        if (numeroEnDigito != -1)
        {
            Console.WriteLine($"El número en dígito es: {numeroEnDigito}");
        }
        else
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número del 1 al 5 en letra.");
        }
    }

    static int ConvertirLetraANumero(string letra)
    {
        switch (letra)
        {
            case "uno":
                return 1;
            case "dos":
                return 2;
            case "tres":
                return 3;
            case "cuatro":
                return 4;
            case "cinco":
                return 5;
            default:
                return -1; // Indica que la entrada no es válida
        }
    }
}

