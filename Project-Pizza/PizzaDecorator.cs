using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Pizza {
    class PizzaDecorator : IPizza {

        private readonly IPizza _pizza;

        public PizzaDecorator(IPizza pizza) {
            _pizza = pizza;
        }

        public virtual string BuscarTipoPizza() {

            var pizza = _pizza.BuscarTipoPizza();
            return pizza;
        }
    }


}
