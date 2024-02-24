using System;

class ConvertirNumeroLetraADigito
{
    static void Main()
    {
        Console.Write("Por favor, ingresa un número del 1 al 5 en letra (uno, dos, tres, cuatro, cinco): ");
        string numeroEnLetra = Console.ReadLine().ToLower();

        switch (numeroEnLetra)
        {
            case "uno":
                Console.WriteLine("El número en dígito es: 1");
                break;
            case "dos":
                Console.WriteLine("El número en dígito es: 2");
                break;
            case "tres":
                Console.WriteLine("El número en dígito es: 3");
                break;
            case "cuatro":
                Console.WriteLine("El número en dígito es: 4");
                break;
            case "cinco":
                Console.WriteLine("El número en dígito es: 5");
                break;
            default:
                Console.WriteLine("Número fuera de rango o no reconocido.");
                break;
        }
    }
}
