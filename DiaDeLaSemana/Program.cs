using System;

class DiaDeLaSemana
{
    static void Main()
    {
        Console.Write("Por favor, ingresa un número del 1 al 7 para obtener el día de la semana correspondiente: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        switch (numero)
        {
            case 1:
                Console.WriteLine("El día de la semana es: Lunes");
                break;
            case 2:
                Console.WriteLine("El día de la semana es: Martes");
                break;
            case 3:
                Console.WriteLine("El día de la semana es: Miércoles");
                break;
            case 4:
                Console.WriteLine("El día de la semana es: Jueves");
                break;
            case 5:
                Console.WriteLine("El día de la semana es: Viernes");
                break;
            case 6:
                Console.WriteLine("El día de la semana es: Sábado");
                break;
            case 7:
                Console.WriteLine("El día de la semana es: Domingo");
                break;
            default:
                Console.WriteLine("Número fuera de rango. Por favor, ingresa un número del 1 al 7.");
                break;
        }
    }
}
