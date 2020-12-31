using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Pizza {
    class CebolaDecorator : PizzaDecorator{

        public CebolaDecorator(IPizza pizza) : base(pizza) {
        }

        public override string BuscarTipoPizza() {
            var pizza = base.BuscarTipoPizza();
            pizza += "\r\n com extra de cebola";
            return pizza;
        }
    }
}
