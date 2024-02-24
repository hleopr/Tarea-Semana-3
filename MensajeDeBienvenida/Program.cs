using System;

class MensajeDeBienvenida
{
    static void Main()
    {
        Console.Write("Por favor, ingresa el idioma de tu preferencia (espanol, ingles, frances): ");
        string idioma = Console.ReadLine().ToLower();

        switch (idioma)
        {
            case "espanol":
                Console.WriteLine("¡Bienvenido al programa!");
                break;
            case "ingles":
                Console.WriteLine("Welcome to the program!");
                break;
            case "frances":
                Console.WriteLine("Bienvenue au programme!");
                break;
            default:
                Console.WriteLine("Idioma no reconocido. Por favor, ingresa un idioma válido.");
                break;
        }
    }
}
