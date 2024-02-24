using System;

class PrecioFinalProducto
{
    static void Main()
    {
        try
        {
            Console.Write("Por favor, ingresa el precio original del producto: Q");
            decimal precioOriginal = Convert.ToDecimal(Console.ReadLine());

            decimal precioFinal = precioOriginal;
            if (precioOriginal > 100)
            {
                decimal descuento = precioOriginal * 0.10m; // Calcula el 10% de descuento
                precioFinal -= descuento; // Aplica el descuento al precio original
            }

            Console.WriteLine($"El precio final después del descuento es: Q{precioFinal}");
        }
        catch (FormatException)
        {
            Console.WriteLine("El valor ingresado no es un número válido.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocurrió un error inesperado: {ex.Message}");
        }
    }
}
