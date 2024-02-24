using System;

class EvaluacionDeCalificacion
{
    static void Main()
    {
        Console.Write("Por favor, ingresa la calificación del examen: ");
        int calificacion = Convert.ToInt32(Console.ReadLine());

        switch (calificacion)
        {
            case int n when (n >= 90 && n <= 100):
                Console.WriteLine("Sobresaliente");
                break;
            case int n when (n >= 80 && n <= 89):
                Console.WriteLine("Notable");
                break;
            case int n when (n >= 71 && n <= 79):
                Console.WriteLine("Aprobado");
                break;
            case 70:
                Console.WriteLine("Deficiente");
                break;
            case int n when (n >= 60 && n <= 69):
                Console.WriteLine("Reprobado");
                break;
            default:
                if (calificacion < 60)
                {
                    Console.WriteLine("Mediocre");
                }
                else
                {
                    Console.WriteLine("Calificación no válida. Por favor, ingresa un número entre 0 y 100.");
                }
                break;
        }
    }
}
