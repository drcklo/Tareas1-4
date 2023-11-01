using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4.Shared
{
    public class Menu
    {
        public List<Pizzas> ListaDePizzas { get; set; }
        = new List<Pizzas>();
        public void AgregarPizza(Pizzas pizza)
        => ListaDePizzas.Add(pizza);
        public Pizzas? GetPizza(int id)
        => ListaDePizzas.SingleOrDefault(pizza => pizza.Id == id);
    }
}
