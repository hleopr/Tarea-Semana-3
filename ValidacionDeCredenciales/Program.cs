using System;

class ValidacionDeCredenciales
{
    static void Main()
    {
        try
        {
            Console.Write("Por favor, ingresa tu nombre de usuario: ");
            string usuario = Console.ReadLine();
            Console.Write("Por favor, ingresa tu contraseña: ");
            string contraseña = Console.ReadLine();

            if (usuario == "LeonelPineda" && contraseña == "progra123")
            {
                Console.WriteLine("Acceso permitido.");
            }
            else
            {
                Console.WriteLine("Acceso denegado. El usuario o la contraseña son incorrectos.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocurrió un error inesperado: {ex.Message}");
        }
    }
}
