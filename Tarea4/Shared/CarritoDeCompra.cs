using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4.Shared
{
    public class CarritoDeCompra
    {
        public Clientes Clientes { get; set; } = new Clientes();
        public List<int> Ordenes { get; set; } = new List<int>();
        public bool Pagado { get; set; }
        public void Agregar(int pizzaId)
        => Ordenes.Add(pizzaId);
        public void RemoveAt(int pos)
        => Ordenes.RemoveAt(pos);


    }
}
