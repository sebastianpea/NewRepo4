using System;

namespace LibreriaMatematica
{
    // Clase diseñada especialmente para ser reutilizada en otros proyectos
    public class CalculadoraUtil
    {
        // Método que calcula el porcentaje de cualquier cantidad
        public static double ObtenerPorcentaje(double cantidad, double porcentaje)
        {
            if (cantidad <= 0 || porcentaje <= 0) return 0;
            return cantidad * (porcentaje / 100);
        }
    }
}