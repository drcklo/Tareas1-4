using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4.Shared
{
    public class Estados
    {
        public Menu Menu { get; } = new Menu();
        public CarritoDeCompra Carrito { get; } = new CarritoDeCompra();
        public InterfazDeUsuario InterfazDeUsuario { get; set; } = new InterfazDeUsuario();

        public decimal PrecioTotal
        => Carrito.Ordenes.Sum(id => Menu.GetPizza(id)!.Precio);
    }
}
