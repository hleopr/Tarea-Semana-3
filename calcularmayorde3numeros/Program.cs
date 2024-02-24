using System;

class MayorDeTresNumeros
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Ingrese el primer número:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer número:");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int mayor = num1;

            if (num2 > mayor)
            {
                mayor = num2;
            }

            if (num3 > mayor)
            {
                mayor = num3;
            }

            Console.WriteLine($"El número mayor es: {mayor}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Por favor, ingrese solo valores numéricos.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("El número ingresado es demasiado grande o demasiado pequeño.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocurrió un error inesperado: {ex.Message}");
        }
    }
}
