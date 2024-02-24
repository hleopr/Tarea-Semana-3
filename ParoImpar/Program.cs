using System;

class ParOImpar
{
    static void Main()
    {
        try
        {
            Console.Write("Por favor, ingresa un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine($"El número {numero} es par.");
            }
            else
            {
                Console.WriteLine($"El número {numero} es impar.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("El valor ingresado no es un número entero válido.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocurrió un error inesperado: {ex.Message}");
        }
    }
}
