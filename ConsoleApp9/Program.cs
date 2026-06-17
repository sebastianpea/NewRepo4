using System;
using System.Threading; // Clase predefinida para usar Sleep
using SistemaTienda;    // Llamamos al paquete de la aplicación

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- PRUEBA DE REUTILIZACIÓN Y PAQUETES --- \n");

        // Usamos una clase predefinida (DateTime) para guardar la fecha de la simulación
        DateTime fechaHoy = DateTime.Now;
        Console.WriteLine($"Fecha de operación: {fechaHoy.ToString("dd/MM/yyyy")}\n");

        // Creamos el objeto de la tienda
        Producto juego = new Producto("Elden Ring", 1200.00);

        // Ejecutamos la lógica que consume al paquete matemático
        juego.AplicarDescuentoTienda(15);

        Console.WriteLine("\nPrograma ejecutado de forma autónoma.");
        Console.ReadKey();
    }
}