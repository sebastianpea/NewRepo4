using System;
class PersonajeVulnerable
{
    public string nombre;
    public int nivel;
    public int puntosVida;

    public void MostrarInformacion()
    {
        Console.WriteLine($"[{nombre}] Nivel: {nivel} | HP: {puntosVida}");
    }
}
class PersonajeSeguro
{
    private string _nombre;
    private int _nivel;
    private int _puntosVida;
    private int _puntosVidaMax;

    // Constructor
    public PersonajeSeguro(string nombre, int puntosVidaMax)
    {
        _nombre = nombre;
        _puntosVidaMax = puntosVidaMax;
        _puntosVida = puntosVidaMax;
        _nivel = 1;
    }

    // Propiedad con validación
    public int PuntosVida
    {
        get { return _puntosVida; }
        set { _puntosVida = Math.Clamp(value, 0, _puntosVidaMax); }
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"[{_nombre}] Nivel: {_nivel} | HP: {_puntosVida}/{_puntosVidaMax}");
    }

    // Métodos sobrecargados
    public void RecuperarVida()
    {
        PuntosVida += 10;
        Console.WriteLine($"Recuperación básica (+10 HP) → HP actual: {_puntosVida}");
    }

    public void RecuperarVida(int cantidad)
    {
        PuntosVida += cantidad;
        Console.WriteLine($"Recuperación normal (+{cantidad} HP) → HP actual: {_puntosVida}");
    }

    public void RecuperarVida(int cantidad, bool potenciado)
    {
        int recuperacion = potenciado ? cantidad * 2 : cantidad;
        PuntosVida += recuperacion;
        Console.WriteLine($"Recuperación {(potenciado ? "POTENCIADA" : "normal")} (+{recuperacion} HP) → HP actual: {_puntosVida}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- DEMOSTRACIÓN DE POO: CLASES Y OBJETOS ---\n");

        PersonajeVulnerable heroeInseguro = new PersonajeVulnerable();
        heroeInseguro.nombre = "Guerrero Roto";
        heroeInseguro.nivel = 5;
        heroeInseguro.puntosVida = 80;

        heroeInseguro.puntosVida = -999; 
        heroeInseguro.nivel = -10;

        Console.Write("Estado alterado sin control: ");
        heroeInseguro.MostrarInformacion();

        Console.WriteLine("\n---------------------------------------------\n");

        // 2. Encapsulamiento y protección de datos
        PersonajeSeguro heroeSeguro = new PersonajeSeguro("Mago Sabio", 100);
        heroeSeguro.MostrarInformacion();

        heroeSeguro.PuntosVida = -50; 
        Console.Write("Intento de asignar HP negativo (-50): ");
        heroeSeguro.MostrarInformacion();

        heroeSeguro.PuntosVida = 50;

        // 3. Métodos sobrecargados
        Console.WriteLine("\n--- Probando Métodos Sobrecargados ---");
        heroeSeguro.RecuperarVida();        
        heroeSeguro.RecuperarVida(25);      
        heroeSeguro.RecuperarVida(15, true);  

        heroeSeguro.MostrarInformacion();

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}