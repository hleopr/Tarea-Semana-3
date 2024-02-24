using System;

class CalculoDeArea
{
    static void Main()
    {
        try
        {
            Console.Write("Por favor, ingresa el tipo de figura geométrica (triángulo, cuadrado, círculo): ");
            string figura = Console.ReadLine().ToLower();

            switch (figura)
            {
                case "triángulo":
                    Console.Write("Ingresa la base del triángulo: ");
                    decimal baseTriangulo = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Ingresa la altura del triángulo: ");
                    decimal alturaTriangulo = Convert.ToDecimal(Console.ReadLine());
                    decimal areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
                    Console.WriteLine($"El área del triángulo es: {areaTriangulo}");
                    break;
                case "cuadrado":
                    Console.Write("Ingresa el lado del cuadrado: ");
                    decimal ladoCuadrado = Convert.ToDecimal(Console.ReadLine());
                    decimal areaCuadrado = ladoCuadrado * ladoCuadrado;
                    Console.WriteLine($"El área del cuadrado es: {areaCuadrado}");
                    break;
                case "círculo":
                    Console.Write("Ingresa el radio del círculo: ");
                    decimal radioCirculo = Convert.ToDecimal(Console.ReadLine());
                    decimal areaCirculo = (decimal)Math.PI * radioCirculo * radioCirculo;
                    Console.WriteLine($"El área del círculo es: {areaCirculo}");
                    break;
                default:
                    Console.WriteLine("Tipo de figura no reconocido.");
                    break;
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
