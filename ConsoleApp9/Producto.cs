using System;
using LibreriaMatematica; // IMPORTACIÓN: Aquí estamos reutilizando el Paquete A

namespace SistemaTienda
{
    public class Producto
    {
        private string _nombre;
        private double _precio;

        public Producto(string nombre, double precio)
        {
            _nombre = nombre;
            _precio = precio;
        }

        public void AplicarDescuentoTienda(double porcentaje)
        {
            // Reutilizamos directamente la función del otro paquete
            double descuento = CalculadoraUtil.ObtenerPorcentaje(_precio, porcentaje);
            double precioFinal = _precio - descuento;

            Console.WriteLine($"Producto: {_nombre} | Precio Original: ${_precio}");
            Console.WriteLine($"Descuento Aplicado ({porcentaje}%): -${descuento} | Total a Pagar: ${precioFinal}");
        }
    }
}