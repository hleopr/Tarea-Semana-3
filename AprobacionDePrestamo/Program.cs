using System;

class AprobacionDePrestamo
{
    static void Main()
    {
        try
        {
            Console.Write("Por favor, ingresa el monto del préstamo: $");
            decimal montoPrestamo = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Por favor, ingresa tu edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            if (montoPrestamo < 5000 || edad > 60)
            {
                Console.WriteLine("Préstamo aprobado.");
            }
            else
            {
                Console.WriteLine("Préstamo rechazado.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Uno o más valores ingresados no son válidos.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocurrió un error inesperado: {ex.Message}");
        }
    }
}
